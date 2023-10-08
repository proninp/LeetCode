using LeetCode.Common;

namespace LeetCode.Medium
{
    /*
     * 2. Add Two Numbers
     * You are given two non-empty linked lists representing two non-negative integers.
     * The digits are stored in reverse order, and each of their nodes contains a single digit.
     * Add the two numbers and return the sum as a linked list.
     * You may assume the two numbers do not contain any leading zero, except the number 0 itself.
     */
    public class _2AddTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode tail = null;
            ListNode current;
            int remain = 0;
            int val1, val2, nodeVal;
            while (l1 != null || l2 != null)
            {
                val1 = val2 = 0;
                if (l1 != null)
                    val1 = l1.val;
                if (l2 != null)
                    val2 = l2.val;
                nodeVal = val1 + val2 + remain;
                remain = 0;
                if (nodeVal >= 10)
                {
                    nodeVal -= 10;
                    remain = 1;
                }
                current = new ListNode(nodeVal);
                if (head == null)
                    head = current;
                else
                    tail.next = current;
                tail = current;
                l1 = l1?.next;
                l2 = l2?.next;
            }
            if (remain > 0)
            {
                current = new ListNode(remain);
                tail.next = current;
            }
            return head;
        }
    }
}
