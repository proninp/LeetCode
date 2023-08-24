using LeetCode.Common;

namespace LeetCode.Medium
{
    /*
     * 2181. Merge Nodes in Between Zeros
     * You are given the head of a linked list, which contains a series of integers separated by 0's.
     * The beginning and end of the linked list will have Node.val == 0.
     * For every two consecutive 0's, merge all the nodes lying in between them into a single node whose value is the sum of all the merged nodes.
     * The modified list should not contain any 0's.
     * Return the head of the modified linked list.
     */
    internal class _2181MergeNodesInBetweenZeros
    {
        public ListNode MergeNodes(ListNode head)
        {
            ListNode newRoot = new ListNode();
            ListNode newNode = newRoot;
            bool isPrevZero = false;
            head = head.next;
            while (head != null)
            {
                if (head.val == 0)
                    isPrevZero = true;
                else
                {
                    if (isPrevZero)
                    {
                        isPrevZero = false;
                        newNode.next = new ListNode();
                        newNode = newNode.next;
                    }
                    newNode.val += head.val;
                }
                head = head.next;
            }
            return newRoot;
        }
    }
}
