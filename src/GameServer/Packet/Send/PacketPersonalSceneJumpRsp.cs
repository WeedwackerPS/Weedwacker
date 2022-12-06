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

        public PacketPersonalSceneJumpRsp(Retcode ret,uint sceneId, Vector3 pos) : base(Enums.OpCode.PersonalSceneJumpRsp)
        {
            PersonalSceneJumpRsp proto = new PersonalSceneJumpRsp()
            {
                DestPos = new Vector { X = pos.X, Y = pos.Y, Z = pos.Z },
                DestSceneId = sceneId,
                Retcode = (int)ret
            };

            Data = proto.ToByteArray();
        }
    }
}
