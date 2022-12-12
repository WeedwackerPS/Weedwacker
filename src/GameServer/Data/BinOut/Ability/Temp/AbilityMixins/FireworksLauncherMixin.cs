using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class FireworksLauncherMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string startCountDownModifier;
        [JsonProperty] public readonly BaseAction[] OnEvtStartCountDown;
        [JsonProperty] public readonly BaseAction[] OnAllBulletsFired;
    }
}
