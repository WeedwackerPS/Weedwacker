using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.GameServer.Systems.Inventory;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{

    [OpCode((ushort)OpCode.WeaponPromoteReq)]
    internal class HandleWeaponPromoteReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            WeaponPromoteReq req = WeaponPromoteReq.Parser.ParseFrom(payload);
            int oldPromote = (session.Player.Inventory.GuidMap[req.TargetWeaponGuid] as WeaponItem).PromoteLevel;
            WeaponItem weapon = await session.Player.Inventory.PromoteWeaponAsync(req.TargetWeaponGuid);
            await session.Player.SendPacketAsync(new PacketWeaponPromoteRsp(weapon, oldPromote));
        }
    }
}

