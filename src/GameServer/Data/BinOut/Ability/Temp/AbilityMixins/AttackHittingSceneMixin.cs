using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class AttackHittingSceneMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] animEventIDs;
        [JsonProperty] public readonly BaseAction[] onHittingScene;
    }
}
