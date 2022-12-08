using System.Numerics;

namespace Weedwacker.GameServer.Systems.World
{
    internal abstract class ScriptEntity : SceneEntity
    {
        protected Vector3 _Position;
        protected Vector3 _Rotation;
        public override Vector3 Position { get => _Position; protected set => _Position = value; }
        public override Vector3 Rotation { get => _Rotation; protected set => _Rotation = value; }

        public readonly uint BlockId;
        public readonly uint GroupId;
        public uint ConfigId { get; protected set; }

        public ScriptEntity(Scene? scene) : base(scene)
        {
            // USE ONLY FOR CLIENT GADGETS. WHO NEEDS MULTIPLE INHERITANCE ANYWAY?!
        }

        protected ScriptEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene)
        {
            BlockId = blockId;
            GroupId = groupId;
            ConfigId = configId;
        }
    }
}
