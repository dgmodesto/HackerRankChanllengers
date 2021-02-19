using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class MoreLinkedLists
    {
        class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        static Node removeDuplicates(Node head)
        {
            //Write your code here

            if (head.next != null)
            {
                while (head.next != null && head.data == head.next.data)
                {
                    head = head.next;
                }

                if (head.next == null) return head;
                head.next = removeDuplicates(head.next);
            }

            return head;
        }

        static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        public static void Initial(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
