using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TryFindBlinkPointByBorn : ConfigAbilityAction
	{
		[JsonProperty] public readonly BaseBornType born;
		[JsonProperty] public readonly bool hitSceneTest;
		[JsonProperty] public readonly float limitY;
    }
}
