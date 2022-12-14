using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttackHittingSceneMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly object[] animEventIDs;
        [JsonProperty] public readonly ConfigAbilityAction[] onHittingScene;
    }
}
