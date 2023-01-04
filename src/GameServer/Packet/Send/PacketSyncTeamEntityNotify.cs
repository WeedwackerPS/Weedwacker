using Google.Protobuf;
using Weedwacker.GameServer.Systems.Player;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSyncTeamEntityNotify : BasePacket
    {
        public PacketSyncTeamEntityNotify(Player player) : base(Enums.OpCode.SyncTeamEntityNotify)
        {
            SyncTeamEntityNotify proto = new SyncTeamEntityNotify()
            {
                SceneId = (uint)player.SceneId
            };

            if (player.IsInMultiplayer)
            {
                player.World.Players.Except(new Player[] { player }).AsParallel().ForAll(p =>
                {
                    TeamEntityInfo info = new TeamEntityInfo()
                    {
                        TeamEntityId = p.TeamManager.EntityId,
                        AuthorityPeerId = player.PeerId,
                        TeamAbilityInfo = new() //TODO { }
                    };

                    proto.TeamEntityInfoList.Add(info);
                });
            }

            Data = proto.ToByteArray();
        }
    }
}
