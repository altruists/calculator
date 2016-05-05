namespace calculator.TwoOperation
{
    /// <summary>
    /// This class contains a summ some numbers.
    /// </summary>
    public class Plus: ICalculator
    {
        /// <summary>
        /// This class includes a calculation of summ between tho numbers.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public double Doit(double first, double second)
        {
            return first + second;
        }
    }
}
