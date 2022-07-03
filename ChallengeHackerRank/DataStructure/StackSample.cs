using System;
using System.Collections.Generic;

namespace ChallengeHackerRank.DataStructure
{
  public class StackSample
    {
        /*
        Challenge
        Print the next greater element for every element in the array.

        Note: The next greater element isthe first larger element on the right side of the array.
        */

        static void PrintNextGreaterElementWithoutStack(int [] input) {

            for(int i = 0; i < input.Length; i++) {
                int current = input[i];
                int nextGreater = -1;
                for(int j = i+1; j < input.Length; j++)
                {
                    if(current < input[j]) {
                        nextGreater = input[j];
                        break;
                    }
                }
                Console.WriteLine(current + " --> " + nextGreater);
            }
        }

        static void PrintNextGreaterElement(int [] input) {
            Stack<int> stack = new Stack<int>();
            if(input.Length <= 0 ){
                Console.WriteLine();
                return;
            }

            stack.Push(input[0]);
            for(int i = 0; i < input.Length; i++) {
                int next = input[i];
                if(stack.Count > 0) {
                    int popped = stack.Pop();

                    while(popped < next) {
                        Console.WriteLine(popped + "-->" + next);
                        if(stack.Count == 0) {
                            break;
                        }
                        
                        popped = stack.Pop();
                    }
                    if(popped > next)
                        stack.Push(popped);

                } 
                stack.Push(next);
            }

            while(stack.Count > 0) {
                Console.WriteLine(stack.Pop() + "-->" + -1);
            }
        }


        static bool HasMatchingParentheses(string input) {
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < input.Length; i++) {
                char current = input[i];
                if (current == '(')
                {
                    stack.Push(current);
                    continue;
                }

                if(current == ')') {
                    if(stack.Count > 0) {
                        stack.Pop();
                    } else {
                        return false;
                    }
                }
            }

            
            return stack.Count == 0;
        }

        static bool HasMatchingParenthesesWithoutStack(string input) {
            int matchingSymbolTracker = 0;

            for(int i = 0; i < input.Length; i++) {
                char current = input[i];
                if (current == '(')
                {
                    matchingSymbolTracker++;
                    continue;
                }

                if(current == ')') {
                    if(matchingSymbolTracker > 0) {
                        matchingSymbolTracker--;
                    } else {
                        return false;
                    }
                }
            }

            
            return matchingSymbolTracker == 0;
        }


        public static void Initial(string [] args) {
            Stack<string> stack = new Stack<string>();

            Console.WriteLine("Start Main");
            stack.Push("Main");
            Console.WriteLine("Start ResponseBuilder");
            stack.Push("ResponseBuilder");
            Console.WriteLine("Start CallExternalService");
            stack.Push("CallExternalService");
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("Start ParseExternalData");
            stack.Push("ParseExternalData");
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());
            Console.WriteLine("END " + stack.Pop());

            //stack.Peek()
            //stack.TryPeek()
            string item;
            Console.WriteLine(stack.TryPeek(out item));


            int [] input = new int [] {15, 8, 4, 10};
            int [] input2 = new int [] { 2 };
            int [] input3 = new int [] { 2, 3};
            int [] input4 = new int [] {};
           PrintNextGreaterElementWithoutStack(input);
           PrintNextGreaterElementWithoutStack(input2);
           PrintNextGreaterElementWithoutStack(input3);
           PrintNextGreaterElementWithoutStack(input4);


           Console.WriteLine();

           Console.WriteLine(HasMatchingParentheses("(hello("));
           Console.WriteLine(HasMatchingParentheses(")hello)"));
           Console.WriteLine(HasMatchingParentheses(")hello("));
           Console.WriteLine(HasMatchingParentheses("hello(("));
           Console.WriteLine(HasMatchingParentheses("(hello"));
           Console.WriteLine(HasMatchingParenthesesWithoutStack("((hello)"));

            Console.WriteLine();

           Console.WriteLine(HasMatchingParentheses("((hello()))"));
           Console.WriteLine(HasMatchingParentheses("()(hello())"));
           Console.WriteLine(HasMatchingParentheses("((hello))"));
           Console.WriteLine(HasMatchingParentheses("(hello)"));
           Console.WriteLine(HasMatchingParenthesesWithoutStack("(hello)()"));
        }
    }
}