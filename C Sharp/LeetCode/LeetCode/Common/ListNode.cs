using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Common
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
        void PrintList()
        {
            if (this == null)
                Console.WriteLine("[]");
            ListNode current = this;
            while (current != null)
            {
                Console.Write($"[{current.val}] ");
                current = current.next;
            }
        }
    }
}
