using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AddRegionalPlayVarValue : BaseAction
    {
        [JsonProperty] public readonly string varType;
        [JsonProperty] public readonly int addValue;
    }
}
