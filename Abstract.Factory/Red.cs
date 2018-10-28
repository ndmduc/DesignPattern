using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory
{
    public class Red : IColor
    {
        public string Fill()
        {
            return "Inside Red::Fill() method";
        }
    }
}
