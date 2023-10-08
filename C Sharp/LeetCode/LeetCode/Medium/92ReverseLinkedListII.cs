using LeetCode.Common;

namespace LeetCode.Medium
{
    /*
     * 92. Reverse Linked List II
     * Given the head of a singly linked list and two integers left and right where left <= right,
     * reverse the nodes of the list from position left to position right, and return the reversed list.
     */
    public class _92ReverseLinkedListII
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null) return null;
            var dummy = new ListNode(0, head);
            var lPrev = dummy;
            var curr = head;
            for (int i = 1; i < left; i++)
                (lPrev, curr) = (curr, curr.next);
            ListNode next, tail = null;
            int counter = right - left + 1;
            while (counter-- > 0)
            {
                next = curr.next;
                curr.next = tail;
                (tail, curr) = (curr, next);
            }
            lPrev.next.next = curr;
            lPrev.next = tail;
            return dummy.next;
        }
    }
}
