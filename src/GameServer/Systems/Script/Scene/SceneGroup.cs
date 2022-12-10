using System.Numerics;
using System.Text.RegularExpressions;
using NLua;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneGroup
    {
        private Lua LuaState;
        private int SceneId;
        public readonly uint BlockId;

        public readonly uint group_id;
        public SortedDictionary<uint, Monster>? monsters;
        public SortedList<uint, Npc>? npcs;
        public SortedList<uint, Gadget>? gadgets;
        public List<Region>? regions;
        public List<Trigger>? triggers;
        public List<Variable>? variables;
        public SortedList<uint, Suite> suites;
        public InitConfig init_config;

        internal async void OnInitAsync(World.Scene scene)
        {
            if (init_config == null)
                return;
            try
            {
                Suite init_suite = suites[init_config.suite];
                if (!init_suite.monsters.Any()) return;
                var monsterEntities = new List<MonsterEntity>();
                foreach (uint monsterIndex in init_suite.monsters)
                {
                    Monster monster = monsters[monsterIndex];
                    var entity = await MonsterEntity.CreateAsync(scene, GameData.MonsterDataMap[(int)monster.monster_id], (int)monster.level, monster, BlockId, group_id);
                    monsterEntities.Add(entity);
                }
                await scene.AddEntitiesAsync(monsterEntities);
                Logger.DebugWriteLine($"Loaded SceneGroup{group_id} init monsters");
            }
            catch(Exception e)
            {
                Logger.WriteErrorLine("error loading scene group", e);
                Logger.WriteErrorLine(e.StackTrace);
            }
        }

        internal async void OnUnload(World.Scene scene)
        {
            IEnumerable<ScriptEntity> toUnload = scene.ScriptEntities.Values.Where(w => w.GroupId == group_id);
            await scene.RemoveEntitiesAsync(toUnload, Shared.Network.Proto.VisionType.Remove);
            Logger.DebugWriteLine($"Unloaded SceneGroup{group_id} monsters");
        }

        public class Suite
        {
            public readonly List<uint>? monsters; // config_id
            public readonly List<uint>? npcs; // config_id
            public readonly List<uint>? gadgets; // config_id
            public readonly List<uint>? regions; // config_id
            public readonly List<string>? triggers; // substring of trigger's name/action
            public readonly uint rand_weight;
            public readonly bool ban_refresh;

            public Suite(Lua luastate, LuaTable table)
            {
                rand_weight = (uint?)(long?)table[$"{nameof(rand_weight)}"] ?? 0;
                ban_refresh = (bool?)table[$"{nameof(ban_refresh)}"] ?? false;
                if (table[$"{nameof(monsters)}"] != null)
                    monsters = new List<uint>(luastate.GetTableDict(table[$"{nameof(monsters)}"] as LuaTable).Values.Select(w => (uint)(long)w));
                if (table[$"{nameof(npcs)}"] != null)
                    npcs = new List<uint>(luastate.GetTableDict(table[$"{nameof(npcs)}"] as LuaTable).Values.Select(w => (uint)(long)w));
                if (table[$"{nameof(gadgets)}"] != null)
                    gadgets = new List<uint>(luastate.GetTableDict(table[$"{nameof(gadgets)}"] as LuaTable).Values.Select(w => (uint)(long)w));
                if (table[$"{nameof(regions)}"] != null)
                    regions = new List<uint>(luastate.GetTableDict(table[$"{nameof(regions)}"] as LuaTable).Values.Select(w => (uint)(long)w));
                if (table[$"{nameof(monsters)}"] != null)
                    triggers = new List<string>(luastate.GetTableDict(table[$"{nameof(triggers)}"] as LuaTable).Values.Select(w => (string)w));
            }
        }

        public abstract class SpawnInfo
        {
            public readonly uint config_id;
            public readonly uint area_id;
            public readonly Vector3 pos;
            public readonly Vector3 rot;

            protected SpawnInfo(LuaTable table)
            {
                config_id = (uint?)(long?)table[$"{nameof(config_id)}"] ?? 0;
                area_id = (uint?)(long?)table[$"{nameof(area_id)}"] ?? 0;
                pos = new Vector3((float?)(double?)table[$"{nameof(pos)}.x"] ?? 0, (float?)(double?)table[$"{nameof(pos)}.y"] ?? 0, (float?)(double?)table[$"{nameof(pos)}.z"] ?? 0);
                rot = new Vector3((float?)(double?)table[$"{nameof(rot)}.x"] ?? 0, (float?)(double?)table[$"{nameof(rot)}.y"] ?? 0, (float?)(double?)table[$"{nameof(rot)}.z"] ?? 0);
            }
        }

        public class Variable
        {
            public readonly uint configId;
            public readonly string name;
            public readonly int value;
            public readonly bool no_refresh;
            public Variable(LuaTable table)
            {
                configId = (uint?)(long?)table[$"{nameof(configId)}"] ?? 0;
                name = (string?)table[$"{nameof(name)}"] ?? "";
                value = (int?)(long?)table[$"{nameof(value)}"] ?? 0;
                no_refresh = (bool?)table[$"{nameof(no_refresh)}"] ?? false;
            }
        }
        public class InitConfig
        {
            public readonly uint suite;
            public readonly uint end_suite;
            public readonly bool rand_suite;

            public InitConfig(LuaTable table)
            {
                suite = (uint?)(long?)table[$"{nameof(suite)}"] ?? 0;
                end_suite = (uint?)(long?)table[$"{nameof(end_suite)}"] ?? 0;
                rand_suite = (bool?)table[$"{nameof(rand_suite)}"] ?? false;
            }
        }

        public class Monster : SpawnInfo
        {
            public readonly uint monster_id;
            public readonly uint level;
            public readonly string? drop_tag;
            public readonly uint pose_id;

            public Monster(LuaTable table) : base(table)
            {
                monster_id = (uint)(long)table[$"{nameof(monster_id)}"];
                level = (uint?)(long?)table[$"{nameof(level)}"] ?? 0;
                drop_tag = (string?)table[$"{nameof(drop_tag)}"] ?? "";
                pose_id = (uint?)(long?)table[$"{nameof(pose_id)}"] ?? 0;
            }
        }

        public class Npc : SpawnInfo
        {
            public readonly uint npc_id;
            public readonly uint room;

            public Npc(LuaTable table) : base(table)
            {
                npc_id = (uint?)(long?)table[$"{nameof(npc_id)}"] ?? 0;
                room = (uint?)(long?)table[$"{nameof(room)}"] ?? 0;
            }
        }

        public class Gadget : SpawnInfo
        {
            public readonly uint gadget_id;
            public readonly uint level;
            public readonly string? drop_tag;
            public readonly uint route_id;
            public readonly bool showcutscene;
            public readonly bool isOneoff;
            public readonly bool persistent;
            public readonly Explore? explore;

            public Gadget(LuaTable table) : base(table)
            {
                if (table[$"{nameof(explore)}"] != null)
                    explore = new(table[$"{nameof(explore)}"] as LuaTable);
                gadget_id = (uint?)(long?)table[$"{nameof(gadget_id)}"] ?? 0;
                level = (uint?)(long?)table[$"{nameof(level)}"] ?? 0;
                drop_tag = (string?)table[$"{nameof(drop_tag)}"] ?? "";
                route_id = (uint?)(long?)table[$"{nameof(route_id)}"] ?? 0;
                showcutscene = (bool?)table[$"{nameof(showcutscene)}"] ?? false;
                isOneoff = (bool?)table[$"{nameof(isOneoff)}"] ?? false;
                persistent = (bool?)table[$"{nameof(persistent)}"] ?? false;
            }

            public class Explore
            {
                public readonly string name;
                public readonly uint exp;

                public Explore(LuaTable table)
                {
                    name = (string?)table[$"{nameof(name)}"] ?? "";
                    exp = (uint?)(long?)table[$"{nameof(exp)}"] ?? 0;
                }
            }
        }

        public class Region
        {
            public readonly uint config_id;
            public readonly RegionShape shape;
            public readonly float radius;
            public readonly Vector3 pos;
            public readonly uint area_id;

            public Region(LuaTable table)
            {
                config_id = (uint?)(long?)table[$"{nameof(config_id)}"] ?? 0;
                shape = (RegionShape)((uint?)(long?)table[$"{nameof(shape)}"] ?? 0);
                radius = table[$"{nameof(radius)}"] is double ? (float?)(double?)table[$"{nameof(radius)}"] ?? 0 : BitConverter.UInt32BitsToSingle((uint?)(long?)table[$"{nameof(radius)}"] ?? 0);
                pos = new Vector3((float?)(double?)table[$"{nameof(pos)}.x"] ?? 0, (float?)(double?)table[$"{nameof(pos)}.y"] ?? 0, (float?)(double?)table[$"{nameof(pos)}.z"] ?? 0);
                area_id = (uint?)(long?)table[$"{nameof(area_id)}"] ?? 0;
            }
        }

        public class Trigger
        {
            public readonly uint config_id;
            public readonly string name;
            public readonly EventType @event;
            public readonly string source;
            public readonly string condition;
            public readonly string action;
            public readonly uint trigger_count;
            public readonly bool forbid_guest;

            public Trigger(LuaTable table)
            {
                config_id = (uint?)(long?)table[$"{nameof(config_id)}"] ?? 0;
                name = (string?)table[$"{nameof(name)}"] ?? "";
                @event = (EventType)((uint?)(long?)table[$"event"] ?? 0);
                source = (string?)table[$"{nameof(source)}"] ?? "";
                condition = (string?)table[$"{nameof(condition)}"] ?? "";
                action = (string?)table[$"{nameof(action)}"] ?? "";
                trigger_count = (uint?)(long?)table[$"{nameof(trigger_count)}"] ?? 0;
                forbid_guest = (bool?)table[$"{nameof(forbid_guest)}"] ?? false;
            }
        }

        // for reference
        struct SeelieVariable1
        {
            public uint point_sum;
            public uint route_2;
            public uint gadget_seelie;
            public uint final_point;
        }

        internal static Task<SceneGroup?> CreateAsync(Lua luaState, int sceneId, uint blockId, uint id, FileInfo fileInfo)
        {
            SceneGroup group = new(luaState, sceneId, blockId, id);
            return group.InitializeAsync(fileInfo);
        }

        private SceneGroup(Lua luaState, int sceneId, uint blockId, uint groupId)
        {
            LuaState = luaState;
            SceneId = sceneId;
            BlockId = blockId;
            group_id = groupId;
        }

        private async Task<SceneGroup?> InitializeAsync(FileInfo groupInfo)
        {
            string script = groupInfo.FullName;

            script = Regex.Replace(script, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            LuaState.DoString($"_SCENE_GROUP{group_id} = {{EventType = _G.EventType; GadgetState = _G.GadgetState; RegionShape = _G.RegionShape; QuestState = _G.QuestState; EntityType = _G.EntityType; ScriptLib = _G.ScriptLib}}");
            LuaState.DoString(@$"_SCENE_GROUP{group_id}.require = function(...)
                                end");
            LuaState.DoString($"success, loadGroup{group_id} = pcall(loadfile ,\"" + script + "\"" + $", \"bt\" , _SCENE_GROUP{group_id})");
            try
            {
                LuaState.DoString($"loadGroup{group_id}()");
            }
            catch
            {
                Logger.DebugWriteLine($"Failed to load scene group: {group_id}");
                return null;
            }

            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(init_config)}"] != null)
                init_config = new(LuaState[$"_SCENE_GROUP{group_id}.{nameof(init_config)}"] as LuaTable);
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(monsters)}"] != null)
            {
                var table = LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(monsters)}"));
                monsters = new SortedDictionary<uint, Monster>(table.ToDictionary(w => (uint)(long)(w.Value as LuaTable)["config_id"], w => new Monster(w.Value as LuaTable)));
            }
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(npcs)}"] != null)
                npcs = new SortedList<uint, Npc>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(npcs)}")).ToDictionary(w => (uint)(long)w.Key, w => new Npc(w.Value as LuaTable)));
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(gadgets)}"] != null)
                gadgets = new SortedList<uint, Gadget>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(gadgets)}")).ToDictionary(w => (uint)(long)w.Key, w => new Gadget(w.Value as LuaTable)));
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(regions)}"] != null)
                regions = new List<Region>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(regions)}")).Values.Select(w => new Region(w as LuaTable)));
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(triggers)}"] != null)
                triggers = new List<Trigger>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(triggers)}")).Values.Select(w => new Trigger(w as LuaTable)));
            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(variables)}"] != null)
                variables = new List<Variable>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(variables)}")).Values.Select(w => new Variable(w as LuaTable)));

            if (LuaState[$"_SCENE_GROUP{group_id}.{nameof(suites)}"] != null)
                suites = new SortedList<uint, Suite>(LuaState.GetTableDict(LuaState.GetTable($"_SCENE_GROUP{group_id}.{nameof(suites)}")).ToDictionary(w => (uint)(long)w.Key, w => new Suite(LuaState, w.Value as LuaTable)));

            return this;
        }
    }
}
