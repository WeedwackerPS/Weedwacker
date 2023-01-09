using Google.Protobuf;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketWorldDataNotify : BasePacket
    {
        public PacketWorldDataNotify(World world) : base(Enums.OpCode.WorldDataNotify)
        {
            uint worldLevel = world.WorldLevel;
            int isMp = world.IsMultiplayer ? 1 : 0;

            WorldDataNotify proto = new WorldDataNotify();
            proto.WorldPropMap.Add(1, new PropValue() { Type = 1, Ival = worldLevel, Val = worldLevel });
            proto.WorldPropMap.Add(2, new PropValue() { Type = 2, Ival = isMp, Val = isMp });

            Data = proto.ToByteArray();
        }
    }
}
