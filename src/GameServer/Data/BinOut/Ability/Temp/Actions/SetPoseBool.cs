using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetPoseBool : BaseAction
    {
        [JsonProperty] public readonly string boolID;
        [JsonProperty] public readonly bool value;
    }
}
