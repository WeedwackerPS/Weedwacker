using Google.Protobuf;
using Vim.Math3d;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPersonalSceneJumpRsp : BasePacket
    {
        public PacketPersonalSceneJumpRsp(uint sceneId, Vector pos) : base(Enums.OpCode.PersonalSceneJumpRsp)
        {
            PersonalSceneJumpRsp proto = new PersonalSceneJumpRsp()
            {
                DestPos = pos,
                DestSceneId = sceneId
            };

            Data = proto.ToByteArray();
        }

        public PacketPersonalSceneJumpRsp(uint sceneId, Vector3 pos) : base(Enums.OpCode.PersonalSceneJumpRsp)
        {
            Vector protoVector = new Vector()
            {
                X = pos.X,
                Y = pos.Y,
                Z = pos.Z
            };

            PersonalSceneJumpRsp proto = new PersonalSceneJumpRsp()
            {
                DestPos = protoVector,
                DestSceneId = sceneId
            };

            Data = proto.ToByteArray();
        }
    }
}
