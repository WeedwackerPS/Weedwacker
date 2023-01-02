using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class StatueGadgetEntity : ScriptGadgetEntity
    {
        private HashSet<uint> OpenedStatueUids;
        protected StatueGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            StatueGadgetInfo statue = new();
            statue.OpenedStatueUidList.AddRange(OpenedStatueUids);
            info.Gadget.StatueGadget = statue;

            return info;
        }
    }
}
