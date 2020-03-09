using System;
using System.Collections.Generic;
using System.Text;

namespace MDH.Calculator
{
    public static class Calculator
    {
        public static double Eval(string input)
        {
            RuleNode tree = (RuleNode)Parser.Parse(input);
            return tree.Calculate();
        }
    }
}
