using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.SelectTargetType
{
    internal class SelectActionPointByID : BaseSelectTargetType
    {
        [JsonProperty] public readonly int actionPointID;
    }
}
