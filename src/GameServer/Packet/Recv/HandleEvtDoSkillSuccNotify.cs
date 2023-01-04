using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.EvtDoSkillSuccNotify)]
    internal class HandleEvtDoSkillSuccNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            //TODO
        }
    }
    
}
