using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class UpdateReactionDamage : ConfigAbilityAction
    {
        [JsonProperty] public readonly TargetType levelTarget;
        [JsonProperty] public readonly string reactionDamageName;
    }
}
