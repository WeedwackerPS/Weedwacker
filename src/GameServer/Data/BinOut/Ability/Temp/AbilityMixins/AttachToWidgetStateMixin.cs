using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToWidgetStateMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly int targetWidgetMaterialId;
		[JsonProperty] public readonly ConfigAbilityAction[] onActive;
		[JsonProperty] public readonly ConfigAbilityAction[] onDisable;
		[JsonProperty] public readonly ConfigAbilityAction[] onRemoved;
    }
}
