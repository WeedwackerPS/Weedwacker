using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetExtraAbilityEnable : BaseAction
    {
        [JsonProperty] public readonly bool enable;
    }
}
