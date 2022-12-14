using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ChangePlayMode : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool? canBeHandledOnRecover;
        [JsonProperty] public readonly PlayMode? toPlayMode;
    }
}
