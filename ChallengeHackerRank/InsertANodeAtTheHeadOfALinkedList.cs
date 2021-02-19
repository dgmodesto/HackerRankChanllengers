using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class InsertANodeAtTheHeadOfALinkedList
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
        static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode llist, int data)
        {

            SinglyLinkedListNode node = new SinglyLinkedListNode(data);

            if (llist == null)
            {
                llist = node;
            }
            else
            {
                node.next = llist;
            }
            return node;


        }

        public static void Initial(string[] args)
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                SinglyLinkedListNode llist_head = insertNodeAtHead(llist.head, llistItem);
                llist.head = llist_head;
            }

            PrintSinglyLinkedList(llist.head, "\n");

        }
    }
}