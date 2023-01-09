using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class InventoryManager
    {
        [BsonId] public uint OwnerId; // GameUid
        [BsonIgnore] private Player.Player Owner;
        [BsonElement] public Dictionary<ItemType, SubInventory> SubInventories { get; private set; }

        [BsonIgnore] public Dictionary<ulong, GameItem> GuidMap = new();
        public InventoryManager(Player.Player owner)
        {
            OwnerId = owner.GameUid;
            Owner = owner;
            SubInventories = new()
            {
                { ItemType.ITEM_WEAPON, new WeaponTab(Owner, this)}, //Weapon tab includes MATERIAL_WEAPON_EXP_STONE
                { ItemType.ITEM_RELIQUARY, new RelicTab(Owner, this) }, //Relic tab includes MATERIAL_RELIQUARY_MATERIAL
                { ItemType.ITEM_MATERIAL, new MaterialSubInv(Owner, this) },
                { ItemType.ITEM_FURNITURE, new FurnitureTab(Owner, this) } // Furniture tab includes MATERIAL_FURNITURE_FORMULA, MATERIAL_FURNITURE_SUITE_FORMULA, MATERIAL_ACTIVITY_ROBOT
            };
        }

        public int GetVirtualItemValue(uint itemId)
        {
            switch (itemId)
            {
                case 106: // Resin
                    return Owner.PlayerProperties[PlayerProperty.PROP_PLAYER_RESIN];
                case 107:  // Legendary Key
                    return Owner.PlayerProperties[PlayerProperty.PROP_PLAYER_LEGENDARY_KEY];
                case 114: // Iron Coin
                    //TODO
                    return 0;
                case 145: // Ancient Iron Coin
                    //TODO
                    return 0;
                case 201: // Primogem
                    return Owner.PlayerProperties[PlayerProperty.PROP_PLAYER_HCOIN];
                case 202: // Mora
                    return Owner.PlayerProperties[PlayerProperty.PROP_PLAYER_SCOIN];
                case 203: // Genesis Crystals
                    return Owner.PlayerProperties[PlayerProperty.PROP_PLAYER_MCOIN];
                case 204: // Home Coin
                    return Owner.PlayerProperties[PlayerProperty.PROP_PLAYER_HOME_COIN];
                default:
                    Logger.WriteErrorLine($"Unknown Virtual Item: {itemId}");
                    return 0;
            }
        }

        // returns updated weapon
        public Task<WeaponItem> PromoteWeaponAsync(ulong targetWeaponGuid) => (SubInventories[ItemType.ITEM_WEAPON] as WeaponTab).PromoteWeaponAsync(targetWeaponGuid);

        //returns updated weapon
        public Task<WeaponItem> UpgradeWeaponAsync(ulong targetWeaponGuid, IEnumerable<ulong> foodWeaponGuidList, IEnumerable<ItemParam> itemParamList) =>
            (SubInventories[ItemType.ITEM_WEAPON] as WeaponTab).UpgradeWeaponAsync(targetWeaponGuid, foodWeaponGuidList, itemParamList);

        public async Task<bool> RemoveItemByParamData(ItemParamData itemData)
        {
            bool result = false;
            switch (GameData.ItemDataMap[itemData.id].itemType)
            {
                case ItemType.ITEM_RELIQUARY:
                    if ((SubInventories[ItemType.ITEM_RELIQUARY] as RelicTab).Items.TryGetValue(itemData.id, out GameItem? relicItem))
                    {
                        result = await (SubInventories[ItemType.ITEM_RELIQUARY] as RelicTab).RemoveItemAsync(relicItem, itemData.count);
                    }
                    break;
                case ItemType.ITEM_WEAPON:
                    if ((SubInventories[ItemType.ITEM_WEAPON] as WeaponTab).Items.TryGetValue(itemData.id, out GameItem? weaponItem))
                    {
                        result = await (SubInventories[ItemType.ITEM_WEAPON] as WeaponTab).RemoveItemAsync(weaponItem, itemData.count);
                    }
                    break;
                case ItemType.ITEM_FURNITURE:
                    if ((SubInventories[ItemType.ITEM_FURNITURE] as FurnitureTab).Items.TryGetValue(itemData.id, out GameItem? furnitureItem))
                    {
                        result = await (SubInventories[ItemType.ITEM_FURNITURE] as FurnitureTab).RemoveItemAsync(furnitureItem, itemData.count);
                    }
                    break;
                case ItemType.ITEM_MATERIAL:
                    if ((SubInventories[ItemType.ITEM_MATERIAL] as MaterialSubInv).TryGetItemInSubInvById(itemData.id, out GameItem? materialItem))
                    {
                        result = await (SubInventories[ItemType.ITEM_MATERIAL] as MaterialSubInv).RemoveItemAsync(materialItem, itemData.count);
                    }
                    break;
                case ItemType.ITEM_VIRTUAL:
                    result = await PayVirtualItemByParamDataAsync(itemData);
                    break;
                default:
                    Logger.WriteErrorLine("Invalid item type!");
                    break;
            }
            return result;
        }
        // Used by reward lists
        public Task<GameItem?> AddItemByParamDataAsync(ItemParamData itemParam, ActionReason reason) =>
            AddItemByIdAsync(itemParam.id, itemParam.count, reason);
        
        public Task<List<GameItem>?> AddItemByParamDataManyAsync(IEnumerable<ItemParamData> items, ActionReason reason) =>
            AddItemByIdManyAsync(items.Select(x => Tuple.Create(x.id, x.count)).ToList());

        public Task<GameItem?> AddItemByGuidAsync(ulong guid, int count = 1, ActionReason reason = ActionReason.None) =>
            AddItemByIdAsync(GuidMap[guid].ItemId, count, reason);

        public async Task<List<GameItem>?> AddItemByIdManyAsync(IEnumerable<Tuple<uint, int>> idAndCount, ActionReason reason = ActionReason.None)
        {
            List<GameItem> updatedItems = new();

            foreach (Tuple<uint, int> item in idAndCount)
            {
                //Add but don't notify the player yet
                GameItem? gameItem = await AddItemByIdAsync(item.Item1, item.Item2, ActionReason.None, false);
                if (gameItem != null) updatedItems.Add(gameItem);

            }

            if (updatedItems.Count == 0)
            {
                return null;
            }

            if (reason != ActionReason.None)
            {
                await Owner.SendPacketAsync(new PacketItemAddHintNotify(updatedItems, reason));
            }

            await Owner.SendPacketAsync(new PacketStoreItemChangeNotify(updatedItems));

            return updatedItems;
        }
        public async Task<GameItem?> AddItemByIdAsync(uint itemId, int count = 1, ActionReason reason = ActionReason.None, bool notifyClient = true, uint level = 1, uint refinement = 0)
        {
            ItemData itemData = GameData.ItemDataMap[itemId];

            if (itemData == null)
            {
                return null;
            }

            GameItem? updatedItem = null;

            switch (itemData.itemType)
            {
                case ItemType.ITEM_NONE:
                    Logger.WriteErrorLine($"Unknown item: {itemId}");
                    return null;
                case ItemType.ITEM_VIRTUAL:
                    //Update  avatar/player properties, and update database
                    await AddVirtualItemByIdAsync(itemId, count);
                    return null;
                case ItemType.ITEM_MATERIAL:
                    // Add to inventory and update database
                    updatedItem = await SubInventories[ItemType.ITEM_MATERIAL].AddItemAsync(itemId, count);
                    break;
                case ItemType.ITEM_RELIQUARY:
                    // Add to inventory and update database
                    updatedItem = await SubInventories[ItemType.ITEM_RELIQUARY].AddItemAsync(itemId, count, level);
                    break;
                case ItemType.ITEM_WEAPON:
                    // Add to inventory and update database
                    updatedItem = await SubInventories[ItemType.ITEM_WEAPON].AddItemAsync(itemId, count, level, refinement);
                    break;
                case ItemType.ITEM_DISPLAY:
                    Logger.WriteErrorLine($"Unhandled item: {itemId}");
                    return null;
                case ItemType.ITEM_FURNITURE:
                    // Add to inventory and update database
                    updatedItem = await SubInventories[ItemType.ITEM_FURNITURE].AddItemAsync(itemId, count);
                    break;
                default: // Should be unreachable
                    return null;
            }
            if (updatedItem != null)
            {
                // Add a reference by Guid
                GuidMap[updatedItem.Guid] = updatedItem;

                if (notifyClient)
                {
                    if (reason != ActionReason.None)
                    {
                        await Owner.SendPacketAsync(new PacketItemAddHintNotify(updatedItem, reason));
                    }

                    await Owner.SendPacketAsync(new PacketStoreItemChangeNotify(updatedItem));
                }
            }
            return updatedItem;
        }

        public async Task<bool> PayPromoteCostAsync(IEnumerable<ItemParamData> costItems, ActionReason reason = ActionReason.None)
        {
            Dictionary<MaterialItem, int> materials = new();
            Dictionary<uint, int> virtualItems = new();
                foreach (ItemParamData itemData in costItems)
                {
                    if (GameData.ItemDataMap[itemData.id].itemType == ItemType.ITEM_MATERIAL)
                    {
                        if (!(SubInventories[ItemType.ITEM_MATERIAL] as MaterialSubInv).PromoteTab.Items.TryGetValue(itemData.id, out GameItem? material))
                            return false;
                        if (material.Count < itemData.count) return false; // insufficient materials
                        else materials.Add(material as MaterialItem, itemData.count);
                    }
                    else if (GameData.ItemDataMap[itemData.id].itemType == ItemType.ITEM_VIRTUAL)
                    {
                        if (GetVirtualItemValue(itemData.id) < itemData.count) return false; // insufficient currency
                        else virtualItems.Add(itemData.id, itemData.count);
                    }
                }
            // We have the requisite amount for all items
            foreach (MaterialItem material in materials.Keys) await RemoveItemByGuidAsync(material.Guid, materials[material]);
            foreach (uint item in virtualItems.Keys) await PayVirtualItemByIdAsync(item, virtualItems[item]);
            return true;
        }
        private async Task<bool> AddVirtualItemByIdAsync(uint itemId, int count)
        {
            switch (itemId)
            {
                case 102: // Adventure exp
                    return await Owner.ExpManager.AddAdventureExp(count);
                case 105: // Companionship exp
                    return await Owner.ExpManager.AddCompanionshipExp(count);
                case 106: // Resin
                    return await Owner.ResinManager.AddResinAsync(count);
                case 107:  // Legendary Key
                    return await Owner.PropManager.AddLegendaryKeyAsync(count);
                case 114: // Iron Coin
                    //TODO
                    return false;
                case 145: // Ancient Iron Coin
                    //TODO
                    return false;
                case 201: // Primogem
                    return await Owner.PropManager.AddPrimogemsAsync(count);
                case 202: // Mora
                    return await Owner.PropManager.AddMoraAsync(count);
                case 203: // Genesis Crystals
                    return await Owner.PropManager.AddGenesisCrystalsAsync(count);
                case 204: // Home Coin
                    return await Owner.PropManager.AddHomeCoinAsync(count);
                default:
                    Logger.WriteErrorLine($"Unknown Virtual Item: {itemId}");
                    return false;
            }
        }
        public async Task<bool> PayVirtualItemByIdAsync(uint itemId, int count, ActionReason reason = ActionReason.None)
        {
            switch (itemId)
            {
                case 114: // Iron Coin
                    //TODO
                    return false;
                case 145: // Ancient Iron Coin
                    //TODO
                    return false;
                case 201:  // Primogem
                    return await Owner.PropManager.UsePrimogemsAsync(count);
                case 202:  // Mora
                    return await Owner.PropManager.PayMoraAsync(count);
                case 203:  // Genesis Crystals
                    return await Owner.PropManager.UseGenesisCrystalsAsync(count);
                case 106:  // Resin
                    return await Owner.ResinManager.UseResinAsync(count);
                case 107:  // LegendaryKey
                    return await Owner.PropManager.UseLegendaryKeyAsync(count);
                case 204:  // Home Coin
                    return await Owner.PropManager.PayHomeCoinAsync(count);
                default:
                    Logger.WriteErrorLine($"Unknown Virtual Item: {itemId}");
                    return false;
            }
        }
        public Task<bool> PayVirtualItemByParamDataAsync(ItemParamData costItem) => PayVirtualItemByIdAsync(costItem.id, costItem.count);
        public async Task<bool> PayVirtualItemByParamDataManyAsync(IEnumerable<ItemParamData> costItems, int quantity = 1, ActionReason reason = ActionReason.None)
        {
            // Make sure player has requisite items
            foreach (ItemParamData cost in costItems)
                if (GetVirtualItemValue(cost.id) < (cost.count * quantity))
                    return false;
            // All costs are satisfied, now remove them all
            foreach (ItemParamData cost in costItems)
            {
                await PayVirtualItemByIdAsync(cost.id, cost.count * quantity);
            }

            return true;
        }

        public async Task<bool> RemoveItemByGuidAsync(ulong guid, int count = 1)
        {
            if (!GuidMap.ContainsKey(guid)) //TryGetValue(guid, out GameItem? item) appears to occasionally return false despite a key being present
            {
                return false;
            }
            GameItem item = GuidMap[guid];
            // Was the operation successful?
            bool result = false;

            switch (item.ItemData.itemType)
            {
                case ItemType.ITEM_RELIQUARY:
                    result = await SubInventories[ItemType.ITEM_RELIQUARY].RemoveItemAsync(item, count);
                    break;
                case ItemType.ITEM_WEAPON:
                    result = await SubInventories[ItemType.ITEM_WEAPON].RemoveItemAsync(item, count);
                    break;
                case ItemType.ITEM_FURNITURE:
                    result = await SubInventories[ItemType.ITEM_FURNITURE].RemoveItemAsync(item, count);
                    break;
                case ItemType.ITEM_MATERIAL:
                    result = await SubInventories[ItemType.ITEM_MATERIAL].RemoveItemAsync(item, count);
                    break;
            }

            // Returns true on success
            return result;
        }

        public Task<bool> EquipRelic(ulong avatarGuid, ulong equipGuid) => (SubInventories[ItemType.ITEM_WEAPON] as RelicTab).EquipRelic(avatarGuid, equipGuid);
        public Task<bool> UnequipRelicAsync(ulong avatarGuid, EquipType slot) => (SubInventories[ItemType.ITEM_WEAPON] as RelicTab).UnequipRelicAsync(avatarGuid, slot);
        public Task<bool> EquipWeaponAsync(ulong avatarGuid, ulong equipGuid) => (SubInventories[ItemType.ITEM_WEAPON] as WeaponTab).EquipWeaponAsync(avatarGuid, equipGuid);

        public Task<bool> UnequipWeaponAsync(ulong avatarGuid) => (SubInventories[ItemType.ITEM_WEAPON] as WeaponTab).UnequipWeaponAsync(avatarGuid);

        public async Task OnLoadAsync(Player.Player owner)
        {
            Owner = owner;
            GuidMap = new();
            foreach (SubInventory sub in SubInventories.Values)
            {
                await sub.OnLoadAsync(owner, this);
            }
        }
    }
}
