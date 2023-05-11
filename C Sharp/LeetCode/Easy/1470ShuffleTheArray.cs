using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1470. Shuffle the Array
     * Given the array nums consisting of 2n elements in the form [x1,x2,...,xn,y1,y2,...,yn].
     * Return the array in the form [x1,y1,x2,y2,...,xn,yn].
     */
    internal class _1470ShuffleTheArray
    {
        public static int[] Shuffle(int[] nums, int n)
        {
            int[] ans = new int[nums.Length];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                ans[j++] = nums[i];
                ans[j++] = nums[i + n];
            }
            return ans;
        }
    }
}
