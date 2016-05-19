using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneOperation
{
     /// <summary>
        /// This class contains calculation of arcsinus.
        /// </summary>
        public class Asinx : IOneCalculator
        {
            /// <summary>
            /// This method lets to calculate of arcsinus of every angle.
            /// </summary>
            /// <param name="first"></param>
            /// <returns></returns>
            public double Doit(double first)
            {
                return Math.Asin(first);
            }
        }
}
