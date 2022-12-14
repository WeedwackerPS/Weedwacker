using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class PlayerUidNotifyMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string opParam;
        [JsonProperty] public readonly int opType;
        [JsonProperty] public readonly LogicType logic;
        [JsonProperty] public readonly ConfigAbilityAction[] actions;
    }
}
