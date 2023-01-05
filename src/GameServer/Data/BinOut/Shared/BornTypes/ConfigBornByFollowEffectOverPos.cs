using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes
{
    internal class ConfigBornByFollowEffectOverPos : BaseBornType
	{
        [JsonProperty] public readonly bool byOwner;
    }
}
