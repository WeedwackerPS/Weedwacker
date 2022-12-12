﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ChangeTag : BaseAction
    {
        [JsonProperty] public readonly bool isAdd;
        [JsonProperty] public readonly string tag;
    }
}
