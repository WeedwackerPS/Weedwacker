using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class NightCrowGadgetEntity : ScriptGadgetEntity
    {
        protected NightCrowGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            NightCrowGadgetInfo nightCrow = new();
            //nightCrow.ArgumentList.AddRange();

            info.Gadget.NightCrowGadgetInfo = nightCrow;

            return info;
        }
    }
}