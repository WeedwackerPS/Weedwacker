﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ShowExtraAbility : BaseAction
    {
        [JsonProperty] public readonly int skillID;
        [JsonProperty] public readonly TargetType target;
    }
}
