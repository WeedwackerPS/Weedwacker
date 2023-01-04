using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.MonsterAIConfigHashNotify)]
    internal class HandleMonsterAIConfigHashNotify : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            // TODO: Handle MonsterAIConfigHashNotify
        }
    }
}
