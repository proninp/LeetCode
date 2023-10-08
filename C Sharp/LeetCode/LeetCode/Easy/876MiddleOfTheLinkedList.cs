using LeetCode.Common;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Easy
{
    /*
     * 876. Middle of the Linked List
     * Given the head of a singly linked list, return the middle node of the linked list.
     * If there are two middle nodes, return the second middle node.
     */
    internal class _876MiddleOfTheLinkedList
    {
        public ListNode MiddleNode(ListNode head)
        {
            var list = new List<ListNode>();
            while (head != null)
            {
                list.Add(head);
                head = head.next;
            }
            return list.ElementAt(list.Count / 2);
        }
    }
}
