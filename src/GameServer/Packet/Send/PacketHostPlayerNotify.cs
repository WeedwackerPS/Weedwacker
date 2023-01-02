using Google.Protobuf;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketHostPlayerNotify : BasePacket
    {
        public PacketHostPlayerNotify(World world) : base(Enums.OpCode.HostPlayerNotify)
        {
            HostPlayerNotify p = new()
            {
                HostUid = (uint)world.Host.GameUid,
                HostPeerId = world.HostPeerId
            };

            Data = p.ToByteArray();
        }
    }
}
