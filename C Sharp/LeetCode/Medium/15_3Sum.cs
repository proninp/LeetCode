using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    /*
     * 15. 3Sum
     * 
     * Given an integer array nums, return all the triplets [nums[i], nums[j],
     * nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.
     * Notice that the solution set must not contain duplicate triplets.
     */
    public class _15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var output = new List<IList<int>>();
            int l, r, threeSum;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                l = i + 1;
                r = nums.Length - 1;
                while(l < r)
                {
                    threeSum = nums[l] + nums[r] + nums[i];
                    if (threeSum > 0)
                        r--;
                    else if (threeSum < 0)
                        l++;
                    else
                    {
                        output.Add(new List<int>() { nums[i], nums[l], nums[r] });
                        l++;
                        while (nums[l] == nums[l - 1] && l < r)
                            l++;
                    }
                }
            }
            return output;
        }
    }
}
