using System.Numerics;
using System.Text.RegularExpressions;
using NLua;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class SceneInfo
    {
        Lua LuaState;
        private int SceneId;
        public SceneConfig? scene_config;

        public SortedList<int, uint>? blocks; // <index ,blockIds>
        public SortedList<uint, SceneBlock>? BlocksInfo; // blockId
        public SortedList<int, Rectangle>? block_rects = new(); // <index, rectangle>
        public DummyPoints? dummy_points; // load dummy points from Scene<sceneId>_dummy_points.lua
        public LuaTable routes_config;// => LuaState.GetTable("routes_config"); // load routes from ???

        public static Task<SceneInfo> CreateAsync(Lua lua, int sceneId, string scriptPath)
        {
            var scene = new SceneInfo();
            return scene.InitializeAsync(lua, sceneId, scriptPath);
        }

        private async Task<SceneInfo> InitializeAsync(Lua lua, int sceneId, string scriptPath)
        {
            LuaState = lua;
            SceneId = SceneId;
            LuaState.LoadCLRPackage();
            LuaState.DoString(@" import ('GameServer', 'Weedwacker.GameServer.Systems.Script')");
            FileInfo commonInfo = new(Path.Combine(scriptPath, "Config", "Excel", "CommonScriptConfig.lua"));
            string common = commonInfo.FullName;
            common = Regex.Replace(common, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\            
            lua.DoString("loadCommon = loadfile (\"" + common + "\"" + $", \"bt\")");
            lua.DoString("loadCommon()");
            FileInfo configEntityInfo = new(Path.Combine(scriptPath, "Config", "Json", "ConfigEntity.lua"));
            string configEntity = configEntityInfo.FullName;
            configEntity = Regex.Replace(configEntity, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            lua.DoString("loadConfigEntity = loadfile (\"" + configEntity + "\"" + $", \"bt\")");
            lua.DoString("loadConfigEntity()");
            FileInfo configEntityTypeInfo = new(Path.Combine(scriptPath, "Config", "Json", "ConfigEntityType.lua"));
            string configEntityType = configEntityTypeInfo.FullName;
            configEntityType = Regex.Replace(configEntityType, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            lua.DoString("loadConfigEntityType = loadfile (\"" + configEntityType + "\"" + $", \"bt\")");
            lua.DoString("loadConfigEntityType()");
            FileInfo configQuestTypeInfo = new(Path.Combine(scriptPath, "Config", "Json", "ConfigQuestType.lua"));
            string configQuestType = configQuestTypeInfo.FullName;
            configQuestType = Regex.Replace(configQuestType, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            lua.DoString("loadQuestType = loadfile (\"" + configQuestType + "\"" + $", \"bt\")");
            lua.DoString("loadQuestType()");
            lua.DoString($"_SCENE{sceneId} = {{}}");
            FileInfo sceneInfo = new(Path.Combine(scriptPath, "Scene", $"{sceneId}", $"scene{sceneId}.lua"));
            string sceneScript = sceneInfo.FullName;
            sceneScript = Regex.Replace(sceneScript, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            lua.DoString("loadScene = loadfile (\"" + sceneScript + "\"" + $", \"bt\" , _SCENE{sceneId})");
            lua.DoString("loadScene()");
            if (lua[$"_SCENE{sceneId}.{nameof(scene_config)}"] != null)
                scene_config = new(lua.GetTable($"_SCENE{sceneId}.{nameof(scene_config)}"));
            if (lua[$"_SCENE{sceneId}.{nameof(blocks)}"] != null)
            {
                var bloks = lua.GetTable($"_SCENE{sceneId}.{nameof(blocks)}");
                blocks = new SortedList<int, uint>(lua.GetTableDict(bloks).ToDictionary(w => (int)(long)w.Key, w => (uint)(long)w.Value));
                BlocksInfo = new();
                var tasks = new List<Task>();
                foreach (uint blockId in blocks.Values)
                {
                    tasks.Add(AddBlock(sceneId, blockId, Path.Combine(scriptPath, "Scene", $"{sceneId}")));
                }
                await Task.WhenAll(tasks);
            }
            if (lua[$"_SCENE{sceneId}.{nameof(block_rects)}"] != null)
            {
                var rects = lua.GetTable($"_SCENE{sceneId}.{nameof(block_rects)}");
                var rectDict = lua.GetTableDict(rects);
                block_rects = new SortedList<int, Rectangle>(rectDict.ToDictionary(w => (int)(long)w.Key, w => new Rectangle(w.Value as LuaTable)));
            }
            if (lua[$"_SCENE{sceneId}.{nameof(dummy_points)}"] != null)
            {
                dummy_points = DummyPoints.Create(lua, sceneId, Path.Combine(scriptPath, "Scene", $"{sceneId}", $"scene{sceneId}_{nameof(dummy_points)}.lua"));
            }

            return this;
        }

        private async Task AddBlock(int sceneId, uint blockId, string path)
        {
            var block = await SceneBlock.CreateAsync(LuaState, sceneId, blockId, path);
            BlocksInfo.Add(blockId, block);
        }

        public class SceneConfig
        {
            private LuaTable Table;
            // ONLY X,Z
            public Vector3 begin_pos => new Vector3((float?)(double?)Table[$"{nameof(begin_pos)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(begin_pos)}.z"] ?? 0);
            // ONLY X,Z
            public Vector3 size => new Vector3((float?)(double?)Table[$"{nameof(size)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(begin_pos)}.z"] ?? 0);
            public Vector3 born_pos => new Vector3((float?)(double?)Table[$"{nameof(born_pos)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(born_pos)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(born_pos)}.z"] ?? 0);
            public Vector3 born_rot => new Vector3((float?)(double?)Table[$"{nameof(born_rot)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(born_rot)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(born_rot)}.z"] ?? 0);
            public float? die_y => (int?)(long?)Table[$"die_y"];
            public RoomInfo room_safe_pos;
            // ONLY X,Z
            public Vector3 vision_anchor => new Vector3((float?)(double?)Table[$"{nameof(vision_anchor)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(vision_anchor)}.z"] ?? 0);

            public SceneConfig(LuaTable table)
            {
                Table = table;
                room_safe_pos = new(Table);
            }
        }

        public class Rectangle
        {
            private LuaTable Table;
            // ONLY X,Z
            public Vector3 min => new Vector3((float?)(double?)Table[$"{nameof(min)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(min)}.z"] ?? 0);
            // ONLY X,Z
            public Vector3 max => new Vector3((float?)(double?)Table[$"{nameof(max)}.x"] ?? 0, default, (float?)(double?)Table[$"{nameof(max)}.z"] ?? 0);

            public Rectangle(LuaTable table)
            {
                Table = table;
            }
        }

        public class RoomInfo
        {
            private LuaTable Table;
            public int? scene_id => (int?)(long?)Table[$"{nameof(scene_id)}"] ?? 0;
            public Vector3 safe_pos => new Vector3((float?)(double?)Table[$"{nameof(safe_pos)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(safe_pos)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(safe_pos)}.z"] ?? 0);
            public Vector3 safe_rot => new Vector3((float?)(double?)Table[$"{nameof(safe_rot)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(safe_rot)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(safe_rot)}.z"] ?? 0);

            public RoomInfo(LuaTable table)
            {
                Table = table[$"{nameof(SceneConfig.room_safe_pos)}"] as LuaTable;
            }
        }
    }
}
