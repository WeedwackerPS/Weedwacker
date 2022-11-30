using System.Reflection;
using MongoDB.Bson.Serialization.Attributes;
using Weedwacker.GameServer.Data;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Data.Excel;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Inventory.ItemUseOp;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Systems.Inventory
{
    internal class MaterialSubInv : SubInventory
    {
        //MATERIAL_FOOD,MATERIAL_NOTICE_ADD_HP,MATERIAL_SPICE_FOOD
        [BsonElement] public FoodTab FoodTab { get; private set; }

        //MATERIAL_EXP_FRUIT,MATERIAL_AVATAR_MATERIAL,MATERIAL_TALENT
        [BsonElement] public PromoteTab PromoteTab { get; private set; }

        //MATERIAL_EXCHANGE,MATERIAL_WOOD,MATERIAL_HOME_SEED,MATERIAL_FISH_BAIT
        [BsonElement] public MaterialsTab MaterialsTab { get; private set; }

        //MATERIAL_WIDGET,MATERIAL_FISH_ROD
        [BsonElement] public GadgetTab GadgetTab { get; private set; }

        //MATERIAL_QUEST,MATERIAL_CRICKET,MATERIAL_ACTIVITY_GEAR
        [BsonElement] public QuestTab QuestTab { get; private set; }

        //MATERIAL_SEA_LAMP,MATERIAL_CONSUME_BATCH_USE,MATERIAL_CONSUME,MATERIAL_ELEM_CRYSTAL,MATERIAL_CHEST_BATCH_USE,MATERIAL_BGM
        [BsonElement] public PreciousTab PreciousTab { get; private set; }

        //MATERIAL_SELECTABLE_CHEST
        [BsonElement] public BattlePassTab BattlePassTab { get; private set; }

        //MATERIAL_NAMECARD
        [BsonElement] public HashSet<int> NameCardList { get; private set; } = new();
        //MATERIAL_COSTUME
        [BsonElement] public HashSet<int> CostumeList { get; private set; } = new();
        //MATERIAL_FLYCLOAK
        [BsonElement] public HashSet<int> FlyCloakList { get; private set; } = new() { 140001 };

        public MaterialSubInv(Player.Player owner, InventoryManager inventory) : base(owner, inventory)
        {
            FoodTab = new(owner, inventory);
            PromoteTab = new(owner, inventory);
            MaterialsTab = new(owner, inventory);
            GadgetTab = new(owner, inventory);
            QuestTab = new(owner, inventory);
            PreciousTab = new(owner, inventory);
            BattlePassTab = new(owner, inventory);
        }

        public override async Task OnLoadAsync(Player.Player owner, InventoryManager inventory)
        {
            Owner = owner;
            Inventory = inventory;

            await Task.WhenAll(new Task[]
                {
                    FoodTab.OnLoadAsync(owner, inventory),
                    PromoteTab.OnLoadAsync(owner, inventory),
                    MaterialsTab.OnLoadAsync(owner, inventory),
                    GadgetTab.OnLoadAsync(owner, inventory),
                    QuestTab.OnLoadAsync(owner, inventory),
                    PreciousTab.OnLoadAsync(owner, inventory),
                    BattlePassTab.OnLoadAsync(owner, inventory)
                });
        }
        public async Task<bool> AddFlycloakAsync(int flycloakId)
        {
            if (FlyCloakList.Add(flycloakId))
            {
                await Owner.SendPacketAsync(new PacketAvatarGainFlycloakNotify(flycloakId));
                return true;
            }
            else
            {
                Logger.DebugWriteLine("Player " + Owner.GameUid + " already owns Flycloak " + flycloakId);
                return false;
            }
        }

        public async Task<bool> AddCostumeAsync(int costumeId)
        {
            if (CostumeList.Add(costumeId))
            {
                await Owner.SendPacketAsync(new PacketAvatarGainCostumeNotify(costumeId));
                return true;
            }
            else
            {
                Logger.DebugWriteLine("Player " + Owner.GameUid + " already owns costume " + costumeId);
                return false;
            }
        }

        public async Task<bool> UseCondensedResin(int amount)
        {
            // Don't deduct if resin disabled.
            if (!GameServer.Configuration.Server.GameOptions.ResinOptions.ResinUsage) return true;
            /*WRONG
            return await Owner.Inventory.PayVirtualItemAsync(220007, amount);
            */
            return false;
        }
        public override async Task<GameItem?> AddItemAsync(int itemId, int count = 1, int level = 1, int refinement = 0)
        {
            MaterialData data = (MaterialData)GameData.ItemDataMap[itemId];
            List<BaseItemUse> ops = new();

            // Find the Handler for this opcode
            foreach (ItemUseData op in data.itemUse)
            {
                if (op.useOp != Enums.ItemUseOp.ITEM_USE_NONE)
                {
                    var query =
                        from type in Assembly.GetExecutingAssembly().GetTypes()
                        where type.GetCustomAttribute<ItemUseAttribute>()?.Op == op.useOp
                        select type;
                    var opType = query.FirstOrDefault();
                    if (opType != null) ops.Add((BaseItemUse)Activator.CreateInstance(opType, Owner, itemId));
                }
            }

            switch (data.materialType)
            {
                //Energy and Dungeon Timers
                case MaterialType.MATERIAL_ADSORBATE:
                case MaterialType.MATERIAL_AVATAR:
                case MaterialType.MATERIAL_FLYCLOAK:
                case MaterialType.MATERIAL_COSTUME:
                case MaterialType.MATERIAL_NAMECARD:
                case MaterialType.MATERIAL_CHEST:
                case MaterialType.MATERIAL_CHANNELLER_SLAB_BUFF:
                    if (data.useOnGain)
                    {
                        foreach (BaseItemUse op in ops)
                        {
                            await op.Use();
                        }
                    }
                    return null;
                case MaterialType.MATERIAL_WEAPON_EXP_STONE:
                    return await Inventory.SubInventories[ItemType.ITEM_WEAPON].AddItemAsync(itemId);

                case MaterialType.MATERIAL_RELIQUARY_MATERIAL:
                    return await Inventory.SubInventories[ItemType.ITEM_RELIQUARY].AddItemAsync(itemId);

                case MaterialType.MATERIAL_FURNITURE_FORMULA:
                case MaterialType.MATERIAL_FURNITURE_SUITE_FORMULA:
                case MaterialType.MATERIAL_ACTIVITY_ROBOT:
                    return await Inventory.SubInventories[ItemType.ITEM_FURNITURE].AddItemAsync(itemId);

                case MaterialType.MATERIAL_FOOD:
                case MaterialType.MATERIAL_NOTICE_ADD_HP:
                case MaterialType.MATERIAL_SPICE_FOOD:
                    return await FoodTab.AddItemAsync(itemId);

                case MaterialType.MATERIAL_EXP_FRUIT:
                case MaterialType.MATERIAL_AVATAR_MATERIAL:
                case MaterialType.MATERIAL_TALENT:
                    return await PromoteTab.AddItemAsync(itemId);

                case MaterialType.MATERIAL_EXCHANGE:
                case MaterialType.MATERIAL_WOOD:
                case MaterialType.MATERIAL_HOME_SEED:
                case MaterialType.MATERIAL_FISH_BAIT:
                    return await MaterialsTab.AddItemAsync(itemId);

                case MaterialType.MATERIAL_WIDGET:
                case MaterialType.MATERIAL_FISH_ROD:
                    return await GadgetTab.AddItemAsync(itemId);


                case MaterialType.MATERIAL_QUEST:
                case MaterialType.MATERIAL_CRICKET:
                case MaterialType.MATERIAL_ACTIVITY_GEAR:
                    return await QuestTab.AddItemAsync(itemId);
                default:
                    //TODO MATERIAL_ARANARA,MATERIAL_SUMO_BUFF,MATERIAL_ACTIVITY_JIGSAW,MATERIAL_DESHRET_MANUAL
                    Logger.WriteErrorLine("Unknown material: " + itemId);
                    return null;
            }
        }

        internal override async Task<bool> RemoveItemAsync(GameItem item, int count = 1)
        {
            MaterialData data = (MaterialData)GameData.ItemDataMap[item.ItemId];

            switch (data.materialType)
            {
                case MaterialType.MATERIAL_WEAPON_EXP_STONE:
                    return await Inventory.SubInventories[ItemType.ITEM_WEAPON].RemoveItemAsync(item);

                case MaterialType.MATERIAL_RELIQUARY_MATERIAL:
                    return await Inventory.SubInventories[ItemType.ITEM_RELIQUARY].RemoveItemAsync(item);

                case MaterialType.MATERIAL_FURNITURE_FORMULA:
                case MaterialType.MATERIAL_FURNITURE_SUITE_FORMULA:
                case MaterialType.MATERIAL_ACTIVITY_ROBOT:
                    return await Inventory.SubInventories[ItemType.ITEM_FURNITURE].RemoveItemAsync(item, count);

                case MaterialType.MATERIAL_FOOD:
                case MaterialType.MATERIAL_NOTICE_ADD_HP:
                case MaterialType.MATERIAL_SPICE_FOOD:
                    return await FoodTab.RemoveItemAsync(item, count);

                case MaterialType.MATERIAL_EXP_FRUIT:
                case MaterialType.MATERIAL_AVATAR_MATERIAL:
                case MaterialType.MATERIAL_TALENT:
                    return await PromoteTab.RemoveItemAsync(item, count);

                case MaterialType.MATERIAL_EXCHANGE:
                case MaterialType.MATERIAL_WOOD:
                case MaterialType.MATERIAL_HOME_SEED:
                case MaterialType.MATERIAL_FISH_BAIT:
                    return await MaterialsTab.RemoveItemAsync(item, count);

                case MaterialType.MATERIAL_WIDGET:
                case MaterialType.MATERIAL_FISH_ROD:
                    return await GadgetTab.RemoveItemAsync(item, count);


                case MaterialType.MATERIAL_QUEST:
                case MaterialType.MATERIAL_CRICKET:
                case MaterialType.MATERIAL_ACTIVITY_GEAR:
                    return await QuestTab.RemoveItemAsync(item, count);
                default:
                    Logger.WriteErrorLine("Invalid material");
                    return false;
            }
        }
    }
}
