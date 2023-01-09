using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class CustomGadgetTreeEntity : ScriptGadgetEntity
    {
        protected CustomGadgetTreeEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();

            CustomGadgetTreeInfo treeInfo = new();
            //treeInfo.NodeList.AddRange();

            info.Gadget.CustomGadgetTreeInfo = treeInfo;

            return info;
        }
    }
}