using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace calculator.TwoOperation
{
    /// <summary>
    /// This class contains a method of dividing.
    /// </summary>
    public class Divide: ICalculator
    {
        /// <summary>
        /// This method includes a dividing number by number. Also there is an exception which is thrown when dividing by zero.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
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
