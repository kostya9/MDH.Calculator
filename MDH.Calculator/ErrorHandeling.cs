using System;

namespace MDH.Calculator
{
    public static class Calculator
    {
        public static void divitionByZero(string calculateResult)
        {
            double positive = double.PositiveInfinity;
            double negative = double.NegativeInfinity;
            if (Convert.ToDouble(calculateResult) == positive || Convert.ToDouble(calculateResult) == negative)
            {
                Console.WriteLine("divided by zero is not possible");
                return;
            }
        }
    }
}