using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class IgnoreMoveColToRockCol : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool ignore;
    }
}
