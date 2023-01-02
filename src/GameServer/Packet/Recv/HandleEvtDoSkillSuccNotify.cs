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
            EvtDoSkillSuccNotify req = EvtDoSkillSuccNotify.Parser.ParseFrom(payload);

            Player player = session.Player;

            uint skillId = req.SkillId;
            uint casterId = req.CasterId;

            // Call skill perform in the player's ability manager.
            //player.getAbilityManager().onSkillStart(session.getPlayer(), skillId, casterId);

            // Handle skill notify in other managers.
            //player.getStaminaManager().handleEvtDoSkillSuccNotify(session, skillId, casterId);
            //player.getEnergyManager().handleEvtDoSkillSuccNotify(session, skillId, casterId);
        }
    }
    
}
