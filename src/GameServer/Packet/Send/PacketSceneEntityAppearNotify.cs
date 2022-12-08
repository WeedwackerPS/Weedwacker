using Google.Protobuf;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneEntityAppearNotify : BasePacket
    {
        public PacketSceneEntityAppearNotify(SceneEntity entity, VisionType visionType = VisionType.Born, uint param = 0) : base(Enums.OpCode.SceneEntityAppearNotify, true)
        {
            SceneEntityAppearNotify proto = new SceneEntityAppearNotify()
            {
                AppearType = visionType,
                Param = param
            };
            proto.EntityList.Add(entity.ToProto());
            Data = proto.ToByteArray();
        }

        public PacketSceneEntityAppearNotify(IEnumerable<SceneEntity> entities, VisionType visionType = VisionType.Born, uint param = 0) : base(Enums.OpCode.SceneEntityAppearNotify, true)
        {
            SceneEntityAppearNotify proto = new SceneEntityAppearNotify()
            {
                AppearType = visionType,
                Param = param
            };
            proto.EntityList.AddRange(entities.Select(w => w.ToProto()));

            Data = proto.ToByteArray();
        }
    }
}
