using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class DeshretObeliskGadgetEntity : ScriptGadgetEntity
    {
        protected DeshretObeliskGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            DeshretObeliskGadgetInfo deshretObelisk = new();
            //deshretObelisk.ArgumentList.AddRange();

            info.Gadget.DeshretObeliskGadgetInfo = deshretObelisk;

            return info;
        }
    }
}