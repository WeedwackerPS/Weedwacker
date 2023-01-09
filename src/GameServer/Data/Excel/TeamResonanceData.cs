using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("TeamResonanceExcelConfigData.json")]
    internal class TeamResonanceData
    {
        [JsonProperty] public readonly uint teamResonanceId;
        [JsonProperty] public readonly uint teamResonanceGroupId;
        [JsonProperty] public readonly uint level;
        [JsonProperty] public readonly uint? fireAvatarCount;
        [JsonProperty] public readonly uint? waterAvatarCount;
        [JsonProperty] public readonly uint? windAvatarCount;
        [JsonProperty] public readonly uint? electricAvatarCount;
        [JsonProperty] public readonly uint? grassAvatarCount;
        [JsonProperty] public readonly uint? iceAvatarCount;
        [JsonProperty] public readonly uint? rockAvatarCount;
        [JsonProperty] public readonly string? cond;
        [JsonProperty] public readonly ulong nameTextMapHash;
        [JsonProperty] public readonly ulong descTextMapHash;
        [JsonProperty] public readonly string openConfig;
        //[JsonProperty] public readonly int[] addProps; unused?
        [JsonProperty] public readonly float[] paramList;
    }
}
