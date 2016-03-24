using System;

namespace calculator.TwoOperataion
{
    public static class Factory
    {
        public static ICalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "button1":
                {
                  return new Plus();
                }
                case "button2":
                {
                   return new Multiply();
                }
                case "button3":
                {
                     return new Divide();
                }
                case "button4":
                {
                    return new Minus();
                }
                default:
                    throw new Exception("Sorry you are not winner");

            }
        }
    }
}
