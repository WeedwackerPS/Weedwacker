using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Shapes
{
    internal class ConfigTornadoZone : BaseShape
	{
		[JsonProperty] public readonly string shapeName;
		[JsonProperty] public readonly int strength;
		[JsonProperty] public readonly int attenuation;
		[JsonProperty] public readonly Dictionary<string, float> offset;
		[JsonProperty] public readonly Dictionary<string, float> dir;
    }
}
