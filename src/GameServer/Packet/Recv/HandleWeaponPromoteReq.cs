using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{

    [OpCode((ushort)OpCode.WeaponPromoteReq)]
    internal class HandleWeaponPromoteReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            WeaponPromoteReq req = WeaponPromoteReq.Parser.ParseFrom(payload);
            await session.Player.Inventory.promoteWeaponAsync(req.TargetWeaponGuid);
        }
    }
}

