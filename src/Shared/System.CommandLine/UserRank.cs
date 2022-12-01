using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.CommandLine
{
    public enum UserRank : byte
    {
        NULL = 0x0,
        Player = 0x1,
        Mod = 0x2,
        GM = 0x3,
        Dev = 0x4,
        Console = 0x5
    }


    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class RequiredRankAttribute : Attribute
    {
        public UserRank userRank;
        public RequiredRankAttribute(UserRank rank)
        {
            this.userRank = rank;
        }
    }
}
