using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarSkillInfoNotify : BasePacket
    {
        public PacketAvatarSkillInfoNotify(ulong avatarGuid, IDictionary<uint, uint> skillExtraChargeMap) : base(Enums.OpCode.AvatarSkillInfoNotify)
        {
            var proto = new AvatarSkillInfoNotify()
            {
                Guid = avatarGuid
            };

            skillExtraChargeMap.AsParallel().ForAll(w => proto.SkillMap.Add(w.Key, new AvatarSkillInfo() { MaxChargeCount = w.Value }));

            Data = proto.ToByteArray();
        }
    }
}
