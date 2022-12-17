using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions
{
    internal class AvatarEnterFocus : ConfigAbilityAction
    {
        [JsonProperty] public readonly FollowLower cameraFollowLower;
        [JsonProperty] public readonly FollowUpper cameraFollowUpper;
        [JsonProperty] public readonly bool cameraFastFocusMode;
        [JsonProperty] public readonly string dragButtonName;
        [JsonProperty] public readonly Assistance assistance;
        [JsonProperty] public readonly bool canMove;
        [JsonProperty] public readonly bool showCrosshair;

        public class FollowLower
        {
            [JsonProperty] public readonly float _x;
            [JsonProperty] public readonly float _z;
        }
        public class FollowUpper
        {
            [JsonProperty] public readonly float _x;
            [JsonProperty] public readonly float _y;
        }

        public class Assistance
        {
            [JsonProperty] public readonly Ass ps4;
            [JsonProperty] public readonly Ass ps5;
            [JsonProperty] public readonly Ass other;

            public class Ass
            {
                [JsonProperty] public readonly bool useGyro;
            }
        }
    }
}
