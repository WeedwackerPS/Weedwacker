using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketDelTeamEntityNotify : BasePacket
    {
        public PacketDelTeamEntityNotify(uint sceneId, uint teamEntityId) : base(Enums.OpCode.DelTeamEntityNotify)
        {
            DelTeamEntityNotify proto = new DelTeamEntityNotify()
            {
                SceneId = sceneId,
            };
            proto.DelEntityIdList.Add(teamEntityId);

            Data = proto.ToByteArray();
        }
    }
}
