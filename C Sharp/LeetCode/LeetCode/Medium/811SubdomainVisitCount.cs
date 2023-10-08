using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 811. Subdomain Visit Count
     * A website domain "discuss.leetcode.com" consists of various subdomains.
     * At the top level, we have "com", at the next level, we have "leetcode.com" and at the lowest level,
     * "discuss.leetcode.com". When we visit a domain like "discuss.leetcode.com",
     * we will also visit the parent domains "leetcode.com" and "com" implicitly.
     * A count-paired domain is a domain that has one of the two formats "rep d1.d2.d3" or "rep d1.d2"
     * where rep is the number of visits to the domain and d1.d2.d3 is the domain itself.
     * For example, "9001 discuss.leetcode.com" is a count-paired domain that indicates that discuss.leetcode.com was visited 9001 times.
     * Given an array of count-paired domains cpdomains,
     * return an array of the count-paired domains of each subdomain in the input.
     * You may return the answer in any order.
     */
    internal class _811SubdomainVisitCount
    {
        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            var map = new Dictionary<string, int>();
            foreach(var cpdomain in cpdomains)
            {
                var pairs = cpdomain.Split(' ');

                int visitsCnt = int.Parse(pairs[0]);
                if (visitsCnt == 0)
                    continue;
                var domains = pairs[1].Split('.');
                var subDom = new StringBuilder();
                for (int i = domains.Length - 1; i >= 0; i--)
                {
                    if (subDom.Length > 0)
                        subDom.Insert(0, domains[i] + ".");
                    else
                        subDom.Append(domains[i]);
                    if (!map.ContainsKey(subDom.ToString()))
                        map.Add(subDom.ToString(), visitsCnt);
                    else
                        map[subDom.ToString()] += visitsCnt;
                }
            }
            var list = new List<string>(map.Count);
            foreach (var pair in map)
                list.Add($"{pair.Value} {pair.Key}");
            return list;
        }
    }
}
