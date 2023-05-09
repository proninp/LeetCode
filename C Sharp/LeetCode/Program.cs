using LeetCode.Easy;
using LeetCode.Medium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LeetCode.Common;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int a = _27RemoveElement.RemoveElement(arr, 2);
            PrintArray(arr);
            Console.WriteLine(a);
            Console.ReadLine();
        }
        static string PrintArray(int[] a)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[");
            foreach (var e in a)
            {
                if (stringBuilder.Length > 1)
                    stringBuilder.Append(", ");
                stringBuilder.Append(string.Format($"{e}", e.ToString()));
            }
            stringBuilder.Append("]");
            Console.WriteLine(stringBuilder.ToString());
            return stringBuilder.ToString();
        }
        static void PrintList(ListNode listNode)
        {
            if (listNode == null)
                Console.WriteLine("[]");
            ListNode current = listNode;
            while(current != null)
            {
                Console.Write($"[{current.val}] ");
                current = current.next;
            }    
        }
    }
}
