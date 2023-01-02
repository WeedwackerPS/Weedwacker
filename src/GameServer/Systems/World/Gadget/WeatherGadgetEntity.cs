using Weedwacker.Shared.Network.Proto;

namespace Weedwacker.GameServer.Systems.World
{
    internal class WeatherGadgetEntity : ScriptGadgetEntity
    {
        private uint WeatherAreaId;

        protected WeatherGadgetEntity(Scene? scene, uint blockId, uint groupId, uint configId) : base(scene, blockId, groupId, configId)
        {
        }

        public override SceneEntityInfo ToProto()
        {
            var info = base.ToProto();
            WeatherInfo weather = new()
            {
                WeatherAreaId = WeatherAreaId
            };
            info.Gadget.Weather = weather;

            return info;
        }
    }
}
