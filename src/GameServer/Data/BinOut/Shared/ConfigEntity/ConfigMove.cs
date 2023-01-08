using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigMove
    {
        [JsonProperty] public readonly ConfigMoveVelocityForce velocityForce;
        [JsonProperty] public readonly bool handleCombatTaskImmediately;

        public class ConfigMoveVelocityForce
        {
            [JsonProperty] public readonly bool muteAll;
            [JsonProperty] public readonly bool useAll;
            [JsonProperty] public readonly VelocityForceType[] includeForces;
            [JsonProperty] public readonly VelocityForceType[] excludeForces;
        }
    }
}
