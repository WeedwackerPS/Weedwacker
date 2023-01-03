using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.AvatarDieAnimationEndReq)]
    internal class HandleAvatarDieAnimationEndReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            AvatarDieAnimationEndReq req = AvatarDieAnimationEndReq.Parser.ParseFrom(payload);

            await session.Player.TeamManager.OnAvatarDie((long)req.DieGuid);

            await session.SendPacketAsync(new PacketAvatarDieAnimationEndRsp(req.DieGuid, 0));
        }
    }
}
