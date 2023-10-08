using LeetCode.Common;

namespace LeetCode.Easy
{
    /*
     * 206. Reverse Linked List
     * Given the head of a singly linked list, reverse the list, and return the reversed list.
     */
    internal class _206ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode tail = null;
            ListNode next;
            while (head != null)
            {
                next = head.next;
                head.next = tail;
                tail = head;
                head = next;
            }
            return tail;
        }

    }
}
