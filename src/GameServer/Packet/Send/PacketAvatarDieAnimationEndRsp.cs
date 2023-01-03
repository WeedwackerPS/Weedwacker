using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarDieAnimationEndRsp: BasePacket
    {
        public PacketAvatarDieAnimationEndRsp(ulong dieGuid, uint skillId) : base(Enums.OpCode.AvatarDieAnimationEndRsp)
        {
            AvatarDieAnimationEndRsp proto = new AvatarDieAnimationEndRsp()
            {
                DieGuid = dieGuid,
                SkillId = skillId,
            };

            Data = proto.ToByteArray();
        }
    }
}
