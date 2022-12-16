using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class Summon : ConfigAbilityAction
	{
		[JsonProperty] public readonly int monsterID;
		[JsonProperty] public readonly int bornSlotIndex;
		[JsonProperty] public readonly BaseBornType born;
		[JsonProperty] public readonly int summonTag;
		[JsonProperty] public readonly bool aliveByOwner;
		[JsonProperty] public readonly bool hasDrop;
		[JsonProperty] public readonly bool hasExperience;
		[JsonProperty] public readonly bool sightGroupWithOwner;
		[JsonProperty] public readonly BasePredicate[] predicates;
    }
}
