using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class UseItem : ConfigAbilityAction
    {
        [JsonProperty] public readonly int itemId;
        [JsonProperty] public readonly int itemNum;
    }
}
