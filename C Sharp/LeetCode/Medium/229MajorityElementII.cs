using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /*
     * 229. Majority Element II
     * 
     * Given an integer array of size n, find all elements that appear more than n/3 times.
     * Constraints:
     * 1 <= nums.length <= 5 * 10^4
     * -10^9 <= nums[i] <= 10^9
     */
    public class _229MajorityElementII
    {
        public IList<int> MajorityElement(int[] nums)
        {
            int len = nums.Length;
            if (len == 1)
                return nums;
            var output = new List<int>();
            int frequency = len / 3;
            Array.Sort(nums);
            int elementFrequency = 1;
            for (int i = 1; i < len; i++)
            {
                if (nums[i] == nums[i - 1])
                    elementFrequency++;
                else
                {
                    if (elementFrequency > frequency)
                        output.Add(nums[i - 1]);
                    elementFrequency = 1;
                }
            }
            if (elementFrequency > frequency)
                output.Add(nums[nums.Length - 1]);
            return output;
        }
        public IList<int> MajorityElement2(int[] nums)
        {
            int len = nums.Length;
            if (len == 1)
                return nums;
            var output = new List<int>();
            int frequency = len / 3;
            var map = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (!map.ContainsKey(n))
                    map.Add(n, 1);
                else
                    map[n]++;
            }
            foreach (var pair in map)
            {
                if (pair.Value > frequency)
                    output.Add(pair.Key);
            }
            return output;

        }
    }
}
