using Weedwacker.GameServer.Data.BinOut.Ability.Temp;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Ability
{
    internal class MonsterAbilityManager : BaseAbilityManager
    {
        public override Dictionary<uint, Dictionary<uint, float>?>? AbilitySpecials => throw new NotImplementedException();

        public override HashSet<string> ActiveDynamicAbilities => throw new NotImplementedException();
        public override Dictionary<string, HashSet<string>> UnlockedTalentParams => throw new NotImplementedException();
        protected override Dictionary<uint, ConfigAbility> ConfigAbilityHashMap => throw new NotImplementedException();

        public MonsterAbilityManager(MonsterEntity owner) : base(owner)
        {
        }

        public override Task HandleAbilityInvokeAsync(AbilityInvokeEntry invoke)
        {
            return Task.CompletedTask;
        }

        public override void Initialize()
        {
        }
    }
}
