using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AvatarLockForwardFlyMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly Dictionary<string, float> worldForward;
		[JsonProperty] public readonly float flySpeedScale;
		[JsonProperty] public readonly float flyBackSpeedScale;
		[JsonProperty] public readonly Dictionary<string, float> eularRawInput;
    }
}
