using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DoBlinkByGlobalPos : ConfigAbilityAction
    {
        [JsonProperty] public readonly string positionKey;
    }
}
