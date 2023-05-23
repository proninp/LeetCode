using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 496. Next Greater Element I
     * The next greater element of some element x in an array is the first greater element that is to the right of x in the same array.
     * You are given two distinct 0-indexed integer arrays nums1 and nums2, where nums1 is a subset of nums2.
     * For each 0 <= i < nums1.length, find the index j such that nums1[i] == nums2[j] and determine the next greater element
     * of nums2[j] in nums2. If there is no next greater element, then the answer for this query is -1.
     * Return an array ans of length nums1.length such that ans[i] is the next greater element as described above.
     */
    internal class _496_Next_Greater_Element_I
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < nums1.Length; i++)
                map.Add(nums1[i], i);
            int[] ans = new int[nums1.Length];
            for (int i = 0; i < nums2.Length; i++)
            {
                while(stack.Count > 0 && stack.Peek() < nums2[i])
                    ans[map[stack.Pop()]] = nums2[i];
                if (map.ContainsKey(nums2[i]))
                    stack.Push(nums2[i]);
            }
            while (stack.Count > 0)
                ans[map[stack.Pop()]] = -1;
            return ans;
        }
    }
}
