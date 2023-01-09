using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarGainFlycloakNotify : BasePacket
    {
        public PacketAvatarGainFlycloakNotify(uint flycloak) : base(Enums.OpCode.AvatarGainFlycloakNotify)
        {
            AvatarGainFlycloakNotify proto = new AvatarGainFlycloakNotify() { FlycloakId = flycloak };

            Data = proto.ToByteArray();
        }
    }
}
