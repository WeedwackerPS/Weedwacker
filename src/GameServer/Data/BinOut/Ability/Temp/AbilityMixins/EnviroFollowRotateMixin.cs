using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class EnviroFollowRotateMixin : BaseAbilityMixin
	{
		[JsonProperty] public readonly string deactiveOnCutsecneName;
		[JsonProperty] public readonly Dictionary<string, float> selfRotateOffSet;
    }
}
