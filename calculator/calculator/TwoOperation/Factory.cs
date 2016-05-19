using System;

namespace calculator.TwoOperation
{
    /// <summary>
    /// Here is buttons which contain operations with two args 
    /// </summary>
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
                case "button9":
                {
                    return new Pow();
                }
                default:
                    throw new Exception("Sorry you are not winner");

            }
        }
    }
}
