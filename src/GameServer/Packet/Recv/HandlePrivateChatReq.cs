using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;
using Weedwacker.Shared.Commands;
using Weedwacker.Shared.Enums;
using Weedwacker.Shared.Network.Proto;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.PrivateChatReq)]
    internal class HandlePrivateChatReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            PrivateChatReq req = PrivateChatReq.Parser.ParseFrom(payload);

            // Create chat packet.
            var notify = new PacketPrivateChatNotify((uint)session.Player.GameUid, req.TargetUid, req.Text);
            // Send and put in history.
            await session.SendPacketAsync(notify);

            //handle commands
            if (req.TargetUid == (uint)GameServer.Configuration.Server.GameOptions.Constants.SERVER_CONSOLE_UID)
            {
                if (req.Text[0] == '/')
                {
                    try
                    {
                        string cmd = ConsoleHandler.ParseCommandString(req.Text.Substring(1), out string[] args);
                        var output = await ConsoleHandler.ExecuteCommand(cmd, UserRank.Player, args);
                        await session.SendPacketAsync(new PacketPrivateChatNotify(req.TargetUid, (uint)session.Player.GameUid, output));
                    }
                    catch (Exception e)
                    {
                        Logger.WriteErrorLine(e.ToString());
                    }
                }
                await session.SendPacketAsync(new PacketPrivateChatRsp());
            }
        }
    }
}
