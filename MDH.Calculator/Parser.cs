using System;
using System.Collections.Generic;
using System.Text;

namespace MDH.Calculator
{
    public static class Parser
    {
        public static ASTNode Parse(string value)
        {
            var result = ERule(0, value);

            if (result.IsError)
            {
                throw new ArgumentException(result.Error);
            }

            if (result.NewPosition != value.Length)
            {
                throw new ArgumentException("Could not parse symbols starting from " + result.NewPosition);
            }

            return result.Node;
        }

        private static ParseResult ERule(int position, string input)
        {
            var t = TRule(position, input);

            if (t.IsError)
            {
                return t;
            }

            var e1 = E1Rule(t.NewPosition, input);
            if (e1.IsError)
            {
                return e1;
            }

            var node = new RuleNode("E", t.Node, e1.Node);
            return ParseResult.Success(node, e1.NewPosition);
        }

        private static ParseResult E1Rule(int position, string input)
        {
            var plus = E1Subrule(position, input, '+');

            if (!plus.IsError)
            {
                return plus;
            }

            var minus = E1Subrule(position, input, '-');
            if (!minus.IsError)
            {
                return minus;
            }

            return ParseResult.Success(new EmptyNode(), position);
        }

        private static ParseResult E1Subrule(int initPosition, string input, char op)
        {
            if (initPosition >= input.Length)
            {
                return ParseResult.Failure(initPosition, "Expected an operator, found the EOF");
            }

            var symbol = input[initPosition];
            if (symbol != op)
            {
                return ParseResult.Failure(initPosition, $"Expected '{op}' symbol");
            }

            var right = TRule(initPosition + 1, input);

            if (right.IsError)
            {
                return right;
            }

            var position = right.NewPosition;
            var appended = E1Rule(position, input);

            if (appended.IsError)
            {
                return ParseResult.Failure(initPosition, right.Error);
            }

            var node = new RuleNode("E1", new SymbolNode(symbol), right.Node, appended.Node);
            return ParseResult.Success(node, appended.NewPosition);
        }

        private static ParseResult TRule(int position, string input)
        {
            var f = FRule(position, input);

            if (f.IsError)
            {
                return f;
            }


            var t1 = T1Rule(f.NewPosition, input);
            if (t1.IsError)
            {
                return t1;
            }


            var node = new RuleNode("T",f.Node, t1.Node);
            return ParseResult.Success(node, t1.NewPosition);
        }

        private static ParseResult FRule(int position, string input)
        {
            int count = 0;
            while (position + count < input.Length && char.IsDigit(input[position + count]))
            {
                count++;
            }

            if (count == 0)
            {
                return ParseResult.Failure(position, "Expected a number");
            }

            var parsed = int.Parse(input.Substring(position, count));
            var node = new NumberNode(parsed);

            return ParseResult.Success(node, position + count);
        }



        private static ParseResult T1Rule(int position, string input)
        {
            var mul = T1Subrule(position, input, '*');

            if (!mul.IsError)
            {
                return mul;
            }

            var div = T1Subrule(position, input, '/');
            if (!div.IsError)
            {
                return div;
            }

            return ParseResult.Success(new EmptyNode(), position);
        }


        private static ParseResult T1Subrule(int initPosition, string input, char op)
        {
            if (initPosition >= input.Length)
            {
                return ParseResult.Failure(initPosition, "Expected an operator, found the EOF");
            }

            var symbol = input[initPosition];
            if (symbol != op)
            {
                return ParseResult.Failure(initPosition, $"Expected '{op}' symbol");
            }

            var right = FRule(initPosition + 1, input);

            if (right.IsError)
            {
                return right;
            }

            var position = right.NewPosition;
            var appended = T1Rule(position, input);

            if (appended.IsError)
            {
                return ParseResult.Failure(initPosition, right.Error);
            }

            var node = new RuleNode("T1", new SymbolNode(symbol), right.Node, appended.Node);
            return ParseResult.Success(node, appended.NewPosition);
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
