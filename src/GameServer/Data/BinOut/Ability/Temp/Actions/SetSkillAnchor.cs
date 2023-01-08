using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetSkillAnchor : ConfigAbilityAction
	{
		[JsonProperty] public readonly ConfigBornType born;
		[JsonProperty] public readonly bool canBeHandledOnRecover;
		[JsonProperty] public readonly bool doOffStage;
    }
}
