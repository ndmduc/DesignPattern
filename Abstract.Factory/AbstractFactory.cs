using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory
{
    public abstract class AbstractFactory
    {
        public abstract IColor getColor(string color);

        public abstract IShape getShap(string shape);
    }
}
