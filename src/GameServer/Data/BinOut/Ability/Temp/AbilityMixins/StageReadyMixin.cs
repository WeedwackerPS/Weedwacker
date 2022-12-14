using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class StageReadyMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ConfigAbilityAction[] onStageReady;
    }
}
