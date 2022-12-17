using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class GetFightProperty : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType fightPropSourceTarget;
        [JsonProperty] public readonly FightProperty fightProp;
        [JsonProperty] public readonly string globalValueKey;
        [JsonProperty] public readonly bool doOffStage;
    }
}
