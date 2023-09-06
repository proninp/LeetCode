using LeetCode.Common;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Security.Policy;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode root = new ListNode(1);
            var node = root;
            for (int i = 2; i <= 10; i++)
            {
                node.next = new ListNode(i);
                node = node.next;
            }

            _725SplitLinkedListInParts.SplitListToParts(root, 3);

            Console.ReadLine();
        }

    }
}
