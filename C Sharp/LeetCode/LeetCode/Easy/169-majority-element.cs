using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 169. Majority Element
     * Given an array nums of size n, return the majority element.
     * The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.
     */
    internal class _169_majority_element
    {
        public static int MajorityElement1(int[] nums)
        {
            int max = int.MinValue;
            int majority = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else
                    map.Add(nums[i], 1);
                if (map[nums[i]] > max)
                {
                    max = map[nums[i]];
                    majority = nums[i];
                }
            }
            return majority;
        }
        public static int MajorityElementBoyerMoore(int[] nums) // Follow-up: Could you solve the problem in linear time and in O(1) space?
        {
            int majCount = 0;
            int majority = 0;
            foreach(int i in nums)
            {
                if (majCount == 0)
                    majority = i;
                majCount += (majority != i) ? -1 : 1;
            }
            return majority;
        }
    }
}
