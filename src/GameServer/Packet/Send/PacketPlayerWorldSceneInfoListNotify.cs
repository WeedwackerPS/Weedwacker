using Google.Protobuf;
using Weedwacker.GameServer.Systems.World;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketPlayerWorldSceneInfoListNotify : BasePacket
    {
        public PacketPlayerWorldSceneInfoListNotify(Scene scene) : base(Enums.OpCode.PlayerWorldSceneInfoListNotify)
        {
            PlayerWorldSceneInfoListNotify p = new();

            PlayerWorldSceneInfo sceneInfo = new()
            {
                SceneId = (uint)scene.SceneId,
                IsLocked = false, //TODO
            };
            sceneInfo.SceneTagIdList.AddRange(scene.SceneTags);

            p.InfoList.Add(sceneInfo);

            Data = p.ToByteArray();
        }
    }
}
