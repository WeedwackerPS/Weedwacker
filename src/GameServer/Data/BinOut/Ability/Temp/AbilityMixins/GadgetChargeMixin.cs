using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class GadgetChargeMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly ElementType chargeType;
		[JsonProperty] public readonly float chargeRatio;
		[JsonProperty] public readonly float chargeValue;
		[JsonProperty] public readonly float maxChargeValue;
		[JsonProperty] public readonly float[] valueSteps;
		[JsonProperty] public readonly string[] modifierNameSteps;
		[JsonProperty] public readonly string globalValueKey;
		[JsonProperty] public readonly string ratioGlobalValueKey;
    }
}
