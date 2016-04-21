namespace calculator.TwoOperation
{
    public class Minus: ICalculator
    {
        public double Doit(double first, double second)
        {
            return first - second;
        }
    }
}
