using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketCalcWeaponUpgradeReturnItemsRsp : BasePacket
    {
        public PacketCalcWeaponUpgradeReturnItemsRsp(ulong guid, IEnumerable<ItemParam> returnItems) : base(OpCode.CalcWeaponUpgradeReturnItemsRsp)
        {
            CalcWeaponUpgradeReturnItemsRsp proto = new()
            {
                TargetWeaponGuid = guid
            };
            proto.ItemParamList.Add(returnItems);

            Data = proto.ToByteArray();
        }
    }
}
