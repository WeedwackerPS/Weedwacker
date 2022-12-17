using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachModifierToSurfaceTypeMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly ElementType surfaceType;
		[JsonProperty] public readonly ModifierWithPredicates[] modifiersWithPredicates;

		public class ModifierWithPredicates
        {
			[JsonProperty] public readonly string modifierName;
			[JsonProperty] public readonly BasePredicate[] predicates;
        }
    }
}
