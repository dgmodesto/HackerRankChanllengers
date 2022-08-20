using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
    - Given a pointer to the head of a singly-linked list, print each data value from the reversed list.
    - If the given list is empty, do not print anything.
    - Input
3
5
16
12
4
2
5
3
7
3
9
5
5
1
18
3
13
    - Output
5
2
4
12
16
9
3
7
13
3
18
1
5
   
     */
    public class PrintInReverse
    {
        class SinglyLinkedListNode
        {
            public int data;
            public SinglyLinkedListNode next;

            public SinglyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
            }
        }

        class SinglyLinkedList
        {
            public SinglyLinkedListNode head;
            public SinglyLinkedListNode tail;

            public SinglyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                }

                this.tail = node;
            }
        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
                }
            }
        }

        public static void Initial(string [] args)
        {
            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                ReversePrint(llist.head);
            }
        }

        private static void ReversePrint(SinglyLinkedListNode head)
        {
            if (head.next != null)
                ReversePrint(head.next);

            Console.WriteLine(head.data);
        }
    }
}
