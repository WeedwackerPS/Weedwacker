using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Common;
using Weedwacker.GameServer.Enums;
using Weedwacker.Shared.Utils;

namespace Weedwacker.GameServer.Data.Excel
{
    [Resource("MonsterCurveExcelConfigData.json")]
    internal class MonsterCurveData
    {
        [JsonProperty] public readonly uint level;
        [JsonProperty] public readonly CurveInfo[] curveInfos;

        public Tuple<ArithType, float> GetArith(GrowCurveType type)
        {
            foreach (CurveInfo curveInfo in curveInfos)
            {
                if (curveInfo.type == type) return Tuple.Create(curveInfo.arith, curveInfo.value);
            }
            Logger.WriteErrorLine("Could not find value for " + type + " for avatar level:" + level);
            return Tuple.Create(ArithType.ARITH_MULTI, (float)1.0);
        }

        public static float CalcValue(float value, Tuple<ArithType, float> curve)
        {
            switch (curve.Item1)
            {
                case ArithType.ARITH_MULTI:
                    return value * curve.Item2;
                case ArithType.ARITH_ADD:
                    return value + curve.Item2;
                default:
                    Logger.WriteErrorLine("Unknown Monster curve operation");
                    goto case ArithType.ARITH_MULTI;
            }
        }
    }
}
