﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ModifyElementDecrateMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string group;
    }
}
