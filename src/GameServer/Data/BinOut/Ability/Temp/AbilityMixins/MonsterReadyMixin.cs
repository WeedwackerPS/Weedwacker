using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class MonsterReadyMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly ConfigAbilityAction[] onMonsterReady;
    }
}
