using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Factory
{
    public class Green : IColor
    {
        public string Fill()
        {
            return "Inside Green::Fill() method.";
        }
    }
}
