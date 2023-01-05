using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Script;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class ScriptGadgetEntity : BaseGadgetEntity, IScriptEntity
    {
        public GadgetState State { get; protected set; }
        public uint BlockId { get; set; }
        public uint GroupId { get; set; }
        public uint ConfigId { get; set; }

        public ScriptGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene)
        {
            BlockId = blockId;
            GroupId = groupId;
            ConfigId = configId;
        }

        public async void SetGadgetState(int state)
        {
            State = (GadgetState)state;
            //await Scene.BroadcastPacketAsync(new PacketGadgetStateNotify(this, state));
            await Scene.ScriptManager.CallEvent(EventType.EVENT_GADGET_STATE_CHANGE, new ScriptArgs(state, (int)ConfigId));
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            info.Gadget.ConfigId = ConfigId;
            info.Gadget.GroupId = GroupId;

            return info;
        }
    }
}
