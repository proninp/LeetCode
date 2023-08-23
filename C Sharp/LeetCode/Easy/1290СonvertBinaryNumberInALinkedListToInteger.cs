using LeetCode.Common;

namespace LeetCode.Easy
{
    /*
     * 1290. Convert Binary Number in a Linked List to Integer
     * Given head which is a reference node to a singly-linked list.
     * The value of each node in the linked list is either 0 or 1. The linked list holds the binary representation of a number.
     * Return the decimal value of the number in the linked list.
     * The most significant bit is at the head of the linked list.
     */
    internal class _1290СonvertBinaryNumberInALinkedListToInteger
    {
        public int GetDecimalValue(ListNode head)
        {
            int output = 0;
            while (head != null)
            {
                output = output * 2 + head.val;
                head = head.next;
            }
            return output;
        }
    }
}
