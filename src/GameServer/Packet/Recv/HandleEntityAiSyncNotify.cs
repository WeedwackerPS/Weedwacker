using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.EntityAiSyncNotify)]
    internal class HandleEntityAiSyncNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            EntityAiSyncNotify req = EntityAiSyncNotify.Parser.ParseFrom(payload);

            if (req.LocalAvatarAlertedMonsterList.Count > 0)
            {
                await session.Player.Scene.BroadcastPacketAsync(new PacketEntityAiSyncNotify(req));
            }
        }
    }
}
