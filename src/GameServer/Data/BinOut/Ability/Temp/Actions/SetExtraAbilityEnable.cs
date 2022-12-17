using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetExtraAbilityEnable : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool enable;
    }
}
