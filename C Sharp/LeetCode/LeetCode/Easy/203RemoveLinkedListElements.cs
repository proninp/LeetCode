using LeetCode.Common;

namespace LeetCode.Easy
{
    /*
     * 203. Remove Linked List Elements
     * Given the head of a linked list and an integer val,
     * remove all the nodes of the linked list that has Node.val == val, and return the new head.
     */
    public class _203RemoveLinkedListElements
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var root = new ListNode(0, head);
            var node = root;
            while (node != null && node.next != null)
            {
                if (node.next.val == val)
                    node.next = node.next.next;
                else
                    node = node.next;
            }
            return root.next;
        }
    }
}
