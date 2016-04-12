using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darwin.Core
{
    internal static class RandomTool
    {
        private static Random rd = new Random();

        internal static int GetRandomNum() {
            return rd.Next();
        }

        /// <summary>
        /// 正态分布随机数
        /// </summary>
        /// <param name="u">均数</param>
        /// <param name="d">方差</param>
        /// <returns></returns>
        internal static double GetNDRandomNum(double u, double d) {
            double u1, u2, z, x;
            if (d <= 0) return u;

            u1 = rd.NextDouble();
            u2 = rd.NextDouble();
            z = Math.Sqrt(-2 * Math.Log(u1)) * Math.Sin(2 * Math.PI * u2);
            x = u + d * z;
            return x;
        }
    }
}
