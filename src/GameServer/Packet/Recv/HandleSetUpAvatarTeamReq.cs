using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.SetUpAvatarTeamReq)]
    internal class HandleSetUpAvatarTeamReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            SetUpAvatarTeamReq req = SetUpAvatarTeamReq.Parser.ParseFrom(payload);

            await session.Player.TeamManager.SetupAvatarTeamAsync((int)req.TeamId, req.AvatarTeamGuidList);
            await session.Player.SendPacketAsync(new PacketSetUpAvatarTeamRsp(session.Player, req.TeamId, req.AvatarTeamGuidList));
        }
    }
}
