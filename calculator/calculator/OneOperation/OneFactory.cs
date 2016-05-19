using System;

namespace calculator.OneOperation
{
    /// <summary>
    /// Here is buttons which contain operations with one arg
    /// </summary>
 
    public static class OneFactory
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
                case "button10":
                    {
                        return new log10();
                    }
                case "button11":
                    {
                        return new Asinx();
                    }
                case "button12":
                    {
                        return new Acosx();
                    }
                default:
                    throw new Exception("Sorry you are not winner");

            }
        }
                
    }
}
