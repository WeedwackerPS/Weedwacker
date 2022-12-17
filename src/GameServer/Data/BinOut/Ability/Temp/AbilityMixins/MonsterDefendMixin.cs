using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class MonsterDefendMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly float defendAngle;
		[JsonProperty] public readonly string defendTriggerID;
		[JsonProperty] public readonly string[] stateIDs;
		[JsonProperty] public readonly ConfigAbilityAction[] onDefendSucceded;
    }
}
