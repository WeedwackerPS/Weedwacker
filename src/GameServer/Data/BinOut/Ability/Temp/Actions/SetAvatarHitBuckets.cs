using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetAvatarHitBuckets : BaseAction
    {
        [JsonProperty] public readonly OverrideSetting overrideAvatarHitBucketSetting;

		public class OverrideSetting
        {
            [JsonProperty] public readonly int meleeBucketCount;
        }
    }
}
