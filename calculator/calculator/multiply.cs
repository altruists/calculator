﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class Multiply: ICalculator
    {
        public double Doit(double first, double second)
        {
            return first * second;
        }
    }
}