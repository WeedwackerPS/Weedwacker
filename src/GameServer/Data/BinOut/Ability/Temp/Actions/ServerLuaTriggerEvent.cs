using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ServerLuaTriggerEvent : ConfigAbilityAction
    {
        [JsonProperty] public readonly LuaCallType luaCallType;
        [JsonProperty] public readonly string sourceName;
    }
}
