using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketEnterScenePeerNotify : BasePacket
    {
        public PacketEnterScenePeerNotify(Player player) : base(Enums.OpCode.EnterScenePeerNotify)
        {
            EnterScenePeerNotify proto = new EnterScenePeerNotify()
            {
                DestSceneId = (uint)player.SceneId,
                PeerId = player.PeerId,
                HostPeerId = player.World.HostPeerId,
                EnterSceneToken = player.EnterSceneToken
            };

            Data = proto.ToByteArray();
        }
    }
}
