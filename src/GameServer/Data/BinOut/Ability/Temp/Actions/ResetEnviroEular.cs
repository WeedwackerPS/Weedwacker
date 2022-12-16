using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ResetEnviroEular : ConfigAbilityAction
    {
        [JsonProperty] public readonly Dictionary<string, float> eularAngles;
    }
}
