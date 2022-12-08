using System.Numerics;
using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPersonalSceneJumpRsp : BasePacket
    {
        public PacketPersonalSceneJumpRsp(uint sceneId, Shared.Network.Proto.Vector pos) : base(Enums.OpCode.PersonalSceneJumpRsp)
        {
            PersonalSceneJumpRsp proto = new PersonalSceneJumpRsp()
            {
                DestPos = pos,
                DestSceneId = sceneId
            };

            Data = proto.ToByteArray();
        }

        public PacketPersonalSceneJumpRsp(Retcode ret,uint sceneId, Vector3 pos) : base(Enums.OpCode.PersonalSceneJumpRsp)
        {
            PersonalSceneJumpRsp proto = new PersonalSceneJumpRsp()
            {
                DestPos = new Shared.Network.Proto.Vector { X = pos.X, Y = pos.Y, Z = pos.Z },
                DestSceneId = sceneId,
                Retcode = (int)ret
            };

            Data = proto.ToByteArray();
        }
    }
}
