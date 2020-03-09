using System;
using System.Data;

namespace MDH.Calculator
{
    public static class Calculator
    {
        
        public static double Calculate(string input)
        {
            DataTable dt = new DataTable();
            var result = dt.Compute(input," ");
            
            return (double)result;
        }
        
        public static void ErrorHandeling(string calculateResult)
        {
        double positive = double.PositiveInfinity;
        double negative = double.NegativeInfinity;
            if (Convert.ToDouble(calculateResult) == positive|| Convert.ToDouble(calculateResult) == negative)
                {
                    Console.WriteLine("divided by zero is not possible");
                return;
                }
        }
    }
}
