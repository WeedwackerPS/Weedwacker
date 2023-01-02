using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class BlossomChestEntity : ScriptGadgetEntity
    {
        protected BlossomChestEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            BlossomChestInfo blossom = new()
            {
                //BlossomRefreshType = default,
                //DeadTime = default,
                //RefreshId = default,
                //Resin = default,
            };
            //blossom.QualifyUidList.AddRange();
            //blossom.RemainUidList.AddRange();

            info.Gadget.BlossomChest = blossom;

            return info;
        }
    }
}
