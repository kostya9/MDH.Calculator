using System;
using System.Collections.Generic;
using System.Text;

namespace MDH.Calculator
{
    public static class Parser
    {
        public static ASTNode Parse(string value)
        {
            var result = E1Rule(0, value);

            if(result.IsError)
            {
                throw new ArgumentException(result.Error);
            }

            if(result.NewPosition != value.Length)
            {
                throw new ArgumentException("Could not parse symbols starting from " + result.NewPosition);
            }

            return result.Node;
        }

        private static ParseResult E1Rule(int position, string input)
        {
            var plus = PlusRule(position, input);

            if(!plus.IsError)
            {
                return plus;
            }

            var minus = MinusRule(position, input);
            if (!minus.IsError)
            {
                return minus;
            }

            return E2Rule(position, input);
        }

        private static ParseResult PlusRule(int initPosition, string input)
        {
            return BinaryRule(initPosition, input, '+', "E1");
        }

        private static ParseResult MinusRule(int initPosition, string input)
        {
            return BinaryRule(initPosition, input, '-', "E1");
        }

        private static ParseResult BinaryRule(int initPosition, string input, char op, string ruleName)
        {
            var left = E2Rule(initPosition, input);

            if (left.IsError)
            {
                return left;
            }


            if(left.NewPosition >= input.Length)
            {
                return ParseResult.Failure(initPosition, "Expected an operator, found the EOF");
            }

            var symbol = input[left.NewPosition];
            if (symbol != op)
            {
                return ParseResult.Failure(initPosition, $"Expected '{op}' symbol");
            }

            var position = left.NewPosition + 1;
            var right = E1Rule(position, input);

            if (right.IsError)
            {
                return ParseResult.Failure(initPosition, right.Error);
            }

            var node = new RuleNode(ruleName, left.Node, new SymbolNode(symbol), right.Node);
            return ParseResult.Success(node, right.NewPosition);
        }

        private static ParseResult E2Rule(int position, string input)
        {
            var e3 = E3Rule(position, input);

            if (e3.IsError)
            {
                return e3;
            }

            var node = new RuleNode("E2", e3.Node);
            return ParseResult.Success(node, e3.NewPosition);
        }

        private static ParseResult E3Rule(int position, string input)
        {
            int count = 0;
            while (position + count < input.Length && char.IsDigit(input[position + count]))
            {
                count++;
            }

            if(count == 0)
            {
                return ParseResult.Failure(position, "Expected a number");
            }

            var parsed = int.Parse(input.Substring(position, count));
            var node = new RuleNode("E3", new NumberNode(parsed));

            return ParseResult.Success(node, position + count);
        }
    }

    internal class ParseResult
    {
        public bool IsError { get; private set; }

        public string Error { get; private set; }

        public ASTNode Node { get; private set; }

        public int NewPosition { get; private set; }

        public static ParseResult Success(ASTNode node, int position)
        {
            return new ParseResult
            {
                Node = node,
                NewPosition = position
            };
        }

        public static ParseResult Failure(int prevPosition, string errorText)
        {
            return new ParseResult
            {
                IsError = true,
                Error = errorText,
                NewPosition = prevPosition
            };
        }
    }
}
