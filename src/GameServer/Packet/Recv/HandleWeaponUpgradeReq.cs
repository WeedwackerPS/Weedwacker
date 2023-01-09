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

    [OpCode((ushort)OpCode.WeaponUpgradeReq)]
    internal class HandleWeaponUpgradeReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            WeaponUpgradeReq req = WeaponUpgradeReq.Parser.ParseFrom(payload);
            List<ItemParam> leftoverOres = new(); //TODO
            uint oldLevel = (session.Player.Inventory.GuidMap[req.TargetWeaponGuid] as WeaponItem).Level;
            WeaponItem weapon = await session.Player.Inventory.UpgradeWeaponAsync(req.TargetWeaponGuid, req.FoodWeaponGuidList.ToList(), req.ItemParamList.ToList());
            await session.Player.SendPacketAsync(new PacketWeaponUpgradeRsp(weapon, oldLevel, leftoverOres));
        }
    }
}

