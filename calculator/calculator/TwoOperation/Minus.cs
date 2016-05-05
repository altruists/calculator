namespace calculator.TwoOperation
{
    /// <summary>
    /// This class contains a difference between numbers.
    /// </summary>
    public class Minus: ICalculator
    {
        /// <summary>
        /// This class includes a calculation of difference between tho numbers.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Doit(double first, double second)
        {
            return first - second;
        }
    }
}
