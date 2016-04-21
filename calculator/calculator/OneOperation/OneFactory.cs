using System;

namespace calculator.OneOperation
{
    class OneFactory
    {

        public static IOneCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "button5":
                    {
                        return new Cosx();
                    }
                case "button6":
                    {
                        return new Sinx();
                    }
                
                case "button7":
                    {
                        return new Sqrt();
                    }
                case "button8":
                    {
                        return new EinDegree();
                    }
                default:
                    throw new Exception("Sorry you are not winner");

            }
        }
                
    }
}
