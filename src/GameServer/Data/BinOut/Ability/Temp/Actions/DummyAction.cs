using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class DummyAction : ConfigAbilityAction
    {
        [JsonProperty] public readonly bool doOffStage;
    }
}
