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
    [OpCode((ushort)OpCode.CalcWeaponUpgradeReturnItemsReq)]
    internal class HandleCalcWeaponUpgradeReturnItemsReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            CalcWeaponUpgradeReturnItemsReq req = CalcWeaponUpgradeReturnItemsReq.Parser.ParseFrom(payload);
            List<ItemParam> returnOres = new(); //TODO
            await session.SendPacketAsync(new PacketCalcWeaponUpgradeReturnItemsRsp(req.TargetWeaponGuid, returnOres));
        }
    }
}

