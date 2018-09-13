using System;
using System.Text;
using static LeetCode.ClassLib.ListNode;

/*

You are given two non-empty linked lists representing two non-negative integers. 
The digits are stored in reverse order and each of their nodes contain a single digit. Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Example:

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8
Explanation: 342 + 465 = 807.

 */

namespace LeetCode.ClassLib {
    public class LinkedList {
        private ListNode head;

        /// <summary>
        /// Adds node to front of linked list
        /// </summary>
        /// <param name="linkedList"></param>
        /// <param name="data"></param>
        public void AddFront (LinkedList linkedList, int data) {
            ListNode newNode = new ListNode (data);
            newNode.next = linkedList.head;
            linkedList.head = newNode;
        }

        /// <summary>
        /// Adds node to end of linked list
        /// </summary>
        /// <param name="linkedList"></param>
        /// <param name="data"></param>
        public void AddEnd (LinkedList linkedList, int data) {
            ListNode newNode = new ListNode (data);
            if (linkedList.head == null) {
                linkedList.head = newNode;
            }

            ListNode lastNode = GetLastNode (linkedList);
            lastNode.next = newNode;
        }

        /// <summary>
        /// Gets last node in linked list
        /// </summary>
        /// <param name="linkedList"></param>
        /// <returns>The last node in the linked list</returns>
        public ListNode GetLastNode (LinkedList linkedList) {
            ListNode current = linkedList.head;
            while (current.next != null) {
                current = current.next;
            }

            return current;
        }

        /// <summary>
        /// Prints linked list
        /// </summary>
        /// <param name="linkedList"></param>
        public void PrintListNodes (LinkedList linkedList) {
            ListNode current = head;
            while (current != null) {
                Console.WriteLine (current.data);
                current = current.next;
            }
        }

        /// <summary>
        /// Reverses a linked list
        /// </summary>
        /// <param name="linkedList"></param>
        public void ReverseLinkedList (LinkedList linkedList) {
            ListNode current = linkedList.head;
            ListNode prev = null;
            ListNode temp = null;

            while (current != null) {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }

            linkedList.head = prev;
        }

        /// <summary>
        /// Gets the linked list into number form
        /// </summary>
        /// <param name="linkedList"></param>
        /// <returns>An integer representing the linked list numbers combined</returns>
        public int GetNumber (LinkedList linkedList) {
            StringBuilder buffer = new StringBuilder ();
            ListNode current = linkedList.head;

            while (current != null) {
                string numberString = current.data.ToString ();
                buffer.Append (numberString);
                current = current.next;
            }

            return Int32.Parse (buffer.ToString ());
        }

    }
}