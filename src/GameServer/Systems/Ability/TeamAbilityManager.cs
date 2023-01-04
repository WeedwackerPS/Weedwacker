using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Systems.Player;

namespace Weedwacker.GameServer.Systems.Ability
{
    internal class TeamAbilityManager : BaseAbilityManager
    {
        public TeamAbilityManager(TeamManager teamManager) : base(teamManager)
        {
        }

        protected override Dictionary<uint, ConfigAbility> ConfigAbilityHashMap { get => throw new NotImplementedException(); }

        public override Dictionary<string, Dictionary<string, float>?>? AbilitySpecials => (Owner as TeamManager).CurrentTeamInfo.AbilitySpecials;

        public override HashSet<string> ActiveDynamicAbilities => throw new NotImplementedException();

        public override Dictionary<string, HashSet<string>> UnlockedTalentParams => throw new NotImplementedException();
    }
}
