using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class FishPoolEntity : ScriptGadgetEntity
    {
        protected FishPoolEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            FishPoolInfo poolInfo = new()
            {
                //PoolId =,
                //TodayFishNum =,
            };
            //poolInfo.FishAreaList.AddRange();

            info.Gadget.FishPoolInfo = poolInfo;

            return info;
        }
    }
}