using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Gadget.ConfigGadgetPatternType;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;
using Weedwacker.GameServer.Enums;

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
        [JsonProperty] public readonly ConfigGadgetPattern gadget;
        [JsonProperty] public readonly ConfigEquipment equipment;
        // there's a lot more fields
        public class ConfigTimer
        {
            [JsonProperty] public readonly bool lifeInfinite;
            [JsonProperty] public readonly float startCheckTime;
            [JsonProperty] public readonly float checkInterval;
            [JsonProperty] public readonly float lifeTime;
        }

        public class ConfigEquipment
        {
            [JsonProperty] public readonly string attachTo;
            [JsonProperty] public readonly int subGadgetId;
            [JsonProperty] public readonly string subAttachTo;
            [JsonProperty] public readonly string auxToTrans;
            [JsonProperty] public readonly EquipEntityType equipEntityType;
            [JsonProperty] public readonly ConfigBladeElementFx bladeFx;
            [JsonProperty] public readonly ConfigBowData bowData;

            public class ConfigBowData
            {
                [JsonProperty] public readonly string bowRatioName;
                [JsonProperty] public readonly Vector bowStringLoosePoint;
                [JsonProperty] public readonly float bowStringMaxLen;
            }
        }
    }
}
