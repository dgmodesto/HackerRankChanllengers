using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{

    /*
    - Input
8
20
6
2
19
7
4
15
9
3
    - Output
20 6 2 7 4 15 9
     */
    public class DeleteANode
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

        public static int currentPosition = 0;
        static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position)
        {
            if (position == 0) { return head.next; }
            head.next = deleteNode(head.next, position - 1);
            return head;

            //if (head == null)
            //    return null;
            //if (position == 0)
            //{
            //    var aux = head.next;
            //    head = aux;
            //    return head;
            //}
            //else if (currentPosition != position -1)
            //{
            //    currentPosition++;
            //    head.next = deleteNode(head.next, position);
            //}
            //else
            //{
            //    if (head.next == null)
            //        return head;
            //    else if (head.next.next == null)
            //        head.next = null;
            //    else
            //    {
            //        var aux = head.next.next;
            //        head.next = aux;
            //    }
            //}
            //return head;
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

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist1 = deleteNode(llist.head, position);

            PrintSinglyLinkedList(llist1, " ");
        }
    }
}
