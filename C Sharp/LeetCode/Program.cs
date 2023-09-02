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
            var urls = new string[] { "leetcode.com", "google.com", "facebook.com", "youtube.com" };
            BrowserHistory obj = new BrowserHistory(urls[0]);
            obj.Visit(urls[1]);
            obj.Visit(urls[2]);
            obj.Visit(urls[3]);
            var list = new List<string>();
            list.Add(obj.Back(1));
            list.Add(obj.Back(1));
            list.Add(obj.Forward(1));
            obj.Visit(urls[0]);
            list.Add(obj.Forward(2));
            list.Add(obj.Back(2));
            list.Add(obj.Back(7));
            
            foreach(var url in list)
                Console.WriteLine(url);

            Console.ReadLine();
        }

    }
}
