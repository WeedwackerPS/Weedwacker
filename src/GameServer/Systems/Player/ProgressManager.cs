using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Systems.Player
{
    internal class ProgressManager
    {

        [BsonElement("_id")]
        [BsonId] public int OwnerId { get; private set; }
        private Player Owner;
        public Dictionary<OpenStateType, int> OpenStates = new(); // SET ONLY THROUGH THE OPENSTATEMANAGER
        public HashSet<int> UnlockedForgingBlueprints = new();
        public HashSet<int> UnlockedCombines = new();
        //public Dictionary<long, ExpeditionInfo> ExpeditionInfo;
        public Dictionary<int, int> UnlockedRecipies = new();
        //public List<ActiveForgeData> activeForges;
        [BsonElement] public Dictionary<int, int> QuestGlobalVariables = new();
        [BsonSerializer(typeof(IntDictionarySerializer<HashSet<int>>))]
        public Dictionary<int, HashSet<int>> UnlockedSceneAreas = new();
        [BsonSerializer(typeof(IntDictionarySerializer<HashSet<int>>))]
        public Dictionary<int, HashSet<int>> UnlockedScenePoints = new();

        public ProgressManager(Player owner)
        {
            Owner = owner;
            OwnerId = owner.GameUid;
        }
        public async Task<bool> UnlockTransPoint(int sceneId, int pointId)
        {
            if (!UnlockedScenePoints.ContainsKey(sceneId))
                UnlockedScenePoints.Add(sceneId, new HashSet<int>());

            UnlockedScenePoints[sceneId].Add(pointId);
            var filter = Builders<ProgressManager>.Filter.Where(p => p.OwnerId == Owner.GameUid);
            var update = Builders<ProgressManager>.Update.Set(w => w.UnlockedScenePoints, UnlockedScenePoints);
            await DatabaseManager.UpdateProgressAsync(filter, update);
            //await Owner.Inventory.AddItemByIdAsync(201, 5, ActionReason.UnlockPointReward);
            // await Owner.Inventory.AddItemByIdAsync(102, isStatue ? 50 : 10, ActionReason.UnlockPointReward);
            await Owner.SendPacketAsync(new PacketScenePointUnlockNotify((uint)sceneId, (uint)pointId));
            return true;
        }
        public async Task OnPlayerCreate()
        {
            await Owner.OpenStateManager.OnPlayerCreate();
        }

        public async Task OnLoadAsync(Player owner)
        {
            Owner = owner;
        }

    }
}
