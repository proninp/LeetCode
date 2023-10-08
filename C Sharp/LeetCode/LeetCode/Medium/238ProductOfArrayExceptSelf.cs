using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 238. Product of Array Except Self
     * Given an integer array nums, return an array answer such that answer[i] is equal to the product of all the elements of nums except nums[i].
     * The product of any prefix or suffix of nums is guaranteed to fit in a 32-bit integer.
     * You must write an algorithm that runs in O(n) time and without using the division operation.
     */
    internal class _238ProductOfArrayExceptSelf
    {
        public int[] ProductExceptSelf2(int[] nums)
        {
            int len = nums.Length;
            var result = new int[len];
            var prev = 1;
            for (int i = 0; i < len; i++)
            {
                result[i] = prev;
                prev *= nums[i];
            }
            prev = 1;
            for (int i = len - 1; i >= 0; i--)
            {
                result[i] *= prev;
                prev *= nums[i];
            }
            return result;
        }
        public int[] ProductExceptSelf1(int[] nums)
        {
            int len = nums.Length;
            var prefix = new int[len];
            var postfix = new int[len];
            var result = new int[len];
            var prev = 1;
            int next;
            for (int i = 0; i < len; i++)
            {
                prefix[i] = prev * nums[i];
                prev = prefix[i];
            }
            prev = 1;
            for (int i = len - 1; i >= 0; i--)
            {
                postfix[i] = prev * nums[i];
                prev = postfix[i];
            }
            prev = 1;
            for (int i = 0; i < len; i++)
            {
                if (i < len - 1)
                    next = postfix[i + 1];
                else
                    next = 1;
                result[i] = prev * next;
                prev = prefix[i];
            }
            return result;
        }
    }
}
