using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class CoinCollectOperatorEntity : ScriptGadgetEntity
    {
        protected CoinCollectOperatorEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            CoinCollectOperatorInfo operatorInfo = new()
            {
                //LevelId =
            };

            info.Gadget.CoinCollectOperatorInfo = operatorInfo;

            return info;
        }
    }
}