using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByFollowEffectOverPos : ConfigBornType
	{
        [JsonProperty] public readonly bool byOwner;
    }
}
