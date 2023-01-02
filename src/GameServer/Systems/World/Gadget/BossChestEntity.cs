using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class BossChestEntity : ScriptGadgetEntity
    {
        protected BossChestEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            BossChestInfo bossChest = new()
            {
                //MonsterConfigId = default,
                //Resin = default,
            };
            //bossChest.QualifyUidList.AddRange();
            //bossChest.RemainUidList.AddRange();
            //bossChest.UidDiscountMap.Add();

            info.Gadget.BossChest = bossChest;

            return info;
        }
    }
}
