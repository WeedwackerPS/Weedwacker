using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.BornTypes
{
    internal class ConfigBornByPredicatePoint : BaseBornType
    {
        [JsonProperty] public readonly float timeForPredictive;
        [JsonProperty] public readonly bool onGround;
    }
}
