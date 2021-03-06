using System;
using System.Collections.Generic;
using System.Diagnostics;
using Darwin.Core.Property;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Darwin.Core.Property.Tests
{
    /// <summary>此类包含 DiscreteProperty`1 的参数化单元测试</summary>
    [TestClass]
    [PexClass(typeof(DiscreteProperty<>))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DiscretePropertyTTest
    {

        /// <summary>测试 Variation() 的存根</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public void VariationTest<T>([PexAssumeUnderTest]DiscreteProperty<T> target)
        {
            target.Variation();
            // TODO: 将断言添加到 方法 DiscretePropertyTTest.VariationTest(DiscreteProperty`1<!!0>)
        }

        [TestMethod]
        public void VariationTest() {

            List<int> list = new List<int>();
            int c = -100;
            while (c < 100)
            {
                list.Add(++c);
            }

            DiscreteProperty<int> prop = new DiscreteProperty<int>(list);

            Trace.WriteLine("CurrentValue Start with:" + prop.CurrentValue);

            int i = 0;
            while (i++ < 1000) {

                Trace.WriteLine("CurrentValue:" +  prop.CurrentValue);
                prop.Variation();
            }
        }
    }
}
