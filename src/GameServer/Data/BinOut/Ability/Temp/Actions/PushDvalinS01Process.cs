using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class PushDvalinS01Process : ConfigAbilityAction
	{
		[JsonProperty] public readonly float time;
		[JsonProperty] public readonly float toPercentage;
		[JsonProperty] public readonly bool unBreak;
		[JsonProperty] public readonly bool setForce;
		[JsonProperty] public readonly float attenuation;
		[JsonProperty] public readonly Dictionary<string, float> vector;
		[JsonProperty] public readonly bool canBeHandledOnRecover;
    }
}
