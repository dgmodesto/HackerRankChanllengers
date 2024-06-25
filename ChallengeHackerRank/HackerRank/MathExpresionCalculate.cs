using System.Collections.Generic;
using System;
using System.Data;
using System.Linq;

namespace ChallengeHackerRank.HackerRank
{
    public static class MathExpresionCalculate
    {

        static string mathExpresionCalculate1(string str)
        {
            string result = new DataTable().Compute(str, null).ToString();
            return result;
        }

        static string mathExpresionCalculate(string str)
        {
            var expressionConverted = ConvertExpression(str);
            string result = EvaluateExpression(expressionConverted);

            return result;
        }

        static string EvaluateExpression(List<string> expressions)
        {
            Stack<decimal> stack = new Stack<decimal>();

            foreach (var token in expressions)
            {
                if (decimal.TryParse(token, out decimal number))
                {
                    stack.Push(number);
                }
                else
                {
                    decimal op2 = stack.Pop();
                    decimal op1 = stack.Pop();

                    switch (token)
                    {
                        case "+":
                            stack.Push(op1 + op2);
                            break;
                        case "-":
                            stack.Push(op1 - op2);
                            break;
                        case "*":
                            stack.Push(op1 * op2);
                            break;
                        case "/":
                            stack.Push(op1 / op2);
                            break;
                    }
                }
            }

            return stack.Peek().ToString();
        }
        static List<string> ConvertExpression(string expression)
        {
            List<string> output = new List<string>();
            Stack<char> operators = new Stack<char>();
            bool beforeWasDigit = false;
            foreach (char token in expression)
            {

                if (char.IsDigit(token) && beforeWasDigit)
                {
                    var lastItem = output.Last();
                    lastItem += token.ToString();
                    output.RemoveAt(output.Count - 1);
                    output.Add(lastItem);
                }
                else if (char.IsDigit(token))
                {
                    output.Add(token.ToString());
                    beforeWasDigit = true;
                }
                else if (IsOperator(token))
                {
                    beforeWasDigit = false;

                    while (operators.Count > 0 && IsOperator(operators.Peek()) &&
                        Precedence(token) <= Precedence(operators.Peek()))
                    {
                        output.Add(operators.Pop().ToString());
                    }
                    operators.Push(token);
                }
                else if (token == '(')
                {
                    beforeWasDigit = false;
                    operators.Push(token);
                }
                else if (token == ')')
                {
                    beforeWasDigit = false;
                    while (operators.Count > 0 && operators.Peek() != '(')
                    {
                        output.Add(operators.Pop().ToString());
                    }
                    operators.Pop();
                }
            }

            while (operators.Count > 0)
            {
                output.Add(operators.Pop().ToString());
            }

            return output;
        }

        private static bool IsOperator(char token)
        {
            return token == '+' || token == '-' || token == '*' || token == '/';
        }

        private static int Precedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    return 0;

            }
        }

        public static void Initial(string[] args)
        {
            var input = "6*(4/2)+3*1";
            string output = "15";
            var result = mathExpresionCalculate(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", String.Join(" ", result));

            Console.WriteLine("-------------------------------");

            input = "(10/2)+(3*3)+20";
            output = "34";
            result = mathExpresionCalculate(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", String.Join(" ", result));

            Console.WriteLine("-------------------------------");

            input = "6*(10/2)+(3*3)+20";
            output = "59";
            result = mathExpresionCalculate(input);

            Console.WriteLine("Expected : {0} ", output);
            Console.WriteLine("Result :{0} ", String.Join(" ", result));

            Console.WriteLine("-------------------------------");

        }

    }

}

