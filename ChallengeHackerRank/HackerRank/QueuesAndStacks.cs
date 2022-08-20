using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class QueuesAndStacks
    {

        public static void Initial (string [] args)
        {
            // read the string s.
            string s = Console.ReadLine();

            // create the Solution class object p.
            QueuesAndStacks obj = new QueuesAndStacks();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                var stack = obj.popCharacter();
                var queue = obj.dequeueCharacter();
                if ( stack != queue)
                {
                    isPalindrome = false;
                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }
        }

        public Stack<char> charS = new Stack<char>();
        public Queue<char> charQ = new Queue<char>();

        void pushCharacter(char c)
        {
            charS.Push(c);
        }

        char popCharacter()
        {
            return charS.Pop();
        }
        void enqueueCharacter(char c)
        {
            charQ.Enqueue(c);
        }

        char dequeueCharacter()
        {
            return charQ.Dequeue();
        }
    }
}
