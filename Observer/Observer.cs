﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public abstract class Observer
    {
        public abstract string Update();

        protected Subject subject;
    }
}
