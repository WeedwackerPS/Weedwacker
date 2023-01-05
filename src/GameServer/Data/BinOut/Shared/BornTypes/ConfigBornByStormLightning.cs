﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByStormLightning : BaseBornType
    {
        [JsonProperty] public readonly float hitHeightRatio;
        [JsonProperty] public readonly float selectRange;
        [JsonProperty] public readonly float lightningHitOrNotRatio;
    }
}
