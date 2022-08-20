using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    /*
    - Given a pointer to the head of a linked list and a specific position, determine the data value at that position.
    - Count backwards from the tail node. The tail is at position 0, its parent is at 1 and so on.
    - Input
2
1
1
0
3
3
2
1
2
     - Output
1
3

     */
    public class GetNodeValue
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

        static int GetNode(SinglyLinkedListNode head, int positionFromTail)
        {
            if (head == null)
                return 1;

            var headCurr = head;
            SinglyLinkedListNode tail = null;
            while (headCurr.next != null)
            {
                var temp = headCurr.next;
                headCurr.next = tail;
                tail = headCurr;
                headCurr = temp;
            }
            headCurr.next = tail;

            if (positionFromTail == 0)
                return headCurr.data;

            int posCurr = 0;
            while (posCurr != positionFromTail)
            {
                headCurr = headCurr.next;
                posCurr++;
            }

            return headCurr.data;
        }

        static SinglyLinkedListNode SortLinkedList(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode tail = null;
            while(head.next != null)
            {
                var temp = head.next;
                head.next = tail;
                tail = head;
                head = temp;
            }
            head.next = tail;

            return head;
        }

        public static void Initial(string[] args)
        {

            int tests = Convert.ToInt32(Console.ReadLine());

            for (int testsItr = 0; testsItr < tests; testsItr++)
            {
                SinglyLinkedList llist = new SinglyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                int position = Convert.ToInt32(Console.ReadLine());

                int result = GetNode(llist.head, position);

                Console.WriteLine(result);
            }

        }
    }
}
