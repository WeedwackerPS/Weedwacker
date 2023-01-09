using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data
{
    [Resource("AvatarCurveExcelConfigData.json")]
    public class AvatarCurveData
    {
        [JsonProperty] public readonly uint level;
        [JsonProperty] public readonly CurveInfo[] curveInfos;

        internal Tuple<ArithType, float> GetArith(GrowCurveType type)
        {
            foreach (CurveInfo curveInfo in curveInfos)
            {
                if (curveInfo.type == type) return Tuple.Create(curveInfo.arith, curveInfo.value);
            }
            Logger.WriteErrorLine("Could not find value for " + type + " for avatar level:" + level);
            return Tuple.Create(ArithType.ARITH_MULTI, (float)1.0);
        }
    }
}