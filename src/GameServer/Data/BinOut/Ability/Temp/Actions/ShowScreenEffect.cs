using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ShowScreenEffect : BaseAction
    {
        [JsonProperty] public readonly EffectType effectType;
        [JsonProperty] public readonly bool show;
    }
}
