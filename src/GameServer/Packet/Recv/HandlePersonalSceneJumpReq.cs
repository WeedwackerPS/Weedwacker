using System.Numerics;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;
using EnterReason = Weedwacker.GameServer.Enums.EnterReason;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.PersonalSceneJumpReq)]
    internal class HandlePersonalSceneJumpReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            PersonalSceneJumpReq req = PersonalSceneJumpReq.Parser.ParseFrom(payload);

            var ret = Retcode.RetFail;
            Vector3 rot = new();
            Vector3 pos = new();
            uint transToSceneId = 0;
            if (GameData.ScenePointDataMap.TryGetValue($"scene{session.Player.SceneId}_point", out var spd))
            {
                if (spd.points!.TryGetValue(req.PointId.ToString(), out var bp))
                {
                    ret = Retcode.RetSucc;
                    transToSceneId = (bp as PersonalSceneJumpPoint).tranSceneId;
                    if (transToSceneId is 0)
                        transToSceneId = session.Player.Scene.PrevScene;

                    pos = new(
                        bp.tranPos.FirstOrDefault(x => x.Key.Contains('x')).Value,
                        bp.tranPos.FirstOrDefault(x => x.Key.Contains('y')).Value,
                        bp.tranPos.FirstOrDefault(x => x.Key.Contains('z')).Value);
                    rot = new();
                    if (bp.tranRot is not null)
                    {
                        rot = new(
                            bp.tranRot.FirstOrDefault(x => x.Key.Contains('x')).Value,
                            bp.tranRot.FirstOrDefault(x => x.Key.Contains('y')).Value,
                            bp.tranRot.FirstOrDefault(x => x.Key.Contains('z')).Value);
                    }
                    await session.Player.World.TransferPlayerToSceneAsync(session.Player, EnterReason.PersonalScene, EnterType.Jump, transToSceneId, pos, rot, false);

                }
                else
                    Logger.WriteErrorLine($"Scene {session.Player.SceneId} | Point  {req.PointId} not found!");
            }
            else
                Logger.WriteErrorLine($"Scene {session.Player.SceneId} not found!");

            await session.SendPacketAsync(new PacketPersonalSceneJumpRsp(ret, (uint)transToSceneId, pos));
        }
    }
}
