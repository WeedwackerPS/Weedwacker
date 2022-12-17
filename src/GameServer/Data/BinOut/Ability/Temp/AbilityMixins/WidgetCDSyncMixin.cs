using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class WidgetCDSyncMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int itemId;
        [JsonProperty] public readonly int skillId;
        [JsonProperty] public readonly bool syncOnCDChange;
        [JsonProperty] public readonly bool syncOnChangeAvatar;
        [JsonProperty] public readonly float skillCDOffset;
    }
}
