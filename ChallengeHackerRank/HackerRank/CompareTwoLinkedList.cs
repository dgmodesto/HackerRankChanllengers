using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class CompareTwoLinkedList
    {

        /*
        -  You're given the pointer to the head nodes os two linkes lists.
        - Compare the data in the nodes of the linked lists to check if they are equal
        - If all data attributes are equal and the lists are the same length, return 1. Otherwise, return 0;
        - Example
            - list1 = 1 -> 2 -> 3 -> NULL
            - list2 = 1 -> 2> -> 3 -> 4 -> NULL
            - The two lists have equal data attributes fot the first 3 nodes. list2 is longer, though, so the lists are not equal. Return 0;
        - Input
2
2
1
2
1
1
2
1
2
2
1
2
        - Output
0
1
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

                bool result = CompareLists(llist1.head, llist2.head);

                Console.WriteLine((result ? 1 : 0));
            }

            bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
            {
                if (head1 == null && head2 == null)
                    return true;
                else if (head1 == null || head2 == null)
                    return false;

                if (head1.data == head2.data)
                    return CompareLists(head1.next, head2.next);
                else
                    return false;

            }
        }
    }
}