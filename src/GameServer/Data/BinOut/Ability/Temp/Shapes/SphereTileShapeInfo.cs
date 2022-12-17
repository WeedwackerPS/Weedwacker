using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Shapes
{
    internal class SphereTileShapeInfo : BaseShape
    {
        [JsonProperty] public readonly float radius;
    }
}
