using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class CallLuaTask : BaseAction
    {
        [JsonProperty] public readonly int targetAlias;
        [JsonProperty] public readonly int valueInt;
    }
}
