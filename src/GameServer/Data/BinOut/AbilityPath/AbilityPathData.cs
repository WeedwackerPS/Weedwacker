using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.AbilityPath
{
    internal class AbilityPathData
    {
        [JsonProperty] public readonly Dictionary<string, string[]> abilityPaths;
    }
}
