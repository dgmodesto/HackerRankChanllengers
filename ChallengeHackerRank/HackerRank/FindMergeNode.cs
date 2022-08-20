using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public static class FindMergeNode
    {


        /*
         * For your reference:
         *
         * SinglyLinkedListNode {
         *     int data;
         *     SinglyLinkedListNode next;
         * }
         * 
INPUT 
1
1
3
1
2
3
1
1

OUTPUT
2

         https://www.hackerrank.com/challenges/find-the-merge-point-of-two-joined-linked-lists/problem?isFullScreen=true
         */


        static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
        {
            do
            {
                var header2Aux = head2;
                var curr = head1;
                do
                {
                    if (curr == header2Aux)
                        return head1.data;

                    if (header2Aux == null) break;
                    header2Aux = header2Aux.next;
                } while (true);

                head1 = head1.next;
            } while (head1 != null);

            return 0;
        }

        public static void Initial(string[] args)
        {
            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                int index = Convert.ToInt32(Console.ReadLine());

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

                SinglyLinkedListNode ptr1 = llist1.head;
                SinglyLinkedListNode ptr2 = llist2.head;

                for (int i = 0; i < llist1Count; i++)
                {
                    if (i < index)
                    {
                        ptr1 = ptr1.next;
                    }
                }

                for (int i = 0; i < llist2Count; i++)
                {
                    if (i != llist2Count - 1)
                    {
                        ptr2 = ptr2.next;
                    }
                }

                ptr2.next = ptr1;

                int result = findMergeNode(llist1.head, llist2.head);

                Console.WriteLine(result);
            }

        }

    }
}
