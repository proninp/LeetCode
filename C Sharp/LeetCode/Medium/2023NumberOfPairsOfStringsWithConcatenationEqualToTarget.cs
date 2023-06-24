using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 2023. Number of Pairs of Strings With Concatenation Equal to Target
     * Given an array of digit strings nums and a digit string target,
     * return the number of pairs of indices (i, j)(where i != j)
     * such that the concatenation of nums[i] + nums[j] equals target.
     */
    internal class _2023NumberOfPairsOfStringsWithConcatenationEqualToTarget
    {
        public int NumOfPairs(string[] nums, string target)
        {
            int pairs = 0;
            int tLen = target.Length;
            int len = nums.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int currentLen = nums[i].Length;
                for (int j = i + 1; j < len; j++)
                {
                    if (tLen == (currentLen + nums[j].Length))
                    {
                        if ((nums[i] + nums[j]).Equals(target))
                            pairs++;
                        if ((nums[j] + nums[i]).Equals(target))
                            pairs++;
                    }
                }
            }
            return pairs;
        }
        public int NumOfPairs2(string[] nums, string target)
        {
            int pairs = 0;
            var map = new Dictionary<string, int>(nums.Length);
            foreach(string s in nums)
            {
                if (!map.ContainsKey(s))
                    map.Add(s, 1);
                else
                    map[s]++;
            }
            for (int i = 1; i < target.Length; i++)
            {
                string left = target.Substring(0, i);
                string right = target.Substring(i);
                if (map.ContainsKey(left) && map.ContainsKey(right))
                    pairs += map[left] * (map[right] - (left.Equals(right) ? 1 : 0));
            }
            return pairs;
        }
    }
}
