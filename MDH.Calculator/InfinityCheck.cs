using System;

namespace MDH.Calculator
{
    public static class Calculator
    {
        public static string infinityCheck(double calculateResult)
        {
            double positive = double.PositiveInfinity;
            double negative = double.NegativeInfinity;
            if (Convert.ToDouble(calculateResult) == positive || Convert.ToDouble(calculateResult) == negative)
            {
                return "divided by zero is not possible";
            }
        }
    }
}