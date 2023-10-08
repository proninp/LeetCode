using LeetCode.Common;

namespace LeetCode.Easy
{
    /*
     * 234. Palindrome Linked List
     * Given the head of a singly linked list, return true if it is a palindrome or false otherwise.
     */
    public class _234PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return false;
            if (head.next == null) return true;
            var fast = head;
            var slow = head;
            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            if (fast != null && fast.next == null)
                slow = slow.next;
            var node = slow;
            ListNode next, tail = null;
            while (node != null)
            {
                next = node.next;
                node.next = tail;
                tail = node;
                node = next;
            }
            node = tail;
            while (head != null && node != null)
            {
                if (node.val != head.val) return false;
                head = head.next;
                node = node.next;
            }
            return true;
        }
    }
}
