using Google.Protobuf;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSetUpAvatarTeamRsp : BasePacket
    {
        public PacketSetUpAvatarTeamRsp(Player player, int teamId, HashSet<Avatar> avatars) : base(Enums.OpCode.SetUpAvatarTeamRsp, true)
        {
            SetUpAvatarTeamRsp p = new SetUpAvatarTeamRsp()
            {
                TeamId = (uint)teamId,
                CurAvatarGuid = player.TeamManager.GetCurrentCharacterGuid(),
            };
            foreach(var avatar in avatars)
            {
                p.AvatarTeamGuidList.Add(avatar.Guid);
            }
            Data = p.ToByteArray();
        }
    }
}