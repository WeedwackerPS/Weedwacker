using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    [OpCode((ushort)OpCode.SetUpAvatarTeamRsp)]
    internal class PacketSetUpAvatarTeamRsp : BasePacket
    {
        public PacketSetUpAvatarTeamRsp(Player player, uint teamId, IList<ulong> guidList) : base(OpCode.SetUpAvatarTeamRsp)
        {
            SetUpAvatarTeamRsp p = new SetUpAvatarTeamRsp()
            {
                TeamId = teamId,
                CurAvatarGuid = player.TeamManager.GetCurrentCharacterGuid(),
            };
            foreach (var g in guidList)
            {
                p.AvatarTeamGuidList.Add(g);
            }
            

            Data = p.ToByteArray();

        }

        public PacketSetUpAvatarTeamRsp(Player player, uint teamId, TeamInfo team) : base(OpCode.SetUpAvatarTeamRsp)
        {
            SetUpAvatarTeamRsp p = new SetUpAvatarTeamRsp()
            {
                TeamId = teamId,
                CurAvatarGuid = player.TeamManager.GetCurrentCharacterGuid(),
            };
            foreach (var a in team.AvatarInfo.Values)
            {
                p.AvatarTeamGuidList.Add(a.Guid);
            }


            Data = p.ToByteArray();

        }
    }
}
