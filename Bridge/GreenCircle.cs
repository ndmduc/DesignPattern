using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class GreenCircle : IDrawAPI
    {
        public string DrawCircle(int radius, int x, int y)
        {
            return string.Format("Drawing circle [color: GREEN, radius: {0}, x: {1}, y: {2}]", radius, x, y);
        }
    }
}
