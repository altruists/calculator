﻿namespace calculator.TwoOperation
{
    public class Plus: ICalculator
    {
        public double Doit(double first, double second)
        {
            return first + second;
        }
    }
}
