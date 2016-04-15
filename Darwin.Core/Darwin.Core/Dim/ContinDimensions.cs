using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darwin.Core.Dim
{
    public class ContinDimensions<T> : AbstractDimensions<T>
    {
        public T MaxValue { get; private set; }

        public T MinValue { get; private set; }

        public ContinDimensions(T maxValue, T minValue) {
            MaxValue = maxValue;
            MinValue = minValue;
        }
    }
}
