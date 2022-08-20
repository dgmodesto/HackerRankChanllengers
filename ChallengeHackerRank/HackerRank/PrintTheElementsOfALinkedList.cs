using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class PrintTheElementsOfALinkedList
    {

        /*
            - This an to practice traversing a linked list.
            - Given a pointer to the head node of a linked list, print each node's data elemente, one per line.
            - If the fead ointer is null (indicating the list is empty), there is nothing to print
            - Input
2
13
16
            - Output
13
16
         
         */

        public static void Initial(string[] args)
        {
            SinglyLinkedList llist = new SinglyLinkedList();
            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            PrintsLinkedList(llist.head);

        }

        private static void PrintsLinkedList(SinglyLinkedListNode head)
        {
            Console.WriteLine(head.data);

            if (head.next != null)
                PrintsLinkedList(head.next);

        }
    }

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
}