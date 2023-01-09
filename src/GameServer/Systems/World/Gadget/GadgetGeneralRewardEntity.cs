using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class GeneralRewardEntity : ScriptGadgetEntity
    {
        protected GeneralRewardEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            GadgetGeneralRewardInfo rewardInfo = new()
            {
                //DeadTime = default,
                //ItemParam = default,
                //Resin = default,
            };
            //rewardInfo.QualifyUidList.AddRange();
            //rewardInfo.RemainUidList.AddRange();

            info.Gadget.GeneralReward = rewardInfo;

            return info;
        }
    }
}
