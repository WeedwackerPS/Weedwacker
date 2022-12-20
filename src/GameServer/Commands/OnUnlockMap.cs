
using Microsoft.VisualBasic;
using System.CommandLine;
using System.Runtime.CompilerServices;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;


namespace Weedwacker.GameServer.Commands
{
    public static partial class ConsoleCommands
    {
        
        public static async Task unlockMap(IConsole console,int guid) // GameUid
        {
            Player targetPlayer = GameServer.OnlinePlayers[guid].Player;
            List<int> sceneid = new List<int>();
            Dictionary<int, ScenePointData> pointdataperscene = new Dictionary<int, ScenePointData>();
            Dictionary<int, HashSet<uint>> PerScenePointId = new();
            foreach (string i in GameData.ScenePointDataMap.Keys)
            {
                int a = int.Parse(i.Replace("scene", "").Replace("_point", ""));
                pointdataperscene.Add(a, GameData.ScenePointDataMap[i]);
                sceneid.Add(a);
                
            }
            foreach (int a in sceneid)
            {
                if (PerScenePointId.ContainsKey(a))
                {
                    console.WriteLine("There is already a same key value!");
                }
                else
                {
                    PerScenePointId.Add(a, new HashSet<uint>());
                    if (pointdataperscene[a].points != null)
                    {
                        foreach (var b in pointdataperscene[a].points.Keys)
                        {
                            if (b != null)
                            {
                                PerScenePointId[a].Add((uint)int.Parse(b));
                            }
                        }
                    }
                }
            }
            List<uint> sceneAreas = new List<uint>();
            uint[] sceneAreasList = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 100, 101, 102, 103, 200, 210, 300, 400, 401, 402, 403 };
            sceneAreas.AddRange(sceneAreasList);
            int[] OpenStateIdList = { 1409,1410,3,4,900,5,901,6,902,903,10,11,12,16,1300,2200,2201,27,29,800,801,803,45,47,1200,1201,54,55,3000,3001,3002,3003,3004,65,1100,1102,1104,1500,1502,1503,1504,2403,3300,3301,3302,3303,3304,1001,3305,1002,3306,1003,3307,3308,3309,1007,3311,1009,1011,1012,1401,1402,1403,1404,1405,1406,1407 };
            if (!GameServer.OnlinePlayers.ContainsKey(guid))
            {
                console.WriteLine("Player isn't online or doesn't exist");
                return;
            }
            else
            {
                await targetPlayer.ProgressManager.UnlockedSceneArea(sceneid,sceneAreas) ;
                await targetPlayer.ProgressManager.UnlockTransPoint(sceneid, PerScenePointId);
                foreach(int i in OpenStateIdList)
                {
                    await GameServer.OnlinePlayers[guid].Player.OpenStateManager.SetOpenStateAsync(i, 1);
                }
            }
            return;
        }
    }
}

