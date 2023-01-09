using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class OfferingGadgetEntity : ScriptGadgetEntity
    {
        protected OfferingGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            OfferingInfo offeringInfo = new()
            {
                //OfferingId = default
            };
            info.Gadget.OfferingInfo = offeringInfo;

            return info;
        }
    }
}