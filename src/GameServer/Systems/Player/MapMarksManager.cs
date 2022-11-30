using Vim.Math3d;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using static Weedwacker.Shared.Network.Proto.MarkMapReq.Types;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class MapMarksManager
    {
        private readonly Player Owner;

        public MapMarksManager(Player owner){Owner = owner; }

        public async Task HandleMapMarkReq(MarkMapReq markMap)
        {
            Operation op = markMap.Op;
            switch (op) {
                case Operation.Add:
                    if (markMap.Mark.PointType == MapMarkPointType.FishPool)
                    {
                        await Teleport(markMap);
                    }
                    break;
                case Operation.Mod:
                    //TODO:
                    break;
                case Operation.Del:
                    //TODO:
                    break;
            }
            await Owner.World.BroadcastPacketAsync(new PacketMarkMapRsp(markMap.Mark));
        }

        public async Task Teleport(MarkMapReq markMap)
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
            await Owner.World.TransferPlayerToSceneAsync(Owner, Enums.EnterReason.TransPoint, markMap.Mark.SceneId == (uint)Owner.SceneId ? EnterType.Goto : EnterType.Jump, (int)markMap.Mark.SceneId, pos, false);
        }
    }
}
