using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class ServerCreateGadgetOnKillMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly int[] gadgetIDList;
        [JsonProperty] public readonly int campID;
        [JsonProperty] public readonly TargetType campTargetType;
        [JsonProperty] public readonly bool randomCreate;
    }
}
