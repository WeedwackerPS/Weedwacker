using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Social
{
    internal class Friendship
    {
        [BsonElement] public int FriendUid { get; private set; }
        [BsonElement] public PlayerProfile FriendProfile { get; private set; }
        public FriendBrief ToProto()
        {
            FriendBrief proto = new FriendBrief()
            {
                Uid = (uint)FriendUid,
                Nickname = FriendProfile.Nickname,
                Level = (uint)FriendProfile.Level,
                ProfilePicture = FriendProfile.HeadImage,
                WorldLevel = (uint)FriendProfile.WorldLevel,
                Signature = FriendProfile.Signature,
                OnlineState = GameServer.OnlinePlayers.ContainsKey(FriendUid) ? FriendOnlineState.Online : FriendOnlineState.Disconnect,
                LastActiveTime = (uint)FriendProfile.LastActiveTime,
                NameCardId = (uint)FriendProfile.NameCardId,
                Param = (uint)FriendProfile.DaysSinceLastLogin,
                IsGameSource = true,
                PlatformType = PlatformType.Editor,
            };
            if (GameServer.OnlinePlayers.TryGetValue(FriendUid, out Connection friendSession)) proto.IsMpModeAvailable = friendSession.Player.IsInMultiplayer();

            return proto;
        }
    }
}
