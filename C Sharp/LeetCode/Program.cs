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
            ListNode l1 = new ListNode(9);
            
            
            ListNode l2 = new ListNode(1);
            var node = l2;
            node.next = new ListNode(9);
            node = node.next;
            node.next = new ListNode(9);
            node = node.next;
            node.next = new ListNode(9);
            node = node.next;
            node.next = new ListNode(9);
            node = node.next;
            node.next = new ListNode(9);
            node = node.next;
            node.next = new ListNode(9);
            node = node.next;
            node.next = new ListNode(9);
            node = node.next;
            node.next = new ListNode(9);
            node = node.next;
            node.next = new ListNode(9);

            var ans = _2AddTwoNumbers.AddTwoNumbers(l1, l2);
            Console.ReadLine();
        }

    }
}
