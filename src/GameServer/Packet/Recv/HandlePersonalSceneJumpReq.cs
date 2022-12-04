using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using Vim.Math3d;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.PersonalSceneJumpReq)]
    internal class HandlePersonalSceneJumpReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            PersonalSceneJumpReq req = PersonalSceneJumpReq.Parser.ParseFrom(payload);

            ScenePointData spd;
            BasePoint bp;

            GameData.ScenePointDataMap.TryGetValue("scene" + session.Player.SceneId + "_point", out spd);

            spd.points.TryGetValue(req.PointId.ToString(), out bp);

            if (bp == null)
            {
                Logger.WriteErrorLine("Scene " + session.Player.SceneId + " | Point " + req.PointId + " not found!");
                return;
            }

            int transToSceneId = (bp as PersonalSceneJumpPoint).tranSceneId;
            float x, y, z;


            // TODO: SerializedName because there are some variants like: x, _x, X,...
            bp.tranPos.TryGetValue("x", out x);
            bp.tranPos.TryGetValue("y", out y);
            bp.tranPos.TryGetValue("z", out z);

            Vector3 transPos = new(x, y, z);

            await session.Player.World.TransferPlayerToSceneAsync(session.Player, EnterReason.PersonalScene, EnterType.Jump, transToSceneId, transPos, false);

            await session.SendPacketAsync(new PacketPersonalSceneJumpRsp((uint)transToSceneId, transPos));

        }
    }
}
