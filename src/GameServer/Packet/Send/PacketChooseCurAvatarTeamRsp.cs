using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketChooseCurAvatarTeamRsp : BasePacket
    {
        public PacketChooseCurAvatarTeamRsp(uint teamId) : base(OpCode.ChooseCurAvatarTeamRsp)
        {
            ChooseCurAvatarTeamRsp r = new ChooseCurAvatarTeamRsp()
            {
                CurTeamId = teamId
            };
            Data = r.ToByteArray();
        }
    }
}
