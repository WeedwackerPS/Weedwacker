using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

namespace Weedwacker.GameServer.Data.BinOut.Avatar
{
    internal class ConfigAvatar// : ConfigCharacter
    {
        [JsonProperty] public readonly ConfigEntityAbilityEntry[] abilities;
    }
}
