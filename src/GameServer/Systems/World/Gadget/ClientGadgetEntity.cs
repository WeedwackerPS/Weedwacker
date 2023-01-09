using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class ClientGadgetEntity : BaseGadgetEntity
    {
        public readonly Player.Player Owner;

        public readonly uint CampId;
        public readonly uint CampType;
        public readonly uint OwnerEntityId;
        public readonly uint TargetEntityId;
        public readonly bool AsyncLoad;
        public readonly uint ConfigId;
        public readonly uint OriginalOwnerEntityId;

        public ClientGadgetEntity(Scene scene, Player.Player player, EvtCreateGadgetNotify notify) : base(scene)
        {
            Owner = player;
            EntityId = notify.EntityId;
            Position = new(notify.InitPos.X, notify.InitPos.Y, notify.InitPos.Z);
            Rotation = new(notify.InitEulerAngles.X, notify.InitEulerAngles.Y, notify.InitEulerAngles.Z);
            ConfigId = notify.ConfigId;
            CampId = notify.CampId;
            CampType = notify.CampType;
            OwnerEntityId = notify.PropOwnerEntityId;
            TargetEntityId = notify.TargetEntityId;
            //AsyncLoad = notify.IsAsyncLoad;

            SceneEntity owner = scene.GetEntityById(OwnerEntityId) as SceneEntity;
            if (owner is ClientGadgetEntity ownerGadget)
            {
                OriginalOwnerEntityId = ownerGadget.OriginalOwnerEntityId;
            }
            else
            {
                OriginalOwnerEntityId = OwnerEntityId;
            }
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            ClientGadgetInfo clientGadget = new ClientGadgetInfo()
            {
                CampId = (uint)CampId,
                CampType = (uint)CampType,
                OwnerEntityId = OwnerEntityId,
                TargetEntityId = TargetEntityId,
                AsyncLoad = AsyncLoad
            };
            info.Gadget.OwnerEntityId = OwnerEntityId;
            info.Gadget.ClientGadget = clientGadget;
            info.Gadget.PropOwnerEntityId = OwnerEntityId;

            return info;
        }
    }
}
