using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Darwin.Core.Dim;

namespace Darwin.Core.Property
{
    public abstract class AbstractProperty<T>
    {
        public virtual T CurrentValue {
            get;
            protected set;
        }

        protected AbstractDimensions<T> dim;

        public AbstractProperty(AbstractDimensions<T> dim) {
            this.dim = dim;
        }

        public abstract void Variation();
    }
}
