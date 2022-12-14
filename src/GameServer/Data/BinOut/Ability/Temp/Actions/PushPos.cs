using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class PushPos : ConfigAbilityAction
    {
        [JsonProperty] public readonly BaseBornType posType;
    }
}
