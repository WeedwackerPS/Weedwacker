using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ServerLuaCall : ConfigAbilityAction
    {
        [JsonProperty] public readonly LuaCallType luaCallType;
        [JsonProperty] public readonly string funcName;
        [JsonProperty] public readonly float param1;
        [JsonProperty] public readonly float param2;
        [JsonProperty] public readonly float param3;
    }
}
