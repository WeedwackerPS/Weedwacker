using System.Numerics;
using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("AvatarHeroEntityExcelConfigData.json")]
    internal class AvatarHeroEntityData
    {
        [JsonProperty] public readonly uint avatarId;
        [JsonProperty] public readonly BigInteger prefabPathHashSuffix;
        [JsonProperty] public readonly uint prefabPathHashPre;
        [JsonProperty] public readonly long animatorConfigPathHashSuffix;
        [JsonProperty] public readonly uint animatorConfigPathHashPre;
    }
}
