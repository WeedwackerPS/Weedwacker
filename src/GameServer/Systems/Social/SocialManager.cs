using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Social
{
    internal class SocialManager
    {
        [BsonId][BsonElement("_id")] public uint OwnerId { get; private set; }
        [BsonIgnore] private Player.Player Owner;
        [BsonElement] public HashSet<int> ShowAvatarList = new(); // avatarId
        [BsonElement] public bool IsShowAvatar = false;
        [BsonSerializer(typeof(IntDictionarySerializer<Friendship>))]
        [BsonElement] public Dictionary<int, Friendship> Friends { get; private set; } = new(); // GameUid
        [BsonSerializer(typeof(IntDictionarySerializer<Friendship>))]
        [BsonElement] public Dictionary<int, Friendship> PendingRequests { get; private set; } = new(); // GameUid
        [BsonSerializer(typeof(IntDictionarySerializer<Friendship>))]
        [BsonElement] public Dictionary<int, Friendship> BlackList { get; private set; } = new(); // GameUid why does it use the Friendship proto lol
        [BsonElement] public HashSet<int> EmojiIdList { get; private set; } = new();

        public SocialManager(Player.Player owner)
        {
            OwnerId = owner.GameUid;
            Owner = owner;
        }

        public Task OnLoadAsync(Player.Player owner)
        {
            Owner = owner;

            return Task.CompletedTask;
        }

        public List<ShowAvatarInfo> GetShowAvatarInfoList()
        {
            List<ShowAvatarInfo> showAvatarInfoList = new();

            Player.Player player = Owner;
            AvatarManager avatars = player.Avatars;

            if (ShowAvatarList != null)
            {
                foreach (uint avatarId in ShowAvatarList)
                {
                    Avatar.Avatar avatar = avatars.GetAvatarById(avatarId);
                    showAvatarInfoList.Add(avatar.ToShowAvatarInfoProto());
                }
            }
            return showAvatarInfoList;
        }

        public SocialDetail GetSocialDetail(uint asker)
        {
            List<SocialShowAvatarInfo> socialShowAvatarInfoList = new();
            if (ShowAvatarList != null)
            {
                foreach (uint avatarId in ShowAvatarList)
                {
                    var avatar = Owner.Avatars.GetAvatarById(avatarId);
                    socialShowAvatarInfoList.Add(
                            new SocialShowAvatarInfo()
                            {
                                AvatarId = avatarId,
                                Level = avatar.Level,
                                CostumeId = avatar.Costume
                            });
                }
            }


            SocialDetail social = new SocialDetail()
            {
                Uid = Owner.GameUid,
                ProfilePicture = Owner.Profile.HeadImage,
                Nickname = Owner.Profile.Nickname,
                Signature = Owner.Profile.Signature,
                Level = (uint)Owner.PlayerProperties[Enums.PlayerProperty.PROP_PLAYER_LEVEL],
                Birthday = Owner.Profile.Birthday,
                WorldLevel = (uint)Owner.PlayerProperties.GetValueOrDefault(Enums.PlayerProperty.PROP_PLAYER_WORLD_LEVEL, 0),
                NameCardId = Owner.Profile.NameCardId,
                IsShowAvatar = IsShowAvatar,
                /* TODO
                FinishAchievementNum =,
                AvatarId = ,
                IsMpModeAvailable = ,
                FriendEnterHomeOption =,
                IsChatNoDisturb =,
                IsFriend =,
                OnlineId =,
                IsInBlacklist =,
                OnlineState =,
                Param = ,
                RemarkName = ,
                TowerFloorIndex = ,
                TowerLevelIndex = ,
                */
            };
            social.ShowAvatarInfoList.AddRange(socialShowAvatarInfoList);

            return social;
        }
    }
}
