using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Bullets
{
    internal class MultiBadmintonBullet : BaseBulletType
    {
        [JsonProperty] public readonly int bulletID;
        [JsonProperty] public readonly int weight;
        [JsonProperty] public readonly int speed;
    }
}
