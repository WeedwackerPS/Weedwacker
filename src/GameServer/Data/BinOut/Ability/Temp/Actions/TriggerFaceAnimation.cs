using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class TriggerFaceAnimation : ConfigAbilityAction
    {
        [JsonProperty] public readonly string faceAnimation;
    }
}
