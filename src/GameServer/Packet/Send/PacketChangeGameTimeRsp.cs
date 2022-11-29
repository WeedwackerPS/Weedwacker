using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketChangeGameTimeRsp : BasePacket
    {
        public PacketChangeGameTimeRsp(Player player) : base(Enums.OpCode.ChangeGameTimeRsp)
        {
            ChangeGameTimeRsp p = new ChangeGameTimeRsp()
            {
                Retcode = (int)Retcode.RetSucc,
                CurGameTime = player.Scene.Time,
            };

            Data = p.ToByteArray();
        }
    }
}
