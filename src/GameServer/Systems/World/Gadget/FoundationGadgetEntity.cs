using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class FoundationGadgetEntity : ScriptGadgetEntity
    {
        protected FoundationGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            FoundationInfo foundation = new()
            {
                //CurrentBuildingId =,
                //Status =,
                //LockedByUid =,
            };
            //foundation.UidList.AddRange();

            info.Gadget.FoundationInfo = foundation;

            return info;
        }
    }
}