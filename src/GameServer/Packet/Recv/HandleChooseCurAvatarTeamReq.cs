using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.ChooseCurAvatarTeamReq)]
    internal class HandleChooseCurAvatarTeamReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            ChooseCurAvatarTeamReq p = ChooseCurAvatarTeamReq.Parser.ParseFrom(payload);

            await session.Player.TeamManager.SetCurrentTeam(p.TeamId);

            await session.Player.SendPacketAsync(new PacketChooseCurAvatarTeamRsp(p.TeamId));
        }
    }
}
