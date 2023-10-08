using LeetCode.Common;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /*
     * 725. Split Linked List in Parts
     * Given the head of a singly linked list and an integer k, split the linked list into k consecutive linked list parts.
     * The length of each part should be as equal as possible: no two parts should have a size differing by more than one.
     * This may lead to some parts being null.
     * The parts should be in the order of occurrence in the input list,
     * and parts occurring earlier should always have a size greater than or equal to parts occurring later.
     * Return an array of the k parts.
     */
    public class _725SplitLinkedListInParts
    {
        public static ListNode[] SplitListToParts(ListNode head, int k)
        {
            int size = 0;
            var lNode = head;
            while(lNode != null)
            {
                size++;
                lNode = lNode.next;
            }
            int chunks = 1, remainder = 0;
            if (k < size)
            {
                chunks = size / k;
                remainder = size % k;
            }
            var output = new ListNode[k];
            int i = 0, j = 0;
            while (i < size)
            {
                var listLen = chunks;
                if (remainder > 0)
                {
                    listLen++;
                    remainder--;
                }
                ListNode root = new ListNode();
                var node = root;
                while(listLen-- > 0)
                {
                    node.next = new ListNode(head.val);
                    head = head.next;
                    node = node.next;
                    i++;
                }
                output[j++] = root.next;
            }
            return output;
        }
    }
}
