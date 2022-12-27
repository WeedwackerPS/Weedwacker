using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ModifyBeHitDamageMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string Actor_ElementReactionCriticalDelta;
        [JsonProperty] public readonly bool ignoreEventInfo;
        [JsonProperty] public readonly ByAny[] predicates;
    }
}
