﻿namespace calculator.TwoOperataion
{
    class Minus: ICalculator
    {
        public double Doit(double first, double second)
        {
            return first - second;
        }
    }
}