// <copyright file="RandomToolTest.cs">Copyright ©  2016</copyright>
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Darwin.Core;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Darwin.Core.Tests
{
    /// <summary>此类包含 RandomTool 的参数化单元测试</summary>
    [PexClass(typeof(RandomTool))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class RandomToolTest
    {
        /// <summary>测试 GetNDRandomNum(Double, Double) 的存根</summary>
        [PexMethod]
        internal void GetNDRandomNumTest()
        {
            List<double> list = new List<double>();

            int c0 = 0, c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0;

            int i = 0;
            while (i++ < 10000)
            {
                double d = RandomTool.GetNDRandomNum(0, 1);

                list.Add(d);
            }

            list.Sort();

            double min = list[0];
            double max = list[list.Count - 1];

            double r = (max - min) / 10;

            Trace.WriteLine("min:" + min);
            Trace.WriteLine("max:" + max);
            Trace.WriteLine("r:" + r);

            list.ForEach(p =>
            {
                if (p < min + r) c0++;
                else if (p < min + 2 * r) c1++;
                else if (p < min + 3 * r) c2++;
                else if (p < min + 4 * r) c3++;
                else if (p < min + 5 * r) c4++;
                else if (p < min + 6 * r) c5++;
                else if (p < min + 7 * r) c6++;
                else if (p < min + 8 * r) c7++;
                else if (p < min + 9 * r) c8++;
                else if (p < max) c9++;
            });

            Trace.WriteLine("c0=" + c0);
            Trace.WriteLine("c1=" + c1);
            Trace.WriteLine("c2=" + c2);
            Trace.WriteLine("c3=" + c3);
            Trace.WriteLine("c4=" + c4);
            Trace.WriteLine("c5=" + c5);
            Trace.WriteLine("c6=" + c6);
            Trace.WriteLine("c7=" + c7);
            Trace.WriteLine("c8=" + c8);
            Trace.WriteLine("c9=" + c9);
        }
    }
}
