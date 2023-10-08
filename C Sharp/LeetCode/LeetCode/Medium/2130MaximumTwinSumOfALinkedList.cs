using LeetCode.Common;
using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /*
     * 2130. Maximum Twin Sum of a Linked List
     * In a linked list of size n, where n is even, the ith node (0-indexed)
     * of the linked list is known as the twin of the (n-1-i)th node, if 0 <= i <= (n / 2) - 1.
     * For example, if n = 4, then node 0 is the twin of node 3, and node 1 is the twin of node 2.
     * These are the only nodes with twins for n = 4.
     * The twin sum is defined as the sum of a node and its twin.
     * Given the head of a linked list with even length, return the maximum twin sum of the linked list.
     */
    public class _2130MaximumTwinSumOfALinkedList
    {
        public int PairSum(ListNode head)
        {
            var list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            int maxSum = int.MinValue;
            int n = list.Count;
            for (int i = 0; i < n / 2; i++)
                maxSum = Math.Max(list[i] + list[n - 1 - i], maxSum);
            return maxSum;
        }
    }
}
