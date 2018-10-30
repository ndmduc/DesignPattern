using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circle : Shape
    {
        private int x;

        private int y;

        private int radius;

        public Circle(int x, int y, int radius, IDrawAPI draw) : base(draw)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override string Draw()
        {
            return this.drawApi.DrawCircle(this.radius, this.x, this.y);
        }
    }
}
