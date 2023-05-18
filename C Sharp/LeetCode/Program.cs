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
            string[] strs = { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> list = _49_group_anagrams.GroupAnagrams(strs);
            foreach(var e in list)
            {
                Console.Write("( ");
                foreach(var el in e)
                {
                    Console.Write($"[{el}] ");
                }
                Console.Write(" ) ");
            }
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
