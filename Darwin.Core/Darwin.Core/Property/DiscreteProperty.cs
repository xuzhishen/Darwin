using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Darwin.Core.Dim;

namespace Darwin.Core.Property
{
    public class DiscreteProperty<T> : AbstractProperty<T>
    {
        private int idx;

        public DiscreteProperty(List<T> dims) :
            this(dims, dims.Count / 2 + dims.Count % 2 - 1)
        { }

        public DiscreteProperty(List<T> dims,int idx) :
            base(new DiscreteDimensions<T>(dims))
        {
            if (dims == null || dims.Count == 0) throw new Exception("Error Param: dims is empty");

            if (idx < 0 || idx > dims.Count - 1) throw new Exception("Error Param: idx is error");

            this.idx = idx;
        }

        public override T CurrentValue
        {
            get
            {
                DiscreteDimensions<T> _dim = dim as DiscreteDimensions<T>;
                return _dim.DiscreteCollections[idx];
            }
        }

        /// <summary>
        /// 标准正态分布进行突变
        /// </summary>
        public override void Variation()
        {
            DiscreteDimensions<T> _dim = dim as DiscreteDimensions<T>;
            int length = _dim.DiscreteCollections.Count;

            if (length <= 1) return;

            short rd = Convert.ToInt16(Math.Round(RandomTool.GetNDRandomNum(0, 1)));
            idx += rd;

            if (idx < 0) idx = 0;

            if (idx > _dim.DiscreteCollections.Count - 1) idx = _dim.DiscreteCollections.Count - 1;
        }
    }
}
