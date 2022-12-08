using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.UnlockTransPointReq)]
    internal class HandleUnlockTransPointReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            UnlockTransPointReq req = UnlockTransPointReq.Parser.ParseFrom(payload);
            bool unlocked = await session.Player.ProgressManager.UnlockTransPoint((int)req.SceneId, (int)req.PointId);
            await session.SendPacketAsync(new PacketUnlockTransPointRsp(unlocked ? Retcode.RetSucc : Retcode.RetFail));
        }
    }
}
