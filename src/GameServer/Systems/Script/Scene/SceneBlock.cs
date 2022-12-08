using System.Numerics;
using System.Text.RegularExpressions;
using NLua;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneBlock
    {
        private Lua LuaState;
        private int SceneId;
        private uint BlockId;

        public SortedList<uint, SceneGroupInfo> groups; // index
        public SortedList<uint, SceneGroup?> GroupsInfo = new(); // SceneGroupInfo::id

        public HashSet<SceneGroup?> StaticGroups => groups.Where(x => !x.Value.dynamic_load).Select(g => GroupsInfo[g.Value.id]).ToHashSet();

        public class SceneGroupInfo
        {
            private LuaTable Table;

            public uint id => (uint)(long)Table[$"{nameof(id)}"];
            public uint area => (uint?)(long?)Table[$"{nameof(area)}"] ?? 0;
            public Vector3 pos => new System.Numerics.Vector3((float?)(double?)Table[$"{nameof(pos)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(pos)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(pos)}.z"] ?? 0);
            public List<uint>? related_level_tag_series_list;
            public List<Dictionary<string, uint>>? life_cycle; // list of pairs "from": number, and "to": number
            public bool dynamic_load => (bool?)Table[$"{nameof(dynamic_load)}"] ?? false;
            public uint load_strategy => (uint?)(long?)Table[$"{nameof(load_strategy)}"] ?? 0;
            public int refresh_id => (int?)(long?)Table[$"{nameof(refresh_id)}"] ?? 0;
            public bool limit_drop => (bool?)Table[$"{nameof(limit_drop)}"] ?? false;
            public IsReplacable? is_replaceable;
            public bool force_unload_nodelay => (bool?)Table[$"{nameof(force_unload_nodelay)}"] ?? false;
            public uint vision_type => (uint?)(long?)Table[$"{nameof(vision_type)}"] ?? 0;
            public Business? business;
            public bool is_ignore_world_level_revise => (bool?)Table[$"{nameof(is_ignore_world_level_revise)}"] ?? false;
            public uint activity_revise_level_grow_id => (uint?)(long?)Table[$"{nameof(activity_revise_level_grow_id)}"] ?? 0;

            public class IsReplacable
            {
                public bool value;
                public uint version;
                public bool new_bin_only;
                public IsReplacable(LuaTable table)
                {
                    value = (bool?)table[$"{nameof(value)}"] ?? false;
                    version = (uint?)(long?)table[$"{nameof(version)}"] ?? 0;
                    new_bin_only = (bool?)table[$"{nameof(new_bin_only)}"] ?? false;
                }
            }
            public class Business
            {
                public readonly uint type;

                public Business(LuaTable table)
                {
                    type = (uint?)(long?)table[$"{nameof(type)}"] ?? 0;
                }
            }

            public SceneGroupInfo(Lua luaState, LuaTable table)
            {
                Table = table;
                is_replaceable = new(table);
                business = new(table);
                if (table[$"{nameof(related_level_tag_series_list)}"] != null)
                {
                    var list = new List<object>((IEnumerable<object>)(table[$"{nameof(related_level_tag_series_list)}"] as LuaTable).Values);
                    related_level_tag_series_list = new List<uint>(list.Select(w => (uint)(long)w));
                }
                if (table[$"{nameof(life_cycle)}"] != null)
                {
                    life_cycle = new();
                    var list = (table[$"{nameof(life_cycle)}"] as LuaTable).Values;
                    foreach (var dict in list)
                    {
                        var v1 = luaState.GetTableDict(dict as LuaTable).ToDictionary(w => (string)w.Key, w => (uint)(long)w.Value);
                        life_cycle.Add(v1);
                    }
                }
            }
        }

        internal static Task<SceneBlock?> CreateAsync(Lua lua, int sceneId, uint blockId, string scenePath)
        {
            SceneBlock block = new(lua, sceneId, blockId);
            return block.InitializeAsync(scenePath);
        }

        private async Task<SceneBlock?> InitializeAsync(string scenePath)
        {
            var blockInfo = new FileInfo(Path.Combine(scenePath, $"scene{SceneId}_block{BlockId}.lua"));

            if (!File.Exists(blockInfo.FullName))
            {
                Logger.DebugWriteLine($"Could not find file {blockInfo.FullName}");
                return null;
            }

            string script = blockInfo.FullName;
            script = Regex.Replace(script, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            LuaState.DoString($"_SCENE_BLOCK{BlockId} = {{}}");
            LuaState.DoString($"loadBlock{BlockId} = loadfile (\"" + script + "\"" + $", \"bt\" , _SCENE_BLOCK{BlockId})");
            LuaState.DoString($"loadBlock{BlockId}()");

            if (LuaState[$"_SCENE_BLOCK{BlockId}.{nameof(groups)}"] != null)
            {
                var gloups = LuaState.GetTable($"_SCENE_BLOCK{BlockId}.{nameof(groups)}");
                var gloupDict = LuaState.GetTableDict(gloups);
                groups = new SortedList<uint, SceneGroupInfo>(gloupDict.ToDictionary(w => (uint)(long)w.Key, w => new SceneGroupInfo(LuaState, w.Value as LuaTable)));
            }
            var tasks = new List<Task>();
            foreach (var entry in groups)
            {
                tasks.Add(AddGroup(entry.Value.id, new FileInfo(Path.Combine(scenePath, $"scene{SceneId}_group{entry.Value.id}.lua"))));
            }
            await Task.WhenAll(tasks);
            return this;
        }

        private async Task AddGroup(uint groupId, FileInfo path)
        {
            var group = await SceneGroup.CreateAsync(LuaState, SceneId, BlockId, groupId, path);
            GroupsInfo.Add(groupId, group);
        }

        private SceneBlock(Lua lua, int sceneId, uint blockId)
        {
            LuaState = lua;
            SceneId = sceneId;
            BlockId = blockId;
        }
    }
}
