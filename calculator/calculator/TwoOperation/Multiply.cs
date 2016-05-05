namespace calculator.TwoOperation
{
    /// <summary>
    /// This class contains a method of multiplication of some numbers.
    /// </summary>
   public class Multiply: ICalculator
    {
       /// <summary>
       /// This method includes a multiplication for tho numbers.
       /// </summary>
       /// <param name="first"></param>
       /// <param name="second"></param>
       /// <returns></returns>
        public double Doit(double first, double second)
        {
            return first * second;
        }
    }
}
