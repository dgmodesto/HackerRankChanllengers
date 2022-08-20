using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class InsertANodeAtASpecificPositionInALinkedList
    {
        /*
            - input
3
16
13
7
1
2
            - output
16 13 1 7
         
         */

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

        public static int positionCurrent = 0;
        static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(data);
            if (positionCurrent == position -1)
            {
                var nextAux = head.next;
                node.next = nextAux;
                head.next = node;
            }
            else
            {
                positionCurrent++;
                insertNodeAtPosition(head.next, data, position);
            }
            return head;
        }

        public static void Initial(string[] args)
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int data = Convert.ToInt32(Console.ReadLine());

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

            PrintSinglyLinkedList(llist_head, " ");
        }
    }
}