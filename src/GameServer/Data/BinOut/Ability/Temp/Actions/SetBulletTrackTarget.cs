
using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetBulletTrackTarget : ConfigAbilityAction
    {
        [JsonProperty] public readonly SelectTargetsByShape otherTargets;
        [JsonProperty] public readonly bool notDoIfTrackTargetAlive;
    }
}
