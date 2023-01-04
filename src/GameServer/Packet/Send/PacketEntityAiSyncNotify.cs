using Google.Protobuf;
using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Packet.Send
{
    internal class PacketEntityAiSyncNotify : BasePacket
    {
        public PacketEntityAiSyncNotify(EntityAiSyncNotify notify) : base(Enums.OpCode.EntityAiSyncNotify)
        {
            EntityAiSyncNotify entityAiSyncNotify = new EntityAiSyncNotify();
            
            foreach (var monsterId in notify.LocalAvatarAlertedMonsterList.ToArray())
            {
                AiSyncInfo aiSyncInfo = new AiSyncInfo();
                aiSyncInfo.EntityId = monsterId;

                // Missing has_path_to_target to true

                entityAiSyncNotify.InfoList.Add(aiSyncInfo);
            }

            Data = entityAiSyncNotify.ToByteArray();
        }
    }
}
