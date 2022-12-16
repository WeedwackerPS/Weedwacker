using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetSkillAnchor : ConfigAbilityAction
	{
		[JsonProperty] public readonly BaseBornType born;
		[JsonProperty] public readonly bool canBeHandledOnRecover;
		[JsonProperty] public readonly bool doOffStage;
    }
}
