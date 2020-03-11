using System;
using System.Collections.Generic;
using System.Text;

namespace MDH.Calculator
{
    public abstract class ASTNode
    {
        public abstract string Name { get; }
    }

    public class RuleNode : ASTNode
    {
        public RuleNode(string name, params ASTNode[] children)
        {
            Name = name;
            Children = children;
        }

        public override string Name { get; }

        public ASTNode[] Children { get; }

        public double Calculate()
        {
            return ECalculate();
        }

        private (char, double)? E1Calculate(ASTNode e1) 
        {
            if (e1 is EmptyNode)
                return null;

            var rule = (RuleNode)e1;
            char symbol = ((SymbolNode)rule.Children[0]).Symbol;
            var t = TCalculate((RuleNode)rule.Children[1]);
            var e1tuple = E1Calculate(rule.Children[2]);
            var right = CalcOp(t, e1tuple);

            return (symbol, right); 
        }

        private double ECalculate()
        {
            var num = TCalculate((RuleNode)Children[0]);
            var e1 = E1Calculate(Children[1]);

            return CalcOp(num, e1);
        }

        private double TCalculate(RuleNode t)
        {
            var num = FCalculate(t.Children[0]);
            var e1 = T1Calculate(t.Children[1]);

            return CalcOp(num, e1);
        }

        private double CalcOp(double left, (char, double)? right)
        {
            if (!right.HasValue)
                return left;

            switch (right.Value.Item1)
            {
                case '+': return left + right.Value.Item2;
                case '-': return left - right.Value.Item2;
                case '*': return left * right.Value.Item2;
                case '/':
                    if (right.Value.Item2 == 0)
                        throw new CalculatorException("Divison by 0 is as abomination!");
                    return left / right.Value.Item2;
                default: throw new CalculatorException("Invalid symbol");
            }
        }

        private (char, double)? T1Calculate(ASTNode t)
        {
            if (t is EmptyNode)
                return null;

            var rule = (RuleNode)t;
            char symbol = ((SymbolNode)rule.Children[0]).Symbol;
            var f = FCalculate(rule.Children[1]);
            var e1tuple = E1Calculate(rule.Children[2]);
            var right = CalcOp(f, e1tuple);

            return (symbol, right);
        }

        private double FCalculate(ASTNode f)
        {
            return ((NumberNode)f).Value;
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

    public class EmptyNode : ASTNode
    {
        public override string Name => "Empty";
    }
}
