﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IDrawAPI
    {
        string DrawCircle(int radius, int x, int y);
    }
}
