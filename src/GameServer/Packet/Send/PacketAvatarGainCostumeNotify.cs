using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarGainCostumeNotify : BasePacket
    {
        public PacketAvatarGainCostumeNotify(uint costumeId) : base(Enums.OpCode.AvatarGainCostumeNotify)
        {
            AvatarGainCostumeNotify proto = new AvatarGainCostumeNotify() { CostumeId = costumeId };

            Data = proto.ToByteArray();
        }
    }
}
