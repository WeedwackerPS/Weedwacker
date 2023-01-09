using System.Numerics;
using Weedwacker.Shared.Network.Proto;


namespace Weedwacker.GameServer.Systems.Player
{
    internal class MapMarksManager
    {
        private readonly Player Owner;

        public MapMarksManager(Player owner){Owner = owner; }

        public async Task Teleport(MarkMapReq markMap)
        {
            float y;
            try
            {
                y = Convert.ToInt64(markMap.Mark.Name);
            }
            catch (Exception e)
            {
                y = 350;
            }
            Vector3 pos = new Vector3(markMap.Mark.Pos.X,y, markMap.Mark.Pos.Z);
            await Owner.World.TransferPlayerToSceneAsync(Owner, Enums.EnterReason.TransPoint, markMap.Mark.SceneId == (uint)Owner.SceneId ? EnterType.Goto : EnterType.Jump, markMap.Mark.SceneId, pos, useDefaultBornPosition: false);
        }
    }
}
