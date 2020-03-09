using System;
using System.Collections.Generic;
using System.Text;

namespace MDH.Calculator
{
    public static class Calculator
    {
        public static double Eval(string input)
        {
            var tree = Parser.Parse(input);
            return 0;
        }
    }
}
