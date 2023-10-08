using LeetCode.Common;

namespace LeetCode.Medium
{
    /*
     * 61. Rotate List
     * Given the head of a linked list, rotate the list to the right by k places.
     */
    public class _61RotateList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)
                return head;
            int size = 1;
            var tail = head;
            while (tail.next != null)
            {
                tail = tail.next;
                size++;
            }
            k %= size;
            if (k == 0)
                return head;
            var current = head;
            int i = size - k - 1;
            while (i-- > 0)
                current = current.next;
            var newHead = current.next;
            current.next = null;
            tail.next = head;
            return newHead;
        }
    }
}
