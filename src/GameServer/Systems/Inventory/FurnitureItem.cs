using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.Inventory
{
    //TODO
    internal class FurnitureItem : GameItem
    {
        public FurnitureItem(ulong guid, uint itemId, int count) : base(guid, itemId, count)
        {
        }

        public override Item ToProto()
        {
            throw new NotImplementedException();
        }
    }
}
