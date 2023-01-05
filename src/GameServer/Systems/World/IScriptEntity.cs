using System.Numerics;

namespace Weedwacker.GameServer.Systems.World
{
    internal interface IScriptEntity
    {
        public uint BlockId { get; protected set; }
        public uint GroupId { get; protected set; }
        public uint ConfigId { get; protected set; }
    }
}
