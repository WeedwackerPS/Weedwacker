using Vim.Math3d;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using static Weedwacker.GameServer.Systems.Script.Scene.DummyPoints;
using static Weedwacker.Shared.Network.Proto.MarkMapReq.Types;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class MapMarksManager
    {
        private Player player;

        public MapMarksManager(Player player)
        {
            this.player = player;
        }

        public async Task HandleMapMarkReq(MarkMapReq markMap)
        {
            Operation op = markMap.Op;
            switch (op) {
                case Operation.Add:
                    if (markMap.Mark.PointType == MapMarkPointType.FishPool)
                    {
                        await Teleport(player,markMap);
                    }
                    break;
                case Operation.Mod:
                    //TODO:
                    break;
                case Operation.Del:
                    //TODO:
                    break;
            }

        }

        public async Task Teleport(Player player,MarkMapReq markMap)
        {
            float y;
            try
            {
                y = Convert.ToInt64(markMap.Mark.Name);
            }
            catch (Exception e)
            {
                y = 350;
            }
            Vector3 pos = new Vector3(markMap.Mark.Pos.X,y, markMap.Mark.Pos.Z);
            await player.World.TransferPlayerToSceneAsync(player, Enums.EnterReason.TransPoint, markMap.Mark.SceneId == (uint)player.SceneId ? EnterType.Goto : EnterType.Jump, (int)markMap.Mark.SceneId, pos, false);
        }
    }
}
