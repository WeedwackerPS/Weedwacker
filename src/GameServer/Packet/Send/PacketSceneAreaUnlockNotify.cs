using Google.Protobuf;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketSceneAreaUnlockNotify : BasePacket
    {
        public PacketSceneAreaUnlockNotify(int sceneId, List<uint> areaIds) : base(Enums.OpCode.SceneAreaUnlockNotify)
        {
            
            SceneAreaUnlockNotify p = new()
            {
                SceneId = (uint)sceneId,
                
            };
            p.AreaList.AddRange(areaIds);
            Data = p.ToByteArray();
        }

        public PacketSceneAreaUnlockNotify(int sceneId, int areaId) : base(Enums.OpCode.SceneAreaUnlockNotify)
        {

            SceneAreaUnlockNotify p = new()
            {
                SceneId = (uint)sceneId,

            };
            p.AreaList.Add((uint)areaId);
            Data = p.ToByteArray();
        }


    }
}

