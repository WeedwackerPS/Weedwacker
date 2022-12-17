using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.BornTypes
{
    internal class ConfigBornByActionPoint : BaseBornType
	{
		[JsonProperty] public readonly PointType actionPointType;
		[JsonProperty] public readonly BaseSelectTargetType selectType;
		[JsonProperty] public readonly bool onGround;
    }
}
