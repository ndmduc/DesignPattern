using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            if (color==null)
            {
                return null;
            }

            if (color.ToUpper().Equals("RED"))
            {
                return new Red();
            }
            else if (color.ToUpper().Equals("GREEN"))
            {
                return new Green();
            }
            else if (color.ToUpper().Equals("BLUE"))
            {
                return new Blue();
            }

            return null;
        }

        public override IShape getShap(string shape)
        {
            return null;
        }
    }
}
