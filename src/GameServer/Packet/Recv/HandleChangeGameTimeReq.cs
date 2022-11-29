using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.ChangeGameTimeReq)]
    internal class HandleChangeGameTimeReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            ChangeGameTimeReq req = ChangeGameTimeReq.Parser.ParseFrom(payload);
            session.Player.Scene.ChangeTime((int)req.GameTime);
            session.SendPacketAsync(new PacketChangeGameTimeRsp(session.Player));
        }
    }
}
