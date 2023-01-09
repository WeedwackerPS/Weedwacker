using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Weedwacker.GameServer.Systems.Ability;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data.BinOut.Talent
{
    internal class ModifyAbility : BaseConfigTalent
    {
        [JsonProperty] public readonly string abilityName;
        [JsonProperty] public readonly string paramSpecial;
        [JsonProperty] public readonly object? paramDelta; // plus or minus &(index in proudSkillData's or AvatarTalentData's paramList) or absolute delta
        [JsonProperty] public readonly object? paramRatio; // plus or minus &(index in proudSkillData's or AvatarTalentData's paramList) or absolute delta

        public override void Apply(BaseAbilityManager abilityManager, double[] paramList)
        {
            try
            {
                float special = abilityManager.AbilitySpecials[Utils.AbilityHash(abilityName)][Utils.AbilityHash(paramSpecial)];
                if (paramDelta is string deltaString)
                {
                    string index = Regex.Replace(deltaString, "%", "");
                    float delta = (float)paramList[int.Parse(index)];
                    special += delta;
                }
                else if (paramDelta is double asD)
                    special += (float)asD;

                if (paramRatio is string ratioString)
                {
                    string index = Regex.Replace(ratioString, "%", "");
                    float ratio = (float)paramList[int.Parse(index)];
                    special *= ratio;
                }
                else if (paramRatio is double asD)
                {
                    if (asD != 0)
                        special *= (float)asD;
                }

                abilityManager.AbilitySpecials[Utils.AbilityHash(abilityName)][Utils.AbilityHash(paramSpecial)] = special;
            }
            catch
            {
                Logger.WriteErrorLine("error applying talent ModifyAbility");
            }
        }
    }
}
