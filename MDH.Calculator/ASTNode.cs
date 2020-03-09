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

        public char Value { get; }

        public SymbolNode(char value)
        {
            Value = value;
        }
    }
}
