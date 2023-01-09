using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TryFindBlinkPointByBorn : ConfigAbilityAction
	{
		[JsonProperty] public readonly ConfigBornType born;
		[JsonProperty] public readonly bool hitSceneTest;
		[JsonProperty] public readonly float limitY;
    }
}
