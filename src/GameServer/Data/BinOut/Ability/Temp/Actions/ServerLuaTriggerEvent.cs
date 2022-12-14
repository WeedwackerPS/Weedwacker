using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ServerLuaTriggerEvent : BaseAction
    {
        [JsonProperty] public readonly LuaCallType luaCallType;
        [JsonProperty] public readonly string sourceName;
    }
}
