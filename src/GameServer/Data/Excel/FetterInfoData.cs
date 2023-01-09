using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("FetterInfoExcelConfigData.json")]
    internal class FetterInfoData : FetterBaseClass
    {
        [JsonProperty] public readonly uint infoBirthMonth;
        [JsonProperty] public readonly uint infoBirthDay;
        [JsonProperty] public readonly ulong avatarNativeTextMapHash;
        [JsonProperty] public readonly ulong avatarVisionBeforTextMapHash;
        [JsonProperty] public readonly ulong avatarConstellationBeforTextMapHash;
        [JsonProperty] public readonly ulong avatarTitleTextMapHash;
        [JsonProperty] public readonly ulong avatarDetailTextMapHash;
        [JsonProperty] public readonly string avatarAssocType;
        [JsonProperty] public readonly ulong cvChineseTextMapHash;
        [JsonProperty] public readonly ulong cvJapaneseTextMapHash;
        [JsonProperty] public readonly ulong cvEnglishTextMapHash;
        [JsonProperty] public readonly ulong cvKoreanTextMapHash;
        [JsonProperty] public readonly ulong avatarVisionAfterTextMapHash;
        [JsonProperty] public readonly ulong avatarConstellationAfterTextMapHash;
        [JsonProperty] public readonly uint avatarId;
    }
}
