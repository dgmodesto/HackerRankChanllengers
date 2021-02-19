using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{

    /*
    - You are given the ponter to the head node of a sorted linked list, where the data in the nodes is in ascending order.
    - Delete nodes and return a sorted list with each distinct value in the original list.
    - The given head pointer may be null indicating that the list is empty.
    - Example
        - list 1 -> 2 -> 3 -> 4 -> 4 -> 5 -> null
        - Remove 1 of the 4 data values and return head pointing to the revised list
            - list 1 -> 2 -> 3 -> 4 -> 5 -> null

    - Input
1
5
1
2
2
3
4
    - Output
1 2 3 4 
     */


    public class DeleteDuplicateValueSortedLinkedList
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
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                SinglyLinkedListNode llist1 = RemoveDuplicates(llist.head);

                PrintSinglyLinkedList(llist1, " ");
                Console.WriteLine();
            }
        }


        static int beforeValue = int.MinValue;
        private static SinglyLinkedListNode RemoveDuplicates(SinglyLinkedListNode head)
        {

            if (head.next != null)
                head.next = RemoveDuplicates(head.next);
            
            if (beforeValue == head.data)
            {
                var temp = head.next;
                head = temp;
            } else
            {
                beforeValue = head.data;
            }

            return head;
        }
    }
}