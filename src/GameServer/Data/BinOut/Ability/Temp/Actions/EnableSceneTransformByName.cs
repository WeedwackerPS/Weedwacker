using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableSceneTransformByName : ConfigAbilityAction
    {
        [JsonProperty] public readonly string[] transformNames;
        [JsonProperty] public readonly bool setEnable;
    }
}
