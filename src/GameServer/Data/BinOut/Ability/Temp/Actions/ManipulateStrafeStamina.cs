using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ManipulateStrafeStamina : ConfigAbilityAction
    {
        [JsonProperty] public readonly string ratio;
    }
}
