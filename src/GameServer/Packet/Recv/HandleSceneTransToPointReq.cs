using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using EnterReason = Weedwacker.GameServer.Enums.EnterReason;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.SceneTransToPointReq)]
    internal class HandleSceneTransToPointReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            SceneTransToPointReq req = SceneTransToPointReq.Parser.ParseFrom(payload);

            var ret = Retcode.RetFail;
            if (GameData.ScenePointDataMap.TryGetValue($"scene{req.SceneId}_point", out var spd))
            {
                if (spd.points!.TryGetValue(req.PointId.ToString(), out var bp))
                {
                    ret = Retcode.RetSucc;
                    Vim.Math3d.Vector3 pos = new(
                        bp.tranPos.FirstOrDefault(x => x.Key.Contains('x')).Value,
                        bp.tranPos.FirstOrDefault(x => x.Key.Contains('y')).Value,
                        bp.tranPos.FirstOrDefault(x => x.Key.Contains('z')).Value);
                    Vim.Math3d.Vector3 rot = new();
                    if (bp.tranRot is not null)
                    {
                        rot = new(
                            bp.tranRot.FirstOrDefault(x => x.Key.Contains('x')).Value,
                            bp.tranRot.FirstOrDefault(x => x.Key.Contains('y')).Value,
                            bp.tranRot.FirstOrDefault(x => x.Key.Contains('z')).Value);
                    }
                    await session.Player.World.TransferPlayerToSceneAsync(session.Player, EnterReason.TransPoint,
                        req.SceneId == (uint)session.Player.SceneId ? EnterType.Goto : EnterType.Jump, (int)req.SceneId,
                        pos, rot, false);
                }
                else
                    Logger.WriteErrorLine($"Scene {req.SceneId} | Point  {req.PointId} not found!");
            }
            else
                Logger.WriteErrorLine($"Scene {req.SceneId} not found!");

            await session.SendPacketAsync(new PacketSceneTransToPointRsp(ret, req.SceneId, req.PointId));
        }
    }
}
