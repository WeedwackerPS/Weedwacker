using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class EnableSceneTransformByName : BaseAction
    {
        [JsonProperty] public readonly string[] transformNames;
        [JsonProperty] public readonly bool setEnable;
    }
}
