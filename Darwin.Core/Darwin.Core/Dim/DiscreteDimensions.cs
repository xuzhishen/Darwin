using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darwin.Core.Dim
{
    public class DiscreteDimensions<T> : AbstractDimensions<T>
    {
        public DiscreteDimensions(List<T> dims)
        {
            DiscreteCollections = dims;
        }

        public List<T> DiscreteCollections { get; private set; }
    }
}
