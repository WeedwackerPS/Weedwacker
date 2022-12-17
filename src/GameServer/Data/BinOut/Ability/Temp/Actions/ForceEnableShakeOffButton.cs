using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ForceEnableShakeOffButton : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool enable;
    }
}
