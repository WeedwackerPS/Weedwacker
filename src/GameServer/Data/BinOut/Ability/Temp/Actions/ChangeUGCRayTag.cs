using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class ChangeUGCRayTag : BaseAction
    {
        [JsonProperty] public readonly int rayTag;
    }
}
