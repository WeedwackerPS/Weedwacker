using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class HittingOtherMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly Predicated[] onHittingOther;
    }
}
