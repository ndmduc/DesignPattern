using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(string choice)
        {
            if (choice.ToUpper().Equals("SHAPE"))
            {
                return new ShapeFactory();
            }
            else if (choice.ToUpper().Equals("COLOR"))
            {
                return new ColorFactory();
            }

            return null;
        }
    }
}
