using System;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class GatherGadgetEntity : ScriptGadgetEntity
    {
        private uint ItemId;
        private bool IsForbidGuest;
        protected GatherGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            SceneEntityInfo info = base.ToProto();
            GatherGadgetInfo gatherInfo = new()
            {
                ItemId = ItemId,
                IsForbidGuest = IsForbidGuest
            };
            info.Gadget.GatherGadget = gatherInfo;
            return info;
        }
    }
}
