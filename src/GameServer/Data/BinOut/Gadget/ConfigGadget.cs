using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

namespace Weedwacker.GameServer.Data.BinOut.Gadget
{
    internal class ConfigGadget : ConfigEntity
    {
        [JsonProperty] public readonly bool hasEquip;
        [JsonProperty] public readonly bool hasAudio;
        [JsonProperty] public readonly bool hasModel;
        [JsonProperty] public readonly bool hasAbility;
        [JsonProperty] public readonly bool hasFollowWindZoneRotation;
        [JsonProperty] public readonly bool forceDontUseUpdateRigidbody;
        [JsonProperty] public readonly bool hasConnectTrigger;
        [JsonProperty] public readonly bool canBeCreatedOnPlatform;
        [JsonProperty] public readonly int connectTriggerPriority;
        [JsonProperty] public readonly bool ignoreChildSceneProp;
        [JsonProperty] public readonly bool moveRefreshGroundForceUp;
        [JsonProperty] public readonly ConfigCombat combat;
        [JsonProperty] public readonly ConfigEntityAbilityEntry[] abilities;
        [JsonProperty] public readonly ConfigTrigger field;
        [JsonProperty] public readonly ConfigTimer timer;
        [JsonProperty] public readonly ConfigMove move;

        public class ConfigTimer
        {
            [JsonProperty] public readonly bool lifeInfinite;
            [JsonProperty] public readonly float startCheckTime;
            [JsonProperty] public readonly float checkInterval;
            [JsonProperty] public readonly float lifeTime;
        }
    }
}
