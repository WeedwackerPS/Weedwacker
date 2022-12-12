using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ChangeEnviroWeather : BaseAction
    {
        [JsonProperty] public readonly int areaId;
        [JsonProperty] public readonly int climateType;
        [JsonProperty] public readonly float transDuration;
    }
}
