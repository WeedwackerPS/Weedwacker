using Weedwacker.GameServer.Enums;
using Weedwacker.GameServer.Packet.Send;

namespace Weedwacker.GameServer.Packet.Recv
{
    [OpCode((ushort)OpCode.SceneInitFinishReq)]
    internal class HandleSceneInitFinishReq : BaseHandler
    {
        public override async Task HandleAsync(Connection session, byte[] header, byte[] payload)
        {
            // Info packets
            await Task.WhenAll(new Task[]
            {
                session.SendPacketAsync(new PacketServerTimeNotify()),
                session.Player.World.BroadcastPacketAsync(new PacketWorldPlayerInfoNotify(session.Player.World)),
                session.SendPacketAsync(new PacketWorldDataNotify(session.Player.World)),
                session.SendPacketAsync(new PacketPlayerWorldSceneInfoListNotify(session.Player.Scene)),
                session.SendPacketAsync(new PacketSceneForceUnlockNotify()),
                session.SendPacketAsync(new PacketTeamResonanceChangeNotify(session.Player.TeamManager.CurrentTeamInfo)),
                session.SendPacketAsync(new BasePacket(OpCode.SceneDataNotify)),
                session.SendPacketAsync(new PacketHostPlayerNotify(session.Player.World)),
                session.SendPacketAsync(new PacketSceneTimeNotify(session.Player)),
                session.SendPacketAsync(new PacketPlayerGameTimeNotify(session.Player)),
                session.Player.Scene.BroadcastPacketAsync(new PacketPlayerEnterSceneInfoNotify(session.Player)),
                session.Player.Scene.UpdateActiveAreaWeathersAsync(session.Player.WorldAreaIds),

                session.SendPacketAsync(new PacketScenePlayerInfoNotify(session.Player.World)),
                session.Player.Scene.BroadcastPacketAsync(new PacketSceneTeamUpdateNotify(session.Player)),
                session.Player.Scene.BroadcastPacketAsync(new PacketSyncTeamEntityNotify(session.Player)),
                session.Player.Scene.BroadcastPacketAsync(new PacketSyncScenePlayTeamEntityNotify(session.Player)),

            });

            // Done Packet
            await session.SendPacketAsync(new PacketSceneInitFinishRsp(session.Player));

            // Set state
            session.Player.SceneLoadState = SceneLoadState.INIT;
        }
    }
}
