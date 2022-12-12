﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetExtraAbilityState : BaseAction
    {
        [JsonProperty] public readonly TargetType target;
        [JsonProperty] public readonly string state;
    }
}
