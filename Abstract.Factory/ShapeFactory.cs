using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            return null;
        }

        public override IShape getShap(string shape)
        {
            if (shape == null)
            {
                return null;
            }

            if (shape.ToUpper().Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shape.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shape.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }

            return null;
        }
    }
}
