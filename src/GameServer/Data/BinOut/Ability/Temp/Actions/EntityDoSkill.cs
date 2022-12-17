using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EntityDoSkill : ConfigAbilityAction
    {
        [JsonProperty] public readonly int overtime;
        [JsonProperty] public readonly bool isHold;
    }
}
