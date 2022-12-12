﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ShowUICombatBar : BaseAction
    {
        [JsonProperty] public readonly bool show;
        [JsonProperty] public readonly bool fore;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
    }
}
