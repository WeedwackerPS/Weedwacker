using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class InventoryManager
    {
        [BsonId] public int OwnerId; // GameUid
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

        private int GetVirtualItemValue(int itemId)
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

        // Used by reward lists
        public async Task<GameItem?> AddItemByParamDataAsync(ItemParamData itemParam, ActionReason reason)
        {
            return await AddItemByIdAsync(itemParam.id, itemParam.count, reason);
        }
        public async Task<List<GameItem>?> AddItemByParamDataManyAsync(IEnumerable<ItemParamData> items, ActionReason reason)
        {
            return await AddItemByIdManyAsync(items.Select(x => Tuple.Create(x.id, x.count)).ToList());
        }

        public async Task<GameItem?> AddItemByGuidAsync(ulong guid, int count = 1, ActionReason reason = ActionReason.None)
        {
            return await AddItemByIdAsync(GuidMap[guid].ItemId, count, reason);
        }

        public async Task<List<GameItem>?> AddItemByIdManyAsync(IEnumerable<Tuple<int, int>> idAndCount, ActionReason reason = ActionReason.None)
        {
            List<GameItem> updatedItems = new();

            foreach (Tuple<int, int> item in idAndCount)
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
        public async Task<GameItem?> AddItemByIdAsync(int itemId, int count = 1, ActionReason reason = ActionReason.None, bool notifyClient = true, int level = 1, int refinement = 0)
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
            Dictionary<int, int> virtualItems = new();
            foreach (ItemParamData itemData in costItems)
            {
                if (GameData.ItemDataMap[itemData.id].itemType == ItemType.ITEM_MATERIAL)
                {
                    var material = (SubInventories[ItemType.ITEM_MATERIAL] as MaterialSubInv).PromoteTab.Items[itemData.id];
                    if (material.Count < itemData.count) return false; // insufficient materials
                    else materials.Add((material as MaterialItem), itemData.count);
                }
                else if (GameData.ItemDataMap[itemData.id].itemType == ItemType.ITEM_VIRTUAL)
                {
                    if (GetVirtualItemValue(itemData.id) < itemData.count) return false; // insufficient currency
                    else virtualItems.Add(itemData.id, GetVirtualItemValue(itemData.id));
                }
            }
            // We have the requisite amount for all items
            foreach (MaterialItem material in materials.Keys) await RemoveItemByGuid(material.Guid, materials[material]);
            foreach (int item in virtualItems.Keys) await PayVirtualItemByIdAsync(item, virtualItems[item]);
            return true;
        }
        private async Task<bool> AddVirtualItemByIdAsync(int itemId, int count)
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
        private async Task<bool> PayVirtualItemByIdAsync(int itemId, int count, ActionReason reason = ActionReason.None)
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
        public async Task<bool> PayVirtualItemByParamDataAsync(ItemParamData costItem)
        {
            return await PayVirtualItemByIdAsync(costItem.id, costItem.count);
        }
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

        public async Task<bool> RemoveItemByGuid(ulong guid, int count = 1)
        {
            if (GuidMap.TryGetValue(guid, out GameItem? item))
            {
                return false;
            }

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

            if (item.Count <= 0)
            {
                await Owner.SendPacketAsync(new PacketStoreItemDelNotify(item));
            }
            else
            {
                await Owner.SendPacketAsync(new PacketStoreItemChangeNotify(item));
            }

            // Returns true on success
            return result;
        }

        public async Task<bool> EquipRelic(ulong avatarGuid, ulong equipGuid)
        {
            Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(avatarGuid);

            if (avatar != null && GuidMap.TryGetValue(equipGuid, out GameItem relic) && relic.ItemData.itemType == ItemType.ITEM_RELIQUARY)
            {
                ReliquaryItem asRelic = (ReliquaryItem)relic;
                // Is it equipped ot another avatar?
                Avatar.Avatar? otherAvatar = Owner.Avatars.Avatars.Values.Where(a => a.GetRelic(asRelic.ItemData.equipType) == asRelic && a != avatar).FirstOrDefault();
                if (otherAvatar != null)
                {
                    await UnequipRelicAsync(otherAvatar.Guid, asRelic.ItemData.equipType);
                }

                if (await avatar.EquipRelic(asRelic, true))
                {
                    asRelic.EquippedAvatar = avatar.AvatarId;
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> EquipWeapon(ulong avatarGuid, ulong equipGuid)
        {
            Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(avatarGuid);

            if (avatar != null && GuidMap.TryGetValue(equipGuid, out GameItem weapon) && weapon.ItemData.itemType == ItemType.ITEM_WEAPON)
            {
                // Is it equipped at another avatar?
                Avatar.Avatar? otherAvatar = Owner.Avatars.Avatars.Values.Where(a => a.GetWeapon() == weapon && a != avatar).FirstOrDefault();
                if (otherAvatar != null)
                {
                    await UnequipWeaponAsync(otherAvatar.Guid);
                }
                WeaponItem asWeapon = (WeaponItem)weapon;
                if (avatar.Data.GeneralData.weaponType == asWeapon.ItemData.weaponType)
                {
                    if (await avatar.EquipWeapon(asWeapon, true))
                        asWeapon.EquippedAvatar = avatar.AvatarId;
                    return true;
                }
            }

            return false;
        }

        public async Task<bool> UnequipRelicAsync(ulong avatarGuid, EquipType slot)
        {
            Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(avatarGuid);

            if (avatar != null && slot != EquipType.EQUIP_WEAPON)
            {

                return await avatar.UnequipRelic(slot);

            }

            return false;
        }
        public async Task<bool> UnequipWeaponAsync(ulong avatarGuid)
        {
            Avatar.Avatar? avatar = Owner.Avatars.GetAvatarByGuid(avatarGuid);

            if (avatar != null)
            {

                return await avatar.UnequipWeapon();

            }

            return false;
        }

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
