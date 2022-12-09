using Weedwacker.GameServer.Systems.Avatar;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketTeamResonanceChangeNotify : BasePacket
    {
        public PacketTeamResonanceChangeNotify(TeamInfo teamInfo) : base(Enums.OpCode.TeamResonanceChangeNotify)
        {
            TeamResonanceChangeNotify p = new();
            foreach (var avatar in teamInfo.AvatarInfo.Values)
            {
                if (avatar == null) continue;
                //TODO
                AvatarTeamResonanceInfo info = new()
                {
                    AvatarGuid = avatar.Guid
                };
                //info.AddTeamResonanceIdList.AddRange(teamInfo.TeamResonances.Select(w => (uint)w.teamResonanceId));
                info.Unk3300LPAKGGBBDNJ.AddRange(teamInfo.TeamResonances.Select(w => (uint)w.teamResonanceId));
                p.InfoList.Add(info);
            }
        }
    }
}
