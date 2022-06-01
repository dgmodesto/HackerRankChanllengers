using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class AddTwoNumbers
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        /*
Your input
[2,4,3]
[5,6,4]

Output
[7,0,8]

Expected
[7,0,8]
         */

        public static ListNode AddTwoNumbersMethod(ListNode l1, ListNode l2)
        {

            int rest = 0;
            var count = 0;
            ListNode head = null;
            ListNode tail = null;

            while (l1 != null || l2 != null || rest != 0)
            {

                int l1s = (l1 == null) ? 0 : l1.val == null ? 0 : l1.val;
                int l2s = (l2 == null) ? 0 : l2.val == null ? 0 : l2.val;

                count = l1s + l2s + rest;
                rest = 0;

                if (rest > 0) rest = 0;
                rest = count / 10;
                int data = count % 10;

                var node = new ListNode(Convert.ToInt32(data));
                if (head == null && tail == null)
                {
                    head = node;
                    tail = node;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }

                l1 = l1 == null ? null : l1.next;   
                l2 = l2 == null ? null : l2.next;
            }

            return head;

        }

        public static void Initial(string[] args)
        {
            ListNode l1 = CreateListNode(new int[] { 2,4,3});
            ListNode l2 = CreateListNode(new int[] { 5, 6,4});

            var result = AddTwoNumbersMethod(l1, l2);

            while(result != null)
            {
                Console.Write($"{result.val} ");

                result = result.next;
            }
        }

        private static ListNode CreateListNode(int[] input)
        {
            ListNode head = null;
            ListNode tail = null;

            for (int i = 0; i < input.Length; i++)
            {
                var node = new ListNode(input[i]);
                if (head == null && tail == null)
                {
                    head = node;
                    tail = node;
                } else
                {
                    tail.next = node;
                    tail= node;
                }
            }

            return head;
        }
    }
}
