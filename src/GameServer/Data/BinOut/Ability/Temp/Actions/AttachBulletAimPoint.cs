using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AttachBulletAimPoint : ConfigAbilityAction
    {
        [JsonProperty] public readonly string bulletAimPoint;
    }
}
