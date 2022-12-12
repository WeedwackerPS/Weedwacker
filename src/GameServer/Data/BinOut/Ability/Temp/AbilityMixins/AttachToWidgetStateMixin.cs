using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachToWidgetStateMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly int targetWidgetMaterialId;
		[JsonProperty] public readonly BaseAction[] onActive;
		[JsonProperty] public readonly BaseAction[] onDisable;
		[JsonProperty] public readonly BaseAction[] onRemoved;
    }
}
