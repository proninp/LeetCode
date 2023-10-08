using LeetCode.Common;

namespace LeetCode.Medium
{
    /*
     * 2807. Insert Greatest Common Divisors in Linked List
     * Given the head of a linked list head, in which each node contains an integer value.
     * Between every pair of adjacent nodes, insert a new node with a value equal to the greatest common divisor of them.
     * Return the linked list after insertion.
     * The greatest common divisor of two numbers is the largest positive integer that evenly divides both numbers.
     */
    internal class _2807InsertGreatestCommonDivisorsInLinkedList
    {
        public ListNode InsertGreatestCommonDivisors(ListNode head)
        {
            var route = head;
            while (route?.next != null)
            {
                int a = route.val;
                int b = route.next.val;
                while (a != 0 && b != 0)
                {
                    if (a > b)
                        a %= b;
                    else
                        b %= a;
                }
                route.next = new ListNode(a + b, route.next);
                route = route.next.next;
            }
            return head;
        }
    }
}
