using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.BornTypes
{
    internal class ConfigBornByFollowEffectOverPos : BaseBornType
	{
        [JsonProperty] public readonly bool byOwner;
    }
}
