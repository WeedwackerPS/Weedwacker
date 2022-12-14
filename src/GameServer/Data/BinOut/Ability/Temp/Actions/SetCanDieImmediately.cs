using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetCanDieImmediately : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool dieImmediately;
    }
}
