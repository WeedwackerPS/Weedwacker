using Newtonsoft.Json;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
    internal class ConfigDie
    {
        [JsonProperty] public readonly bool hasAnimatorDie;
        [JsonProperty] public readonly bool muteAllShaderDieEff;
        [JsonProperty] public readonly bool fallWhenAirDie;
        [JsonProperty] public readonly float dieEndTime;
        [JsonProperty] public readonly float dieForceDisappearTime;
        [JsonProperty] public readonly string dieDisappearEffect;
        [JsonProperty] public readonly float dieDisappearEffectDelay;
        [JsonProperty] public readonly EshaderData dieShaderData;
        [JsonProperty] public readonly float dieShaderEnableDurationTime;
        [JsonProperty] public readonly float dieShaderDisableDurationTime;
        [JsonProperty] public readonly float dieModelFadeDelay;
        [JsonProperty] public readonly bool useRagDoll;
        [JsonProperty] public readonly float ragDollDieEndTimeDelay;
        [JsonProperty] public readonly bool startDieEndAtOnce;
        [JsonProperty] public readonly bool ingoreElementDie;
    }
}
