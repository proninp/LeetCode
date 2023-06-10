using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 347. Top K Frequent Elements
     * Given an integer array nums and an integer k, return the k most frequent elements.
     * You may return the answer in any order.
     */
    internal class _347TopKFrequentElements
    {
        public static int[] TopKFrequent1(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else
                    map.Add(nums[i], 1);
            }
            return map.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
        }
        public static int[] TopKFrequent2(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            int[] ans = new int[k];
            var freq = new List<int>[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else
                    map.Add(nums[i], 1);
            }
            foreach(var pair in map)
            {
                if (freq[pair.Value] == null)
                    freq[pair.Value] = new List<int>();
                freq[pair.Value].Add(pair.Key);
            }
            int ansPointer = 0;
            for (int i = freq.Length - 1; i >= 0 && k > 0; i--)
            {
                if (freq[i] != null)
                    for (int j = 0; j < freq[i].Count && k > 0; j++)
                    {
                        ans[ansPointer++] = freq[i][j];
                        k--;
                    }
            }
            return ans;
        }
    }
}
