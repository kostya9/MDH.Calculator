﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MDH.Calculator
{
    public abstract class ASTNode
    {
        public abstract string Name { get; }
    }

    public class BinOperationNode : ASTNode
    {
        public BinOperationNode(string name)
        {
            Name = name;
        }

        public override string Name { get; }

        public ASTNode[] Children { get; }

        public double Calculate()
        {
            double num1 = Children[0].Name.Equals("E3") ? ((NumberNode)Children[0]).Value : ((BinOperationNode)Children[0]).Calculate();
            double num2 = Children[2].Name.Equals("E3") ? ((NumberNode)Children[2]).Value : ((BinOperationNode)Children[0]).Calculate();
            double result;
            if (num2 == 0) throw new Exception("Cannot divide with 0!");
            var symbol = ((SymbolNode)Children[1]).Symbol;
            switch (symbol)
            {
                case '+':
                    result = num1 + num2;
                    break; 
                case '-':
                    result = num1 + num2;
                    break;
                case '*':
                    result = num1 + num2;
                    break;
                case '/':
                    result = num1 + num2;
                    break;
                default:
                    throw new Exception("Invalid operation symbol!");
                    break;
            }
            return result;
        }

    }

    public class NumberNode : ASTNode
    {
        public NumberNode(double value)
        {
            Value = value;
        }

        public override string Name => "Number";

        public double Value { get; }
    }

    public class SymbolNode : ASTNode
    {
        public override string Name => "Symbol";

        public char Symbol { get; }

        public SymbolNode(char symbol)
        {
            Symbol = symbol;
        }
    }
}
