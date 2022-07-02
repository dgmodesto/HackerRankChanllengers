using System;
using System.Collections.Generic;

namespace ChallengeHackerRank.DataStructure
{

  public class Node {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
        }
    }


    public  class _CustomLinkedList
    {
        public Node head;
        public void DeleteKthNodeFromEnd(int k) {
            if (head == null || k == 0) {
                return;
            }

            // [a, b, c, d]
            //k = 2
            Node first = head;
            Node second = head;

            for(int i = 0; i < k; i++) {
                second = second.next;
                if(second.next == null) {
                    // K >= Length of list 
                    if(i == k -1) {
                        head = head.next;
                    }
                    return;
                }
            }

            //second c

            while(second.next != null) {
                first = first.next;
                second = second.next;
            }

            // first = b
            // second = d
            // [a, b, c, d]
            first.next = first.next.next;

        }

        public void DisplayContents() {
            Node current = head;
            while(current != null) {
                Console.Write(current.data + "->");
                current = current.next;
            }
        } 


        public bool HasCycle() {
            HashSet<Node> dic = new HashSet<Node>();
            Node current = head;
            while(current != null) {
                if(dic.Contains(current)) {
                    return true;
                } else {
                    dic.Add(current);
                }
                current = current.next;
            }
            return false;
        }
    }

    public static class LinkedListSample {
        
        public static void Initial(string [] args) {
            _CustomLinkedList linkedList = new _CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);
            // fourthNode.next = secondNode;

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            // linkedList.DisplayContents();
            // linkedList.DeleteKthNodeFromEnd(2);
            // Console.WriteLine();
            // linkedList.DisplayContents();

            Console.WriteLine();
            Console.WriteLine(linkedList.HasCycle());
        }
    }
}