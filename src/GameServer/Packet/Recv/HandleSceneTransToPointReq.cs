using Vim.Math3d;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.SceneTransToPointReq)]
    internal class HandleSceneTransToPointReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            SceneTransToPointReq req = SceneTransToPointReq.Parser.ParseFrom(payload);

            ScenePointData spd;

            GameData.ScenePointDataMap.TryGetValue("scene" + req.SceneId + "_point", out spd);


            if (spd == null)
            {
                Logger.WriteErrorLine("Scene " + req.SceneId + " not found!");
                return;
            }

            BasePoint bp;

            spd.points.TryGetValue(req.PointId.ToString(), out bp);

            if (bp == null)
            {
                Logger.WriteErrorLine("Scene " + req.SceneId + " | Point " + req.PointId + " not found!");
                return;
            }

            float x, y, z;

            // TODO: SerializedName because there are some variants like: x, _x, X,...
            bp.tranPos.TryGetValue("x", out x);
            bp.tranPos.TryGetValue("y", out y);
            bp.tranPos.TryGetValue("z", out z);

            Vector3 transPos = new Vector3(x, y, z);

            await session.Player.World.TransferPlayerToSceneAsync(session.Player, EnterReason.TransPoint, req.SceneId == (uint)session.Player.SceneId ? EnterType.Goto : EnterType.Jump, (int)req.SceneId, transPos, false);

            await session.SendPacketAsync(new PacketSceneTransToPointRsp());
        }
    }
}
