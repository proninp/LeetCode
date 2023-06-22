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
            var orders = new List<List<string>>()
            {
                new List<string>() { "David","3","Ceviche" },
                new List<string>() { "Corina","10","Beef Burrito" },
                new List<string>() { "David","3","Fried Chicken" },
                new List<string>() { "Carla","5","Water" },
                new List<string>() { "Carla", "5", "Ceviche" },
                new List<string>() { "Rous", "3", "Ceviche" }
            };

            _1418DisplayTableOfFoodOrdersInARestaurant.DisplayTable(orders);
            //Console.WriteLine(string.Join(", ", ans.ToArray()));
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
