using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeHackerRank.AlgoExpert
{
    public static class RemoveDuplicatesFromLinkedList
    {
        public class LinkedList
        {
            public int value;
            public LinkedList next;

            public LinkedList(int value)
            {
                this.value = value;
                this.next = null;
            }
        }

        public static LinkedList RemoveDuplicatesFromLinkedList1(LinkedList linkedList)
        {
            // Complexity O(n) | Space O(n)

            HashSet<int> hs = new HashSet<int>();

            LinkedList noDuplicates = null;
            while (linkedList != null)
            {
                if (!hs.Contains(linkedList.value))
                {
                    hs.Add(linkedList.value);
                }
                linkedList = linkedList.next;
            }

            var hsList = hs.ToArray<int>();
            Array.Reverse(hsList);
            foreach (var item in hsList)
            {
                var linkedItem = new LinkedList(item);
                linkedItem.next = noDuplicates;
                noDuplicates = linkedItem;
            }

            return noDuplicates;
        }

        public static LinkedList RemoveDuplicatesFromLinkedList2(LinkedList linkedList)
        {
            //  Complexity O(n) | Space O(1)

            var curr = linkedList;

            while (curr.next != null)
            {
                if (curr.value == curr.next.value)
                {
                    curr.next = curr.next.next;
                }
                else curr = curr.next;
            }

            return linkedList;
        }
        public static void Initial(string [] args)
        {
            /*
                  {"id": "1", "next": "1-2", "value": 1},
                  {"id": "1-2", "next": "1-3", "value": 1},
                  {"id": "1-3", "next": "2", "value": 1},
                  {"id": "2", "next": "3", "value": 3},
                  {"id": "3", "next": "3-2", "value": 4},
                  {"id": "3-2", "next": "3-3", "value": 4},
                  {"id": "3-3", "next": "4", "value": 4},
                  {"id": "4", "next": "5", "value": 5},
                  {"id": "5", "next": "5-2", "value": 6},
                  {"id": "5-2", "next": null, "value": 6}
             */

            var n1 = new LinkedList(1);
            var n1_2 = new LinkedList(1);
            var n1_3 = new LinkedList(1);
            var n2 = new LinkedList(2);
            var n3 = new LinkedList(3);
            var n3_2 = new LinkedList(3);
            var n3_3 = new LinkedList(3);
            var n4 = new LinkedList(4);
            var n5 = new LinkedList(5);
            var n5_2 = new LinkedList(5);

            n1.next = n1_2;
            n1_2.next = n1_3;
            n1_3.next = n2;
            n2.next = n3;
            n3.next = n3_2;
            n3_2.next = n3_3;
            n3_3.next = n4;
            n4.next = n5;
            n5.next = n5_2;

            var result = RemoveDuplicatesFromLinkedList1(n1);
            /*
             output 
              [
                {"id": "1", "next": "3", "value": 1},
                {"id": "3", "next": "4", "value": 3},
                {"id": "4", "next": "5", "value": 4},
                {"id": "5", "next": "6", "value": 5},
                {"id": "6", "next": null, "value": 6}
              ]
             */
    
            Console.WriteLine($"Expected: ");
            Console.WriteLine($"Actual: { result }");
        }
    }
}
