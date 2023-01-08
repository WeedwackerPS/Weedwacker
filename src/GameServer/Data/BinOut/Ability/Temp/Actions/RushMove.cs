using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class RushMove : ConfigAbilityAction
	{
		[JsonProperty] public readonly TargetType target;
		[JsonProperty] public readonly float timeRange;
		[JsonProperty] public readonly float minRange;
		[JsonProperty] public readonly float maxRange;
		[JsonProperty] public readonly ConfigBornType toPos;
    }
}
