using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class FireHitEffect : ConfigAbilityAction
    {
        [JsonProperty] public readonly string hitEntity;
        [JsonProperty] public readonly HitScene hitScene;

        public class HitScene
        {
            [JsonProperty] public readonly string defaultEffect;
            [JsonProperty] public readonly Dictionary<string, string> surfaceEffect;
        }
    }
}
