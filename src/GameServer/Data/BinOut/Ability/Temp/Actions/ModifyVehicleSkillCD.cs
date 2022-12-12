using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ModifyVehicleSkillCD : BaseAction
    {
        [JsonProperty] public readonly int skillID;
        [JsonProperty] public readonly int cdDelta;
    }
}
