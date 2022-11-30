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
    internal class HandlerSceneTransToPointReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            SceneTransToPointReq req = SceneTransToPointReq.Parser.ParseFrom(payload);
            ScenePointData scenePointData = session.Player.Scene.PointData;
            string pointId = req.PointId.ToString();
            if (session.Player.ProgressManager.UnlockedScenePoints[(int)req.SceneId].Contains((int)req.PointId) == scenePointData.points.ContainsKey(pointId))
            {
                Vector3 tranPos = new Vector3(scenePointData.points[pointId].tranPos["x"], scenePointData.points[pointId].tranPos["y"], scenePointData.points[pointId].tranPos["z"]);
                if (await session.Player.World.TransferPlayerToSceneAsync(session.Player, EnterReason.TransPoint, req.SceneId == (uint)session.Player.SceneId ? EnterType.Goto : EnterType.Jump, (int)req.SceneId, tranPos, false))
                {
                    await session.Player.SendPacketAsync(new PacketSceneEntityAppearNotify(session.Player.TeamManager.GetCurrentAvatarEntity(), tranPos, (Shared.Network.Proto.VisionType)Enums.VisionType.Born, 0));
                    await session.Player.SendPacketAsync(new PacketSceneTransToPointRsp(req.SceneId, req.PointId));
                    return;
                }
            }
            await session.Player.SendPacketAsync(new PacketSceneTransToPointRsp());
        }
    }
}
