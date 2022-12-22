using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{

    [OpCode((ushort)OpCode.WeaponUpgradeReq)]
    internal class HandleWeaponUpgradeReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            WeaponUpgradeReq req = WeaponUpgradeReq.Parser.ParseFrom(payload);
            await session.Player.Inventory.upgradeWeaponAsync(req.TargetWeaponGuid, req.FoodWeaponGuidList.ToList(), req.ItemParamList.ToList());
        }
    }
}

