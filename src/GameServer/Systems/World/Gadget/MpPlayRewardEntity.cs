using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class MpPlayRewardEntity : ScriptGadgetEntity // wtf is this supposed to be?
    {
        protected MpPlayRewardEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            MpPlayRewardInfo rewardInfo = new()
            {
                //Resin = default
            };
            //rewardInfo.QualifyUidList.AddRange();
            //rewardInfo.RemainUidList.AddRange();

            info.Gadget.MpPlayReward = rewardInfo;

            return info;
        }
    }
}