using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Systems.Avatar
{
    // MongoDb collection: "avatars"
    internal class AvatarManager
    {
        [BsonId]
        [BsonElement("_id")]
        public uint OwnerId { get; private set; } // GameUid
        [BsonSerializer(typeof(UIntDictionarySerializer<Avatar>))]
        [BsonElement] public Dictionary<uint, Avatar> Avatars { get; private set; }
        [BsonIgnore] private Player.Player Owner; // Loaded by DatabaseManager
        [BsonIgnore] public Dictionary<ulong, Avatar> AvatarsGuid { get; private set; } = new();

        public AvatarManager(Player.Player owner)
        {
            OwnerId = owner.GameUid;
            Owner = owner;
            Avatars = new();
        }

        public async Task OnLoadAsync(Player.Player owner)
        {
            Owner = owner;
            AvatarsGuid = new();
            var tasks = new List<Task>();
            foreach (Avatar avatar in Avatars.Values)
            {
                tasks.Add(avatar.OnLoadAsync(owner));
            }
            await Task.WhenAll(tasks);
            foreach (Avatar avatar in Avatars.Values)
            {
                AvatarsGuid.Add(avatar.Guid, avatar);
            }
        }
        public Avatar? GetAvatarById(uint id)
        {
            return Avatars.GetValueOrDefault(id, null);
        }

        public Avatar? GetAvatarByGuid(ulong id)
        {
            return AvatarsGuid.GetValueOrDefault(id, null);
        }

        public bool HasAvatar(uint id)
        {
            return Avatars.ContainsKey(id);
        }

        public async Task<bool> AddAvatar(Avatar avatar, bool notify = true)
        {
            if (avatar.Data == null || HasAvatar(avatar.AvatarId))
            {
                return false;
            }

            // Put into maps
            Avatars.Add(avatar.AvatarId, avatar);
            AvatarsGuid.Add(avatar.Guid, avatar);
            var filter = Builders<AvatarManager>.Filter.Where(w => w.OwnerId == Owner.GameUid);
            var update = Builders<AvatarManager>.Update.Set($"{nameof(Avatars)}.{avatar.AvatarId}", avatar);
            await DatabaseManager.UpdateAvatarsAsync(filter, update);

            bool addToTeam = false;
            if (notify) await Owner.SendPacketAsync(new PacketAvatarAddNotify(avatar, addToTeam));
            if (Owner.TeamManager.CurrentTeamInfo.AvatarInfo.Count <= (Owner.IsInMultiplayer ? GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam : GameServer.Configuration.Server.GameOptions.AvatarLimits.SinglePlayerTeam))
            {
                addToTeam = true;
                await Owner.TeamManager.AddToTeamAsync(avatar);
                if (Owner.World != null)
                {
                    await Owner.TeamManager.UpdateTeamEntitiesAsync();
                }
            }

            return true; ;
        }
    }
}
