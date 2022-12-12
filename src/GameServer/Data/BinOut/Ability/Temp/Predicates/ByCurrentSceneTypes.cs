using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByCurrentSceneTypes : BasePredicate
    {
        [JsonProperty] public readonly SceneType[] SceneTypes;
    }
}
