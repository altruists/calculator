using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    class EinDegree : IOneCalculator
    {
        public double Doit(double first)
        {
            return Math.Exp(first);
        }
    }
}
