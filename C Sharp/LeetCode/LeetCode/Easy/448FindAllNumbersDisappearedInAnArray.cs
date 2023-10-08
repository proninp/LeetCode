using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 448. Find All Numbers Disappeared in an Array
     * Given an array nums of n integers where nums[i] is in the range [1, n],
     * return an array of all the integers in the range [1, n] that do not appear in nums.
     */
    internal class _448FindAllNumbersDisappearedInAnArray
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            int len = nums.Length;
            int ind = 0;
            List<int> ans = new List<int>();
            for (int i = 0; i < len; i++)
            {
                ind = Math.Abs(nums[i]) - 1;
                nums[ind] = Math.Abs(nums[ind]) * -1;
            }
            for (int i = 0; i < len; i++)
                if (nums[i] > 0)
                    ans.Add(i + 1);
            return ans;
        }
    }
}
