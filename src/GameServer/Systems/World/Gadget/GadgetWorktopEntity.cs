using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class GadgetWorktopEntity : ScriptGadgetEntity
    {
        public HashSet<uint> WorktopOptions;
        private bool IsGuestCanOperate = false;

        public GadgetWorktopEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            SceneEntityInfo info = base.ToProto();
            WorktopInfo worktop = new()
            {
                IsGuestCanOperate = IsGuestCanOperate,
            };
            worktop.OptionList.AddRange(WorktopOptions);
            info.Gadget.Worktop = worktop;
            return info;
        }
    }
}
