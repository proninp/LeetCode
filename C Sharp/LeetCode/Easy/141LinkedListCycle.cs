using LeetCode.Common;

namespace LeetCode.Easy
{
    /*
     * 141. Linked List Cycle
     * Given head, the head of a linked list, determine if the linked list has a cycle in it.
     * There is a cycle in a linked list if there is some node
     * in the list that can be reached again by continuously following the next pointer.
     * Internally, pos is used to denote the index of the node that tail's next pointer is connected to.
     * Note that pos is not passed as a parameter.
     * Return true if there is a cycle in the linked list. Otherwise, return false.
     */
    internal class _141LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;
            var fast = head;
            var slow = head;
            while (slow.next != null && fast.next?.next != null)
            {
                fast = fast.next.next;
                if (fast == slow)
                    return true;
                slow = slow.next;
            }
            return false;
        }
    }
}
