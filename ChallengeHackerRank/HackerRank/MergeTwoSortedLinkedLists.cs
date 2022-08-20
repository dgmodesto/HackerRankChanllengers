using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
    - Given pointers to the heads of two sorted linked lists, merge them into a single, sorted linked list.
    - Either head pointer may be null meaning that the corresponding list is empty.
     */
    public class MergeTwoSortedLinkedLists
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
                SinglyLinkedList llist1 = new SinglyLinkedList();

                int llist1Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist1Count; i++)
                {
                    int llist1Item = Convert.ToInt32(Console.ReadLine());
                    llist1.InsertNode(llist1Item);
                }

                SinglyLinkedList llist2 = new SinglyLinkedList();

                int llist2Count = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llist2Count; i++)
                {
                    int llist2Item = Convert.ToInt32(Console.ReadLine());
                    llist2.InsertNode(llist2Item);
                }

                SinglyLinkedListNode llist3 = MergeLists2(llist1.head, llist2.head);

                Console.WriteLine();
            }

        }


        // Complete the mergeLists function below.

        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         *
         */

        static SinglyLinkedListNode MergeLists1(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            if (head1 == null)
            {
                return head2;
            }
            else if (head2 == null)
            {
                return head1;
            }

            /* Find new head pointer */
            SinglyLinkedListNode head = null;
            if (head1.data < head2.data)
            {
                head = head1;
                head1 = head1.next;
            }
            else
            {
                head = head2;
                head2 = head2.next;
            }

            /* Build rest of list */
            SinglyLinkedListNode n = head;
            while (head1 != null && head2 != null)
            {
                if (head1.data < head2.data)
                {
                    n.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    n.next = head2;
                    head2 = head2.next;
                }
                n = n.next;
            }

            /* Attach the remaining elements */
            if (head1 == null)
            {
                n.next = head2;
            }
            else
            {
                n.next = head1;
            }

            return head;
        }

        static SinglyLinkedListNode MergeLists2(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            if ((head1 == null) && (head2 == null))
                return null;
            if ((head1 != null) && (head2 == null))
                return head1;
            if ((head1 == null) && (head2 != null))
                return head2;
            if (head1.data <= head2.data)
                head1.next = MergeLists1(head1.next, head2);
            else if (head1.data > head2.data)
            {
                SinglyLinkedListNode temp = head2;
                head2 = head2.next;
                temp.next = head1;
                head1 = temp;
                head1.next = MergeLists1(head1.next, head2);
            }
            return head1;
        }
    }
}