using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class SortedDoublyLinkedList
    {
        class DoublyLinkedListNode
        {
            public int data;
            public DoublyLinkedListNode next;
            public DoublyLinkedListNode prev;

            public DoublyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
                this.prev = null;
            }
        }

        class DoublyLinkedList
        {
            public DoublyLinkedListNode head;
            public DoublyLinkedListNode tail;

            public DoublyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                    node.prev = this.tail;
                }

                this.tail = node;
            }
        }

        static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep)
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

        static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode llist, int data)
        {
            DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);
            if (llist.data > data)
            {
                newNode.next = llist;
                newNode.prev = llist.prev;
                newNode.prev.next = newNode;
                llist.prev = newNode;

                return newNode;

            }
            else if (llist.next == null)
            {
                newNode.prev = llist;
                llist.next = newNode;
            }
            else
            {
                sortedInsert(llist.next, data);
            }

            return llist;
        }

        /*
INPUT
1
4
1
3
4
10
5
OUTPUT
1 3 4 5 10
         
         */

        public static void Initial(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                DoublyLinkedList llist = new DoublyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                int data = Convert.ToInt32(Console.ReadLine());

                DoublyLinkedListNode llist1 = sortedInsert(llist.head, data);


                PrintDoublyLinkedList(llist1, " ");
                Console.WriteLine();
            }

        }
    }
}
