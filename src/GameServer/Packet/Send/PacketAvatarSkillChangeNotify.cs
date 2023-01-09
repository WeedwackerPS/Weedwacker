using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarSkillChangeNotify : BasePacket
    {
        public PacketAvatarSkillChangeNotify(Avatar avatar, uint depotId, uint skillId, uint oldLevel, uint curLevel) : base(OpCode.AvatarSkillChangeNotify)
        {
            AvatarSkillChangeNotify proto = new AvatarSkillChangeNotify()
            {
                AvatarGuid = avatar.Guid,
                EntityId = avatar.EntityId,
                SkillDepotId = depotId,
                AvatarSkillId = skillId,
                OldLevel = oldLevel,
                CurLevel = curLevel
            };

            Data = proto.ToByteArray();
        }
    }
}
