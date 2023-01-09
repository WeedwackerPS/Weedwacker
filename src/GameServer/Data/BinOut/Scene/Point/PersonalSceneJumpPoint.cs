using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Scene.Point
{
    internal class PersonalSceneJumpPoint : BasePoint
    {
        [JsonProperty] public readonly uint tranSceneId;
        [JsonProperty] public readonly Dictionary<string, float> triggerSize;
        [JsonProperty] public readonly float closeTime;
    }
}
