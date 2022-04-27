using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
     https://www.hackerrank.com/challenges/reverse-a-doubly-linked-list/problem?isFullScreen=true&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
     
INPUT
1
4
1
2
3
4
OUTPUT
4 3 2 1 
     
     */
    public static class ReverseDoublyLinkedList
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

        static DoublyLinkedListNode reverse(DoublyLinkedListNode llist)
        {
            DoublyLinkedListNode temp = llist;
            DoublyLinkedListNode newHead = llist;

            while (temp != null)
            {
                DoublyLinkedListNode prev = temp.prev;
                temp.prev = temp.next;
                temp.next = prev;
                newHead = temp;
                temp = temp.prev;
            }
            return newHead;
        }
        /*
        1, 2, 3, 4, 5 - null

            auxPrev = 5
            curr = 4
            curr.prev = auxPrev
            return curr;

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

                DoublyLinkedListNode llist1 = reverse(llist.head);

                PrintDoublyLinkedList(llist1, " ");
                Console.WriteLine();
            }

        }
    }
}