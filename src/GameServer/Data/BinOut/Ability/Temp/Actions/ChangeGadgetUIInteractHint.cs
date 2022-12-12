using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ChangeGadgetUIInteractHint : BaseAction
    {
        [JsonProperty] public readonly string hintTextMapId;
        [JsonProperty] public readonly bool canBeHandledOnRecover;
    }
}
