using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class VehicleEntity : ScriptGadgetEntity
    {
        protected VehicleEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            VehicleInfo vehicle = new()
            {
                //CurStamina =,
                //OwnerUid =,
            };
            //vehicle.MemberList.AddRange();

            info.Gadget.VehicleInfo = vehicle;

            return info;
        }
    }
}