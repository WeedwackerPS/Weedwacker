using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class EntityDisplacementMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly float triggerDistance;
        [JsonProperty] public readonly ConfigAbilityAction[] actionList;
    }
}
