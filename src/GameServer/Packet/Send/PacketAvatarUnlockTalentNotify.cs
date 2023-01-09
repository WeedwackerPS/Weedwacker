using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketAvatarUnlockTalentNotify : BasePacket
    {
        public PacketAvatarUnlockTalentNotify(Avatar avatar, uint depotId, uint talentId) : base(OpCode.AvatarUnlockTalentNotify)
        {

            AvatarUnlockTalentNotify proto = new AvatarUnlockTalentNotify()
            {
                AvatarGuid = avatar.Guid,
                EntityId = avatar.EntityId,
                TalentId = talentId,
                SkillDepotId = depotId
            };

            Data = proto.ToByteArray();
        }
    }
}
