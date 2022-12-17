using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetCrystalShieldHpToOverrideMap : ConfigAbilityAction
    {
        [JsonProperty] public readonly string overrideMapKey;
    }
}
