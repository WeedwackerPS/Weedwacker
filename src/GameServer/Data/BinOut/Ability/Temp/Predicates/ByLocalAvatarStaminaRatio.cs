using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates
{
    internal class ByLocalAvatarStaminaRatio : BasePredicate
    {
        [JsonProperty] public readonly float staminaRatio;
        [JsonProperty] public readonly LogicType logic;
    }
}
