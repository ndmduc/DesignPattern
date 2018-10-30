using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Shape 
    {
        protected IDrawAPI drawApi;

        protected Shape(IDrawAPI draw)
        {
            this.drawApi = draw;
        }

        public abstract string Draw();
    }
}
