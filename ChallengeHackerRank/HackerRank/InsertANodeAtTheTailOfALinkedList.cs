using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class InsertANodeAtTheTailOfALinkedList
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

            public SinglyLinkedList()
            {
                this.head = null;
            }

        }

        static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.WriteLine(sep);
                }
            }
        }

        static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data)
        {

            SinglyLinkedListNode node = new SinglyLinkedListNode(data);

            if (head == null)
            {
                head = node;
            }
            else
            {
                if (head.next != null)
                    insertNodeAtTail(head.next, data);
                else
                    head.next = node;
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
                SinglyLinkedListNode llist_head = insertNodeAtTail(llist.head, llistItem);
                llist.head = llist_head;

            }



            PrintSinglyLinkedList(llist.head, "\n");
        }
    }
}
