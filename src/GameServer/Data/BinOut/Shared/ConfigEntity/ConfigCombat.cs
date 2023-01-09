using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigCombat
    {
        [JsonProperty] public readonly ConfigCombatProperty property;
        [JsonProperty] public readonly ConfigCombatBeHit beHit;
        [JsonProperty] public readonly ConfigCombatLock combatLock;
        [JsonProperty] public readonly ConfigDie die;
        [JsonProperty] public readonly Dictionary<string, ConfigAttackEvent> animEvents;
        [JsonProperty] public readonly ConfigSummon summon;

        public class ConfigCombatBeHit
        {
            [JsonProperty] public readonly string hitBloodEffect;
            [JsonProperty] public readonly bool hitAutoRedirect;
            [JsonProperty] public readonly bool muteAllHit;
            [JsonProperty] public readonly bool muteAllHitEffect;
            [JsonProperty] public readonly bool muteAllHitText;
            [JsonProperty] public readonly bool ignoreMinHitVy;
            [JsonProperty] public readonly ConfigBeHitBlendShake blendShake;
        }

        public abstract class ConfigBeHitBlendShake
        {

        }

        public class ConfigBeHitBlendShakeByAinmator: ConfigBeHitBlendShake
        {
            [JsonProperty] public readonly ShakeByAinmator[] shakeFlagMap;

            public class ShakeByAinmator
            {
                [JsonProperty] public readonly float shakeFlag;
                [JsonProperty] public readonly string[] hitBoxNames;
            }
        }
    }
}
