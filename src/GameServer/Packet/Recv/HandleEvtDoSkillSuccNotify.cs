using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.EvtDoSkillSuccNotify)]
    internal class HandleEvtDoSkillSuccNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            // Because this packet is totally useless. So this handler exist for not logging "handler not found" or to use in feature
        }
    }
    
}
