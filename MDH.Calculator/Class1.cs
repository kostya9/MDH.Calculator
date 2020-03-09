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
        
       
    }
}
