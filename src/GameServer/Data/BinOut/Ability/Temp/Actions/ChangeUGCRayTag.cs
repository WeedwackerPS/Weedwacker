﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ChangeUGCRayTag : ConfigAbilityAction
    {
        [JsonProperty] public readonly int rayTag;
    }
}
