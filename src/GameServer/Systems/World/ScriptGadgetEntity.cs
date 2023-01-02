using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Script;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class ScriptGadgetEntity : BaseGadgetEntity
    {
        public GadgetState State { get; private set; }
        public ScriptGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public async void SetGadgetState(int state)
        {
            State = (GadgetState)state;
            //await Scene.BroadcastPacketAsync(new PacketGadgetStateNotify(this, state));
            await Scene.ScriptManager.CallEvent(EventType.EVENT_GADGET_STATE_CHANGE, new ScriptArgs(state, (int)ConfigId));
        }
    }
}
