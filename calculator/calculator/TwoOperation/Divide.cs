using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace calculator.TwoOperation
{
    public class Divide: ICalculator
    {
        public double Doit(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль!");
            }
            return first / second;
        }
    }
}
