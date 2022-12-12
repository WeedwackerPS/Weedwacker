using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttachModifierByActivityGachaStageMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] stageIDs;
        [JsonProperty] public readonly string[] modifierNameSteps;
    }
}
