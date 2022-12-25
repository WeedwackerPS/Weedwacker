using Newtonsoft.Json;


namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class SetTeamFightPropertyToOverrideMapKey : ConfigAbilityAction
    {
        [JsonProperty] public readonly string fightProperty;
        [JsonProperty] public readonly string overrideMapKey;
    }
}
