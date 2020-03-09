using System;
using System.Data;

namespace MDH.Calculator
{
    public static class Calculator
    {
        
        public static string Calculate(string input)
        {
            DataTable dt = new DataTable();
              try 
	           {	        
		         var result = dt.Compute(input," ");
               }
            catch (System.Data.EvaluateException)
	           {
                return "***Erorr:SyntaxError***";
        	   }
            catch (System.Data.SyntaxErrorException)
              {
                return "***Erorr:SyntaxError***";
              }
            
            return (string)result;
        }
        
       
    }
}
