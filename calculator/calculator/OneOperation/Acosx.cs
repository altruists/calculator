using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.OneOperation
{
    
        /// <summary>
        /// This class contains calculation of arccosinus.
        /// </summary>
        public class Acosx : IOneCalculator
        {
            /// <summary>
            /// This method lets to calculate of arccosinus of every angle.
            /// </summary>
            /// <param name="first"></param>
            /// <returns></returns>
            public double Doit(double first)
            {
                return Math.Acos(first);
            }
        }
}
