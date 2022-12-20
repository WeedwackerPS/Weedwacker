using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Numerics;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.BinOut.Scene.Point;
using Weedwacker.GameServer.Database;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using static System.Collections.Specialized.BitVector32;

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
            //await Owner.Inventory.AddItemByIdAynsc(201, 5, ActionReason.UnlockPointReward);
            //await Owner.Inventory.AddItemByIdAsync(102, isStatue ? 50 : 10, ActionReason.UnlockPointReward);
            await Owner.SendPacketAsync(new PacketScenePointUnlockNotify((uint)sceneId, (uint)pointId));
            return true;
        }
        public async Task<bool> UnlockTransPoint(List<int> sceneId, Dictionary<int, HashSet<uint>> pointIds)
        {
            foreach (int a in sceneId)
            {
                if (!UnlockedScenePoints.ContainsKey(a))
                {
                    
                    if (pointIds[a] != null)
                    {
                        UnlockedScenePoints.Add(a, new HashSet<int>());
                        foreach (int i in pointIds[a])
                        {
                            UnlockedScenePoints[a].Add(i);
                            List<uint> list = new List<uint>();
                            list.AddRange(pointIds[a]);
                            await Owner.SendPacketAsync(new PacketScenePointUnlockNotify(a, list));
                            list.Clear();
                        }
                    }
                    
                }
                                   
            }
            var filter = Builders<ProgressManager>.Filter.Where(p => p.OwnerId == Owner.GameUid);
            var update = Builders<ProgressManager>.Update.Set(w => w.UnlockedScenePoints, UnlockedScenePoints);
            await DatabaseManager.UpdateProgressAsync(filter, update);
            return true;
        }
        public async Task<bool> UnlockedSceneArea(int sceneId, int areaId)
        {
            if (!UnlockedSceneAreas.ContainsKey(sceneId))
                UnlockedSceneAreas.Add(sceneId, new HashSet<int>());

            UnlockedSceneAreas[sceneId].Add(areaId);
            var filter = Builders<ProgressManager>.Filter.Where(p => p.OwnerId == Owner.GameUid);
            var update = Builders<ProgressManager>.Update.Set(w => w.UnlockedSceneAreas, UnlockedSceneAreas);
            await DatabaseManager.UpdateProgressAsync(filter, update);
            await Owner.SendPacketAsync(new PacketSceneAreaUnlockNotify(sceneId,areaId));
            return true;
        }

        public async Task<bool> UnlockedSceneArea(List<int> sceneId, List<uint> areaIds)
        {
            foreach(int a in sceneId)
            {
                if (!UnlockedSceneAreas.ContainsKey(a))
                    UnlockedSceneAreas.Add(a, new HashSet<int>());
                foreach (uint i in areaIds)
                {
                    UnlockedSceneAreas[a].Add((int)i);
                }
                
                await Owner.SendPacketAsync(new PacketSceneAreaUnlockNotify(a, areaIds));
            }
            
            var filter = Builders<ProgressManager>.Filter.Where(p => p.OwnerId == Owner.GameUid);
            var update = Builders<ProgressManager>.Update.Set(w => w.UnlockedSceneAreas, UnlockedSceneAreas);
            await DatabaseManager.UpdateProgressAsync(filter, update);
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
