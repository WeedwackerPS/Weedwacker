using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class PushInterActionByConfigPath : ConfigAbilityAction
    {
        [JsonProperty] public readonly string cfgPath;
        [JsonProperty] public readonly TargetType target;
    }
}
