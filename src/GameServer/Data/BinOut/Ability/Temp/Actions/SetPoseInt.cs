﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetPoseInt : BaseAction
    {
        [JsonProperty] public readonly string intID;
        [JsonProperty] public readonly int value;
    }
}
