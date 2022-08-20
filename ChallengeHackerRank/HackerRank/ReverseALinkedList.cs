using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
    - Given the pointer to the head node of a linked list, change the next poiters of the nodes so that their ordes is reversed.
    - The head pointer given may be null meaning that the initial list is empty
    - Example 
        - head reference the list 1 -> 2 -> 3 -> NULL
        - Manipulate the next pointers of each node in place and return head, now referencing the head of the list 
            - 3 -> 2 -> 1 -> NULL
    - Input
1
5
1
2
3
4
5   
    - Output
5 4 3 2 1 
   
     */


    public class ReverseALinkedList
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

        public static void Initial(string[] args)
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

                SinglyLinkedListNode llist1 = Reverse(llist.head);

                PrintSinglyLinkedList(llist1, " ");
                Console.WriteLine();
            }
        }

        private static SinglyLinkedListNode Reverse(SinglyLinkedListNode head)
        {

            SinglyLinkedListNode tail = null;
            while (head.next != null)
            {
                var temp = head.next;
                head.next = tail;
                tail = head;
                head = temp;
            }

            head.next = tail;

            return head;
        }
    }
}
