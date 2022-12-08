using System.Numerics;
using System.Text.RegularExpressions;
using NLua;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Script.Scene
{
    internal class DummyPoints
    {
        public Dictionary<string, Position> dummy_points;
        private Lua LuaState;
        private int SceneId;

        public static DummyPoints? Create(Lua luaState, int sceneId, string script)
        {
            var points = new DummyPoints(luaState, sceneId);
            return points.Initialize(script);
        }

        private DummyPoints? Initialize(string script)
        {
            FileInfo dummiesInfo = new(script);
            string dummiesScript = dummiesInfo.FullName;
            dummiesScript = Regex.Replace(dummiesScript, @"(?<!\\)[\\](?!\\)", @"\\"); // replace \\ with \\\\
            try
            {
                LuaState.DoString($"_SCENE{SceneId}_POINTS = {{}}");
                LuaState.DoString("loadPoints = loadfile (\"" + dummiesScript + "\"" + $", \"bt\" , _SCENE{SceneId}_POINTS)");
                LuaState.DoString("loadPoints()");
            }
            catch
            {
                Logger.DebugWriteLine($"Failed to load {dummiesInfo.Name}");
                return null;
            }

            if (LuaState[$"_SCENE{SceneId}_POINTS.{nameof(dummy_points)}"] != null)
            {
                dummy_points = LuaState.GetTableDict(LuaState.GetTable($"_SCENE{SceneId}_POINTS.{nameof(dummy_points)}")).ToDictionary(w => (string)w.Key, w => new Position(w.Value as LuaTable));
            }

            return this;
        }
        private DummyPoints(Lua luaState, int sceneId)
        {
            LuaState = luaState;
            SceneId = sceneId;
        }

        public class Position
        {
            private LuaTable Table;
            public Vector3 pos => new Vector3((float?)(double?)Table[$"{nameof(pos)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(pos)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(pos)}.z"] ?? 0);
            public Vector3 rot => new Vector3((float?)(double?)Table[$"{nameof(rot)}.x"] ?? 0, (float?)(double?)Table[$"{nameof(rot)}.y"] ?? 0, (float?)(double?)Table[$"{nameof(rot)}.z"] ?? 0);

            public Position(LuaTable luaTable)
            {
                Table = luaTable;
            }
        }
    }
}
