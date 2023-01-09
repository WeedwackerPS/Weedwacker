using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class PushPos : ConfigAbilityAction
    {
        [JsonProperty] public readonly ConfigBornType posType;
    }
}
