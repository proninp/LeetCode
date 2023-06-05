using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 912. Sort an Array
     * Given an array of integers nums, sort the array in ascending order and return it.
     * You must solve the problem without using any built-in functions in O(nlog(n))
     * time complexity and with the smallest space complexity possible.
     */
    public class _912SortAnArray
    {
        public static int[] SortArray(int[] nums)
        {
            return SortArray(nums, 0, nums.Length - 1);
        }
        public static int[] SortArray(int[] arr, int l, int r)
        {
            if (l == r)
                return arr;
            int m = (l + r) / 2;
            SortArray(arr, l, m);
            SortArray(arr, m + 1, r);
            MergeSort(arr, l, m, r);
            return arr;
        }
        public static int[] MergeSort(int[] arr, int l, int m, int r)
        {
            int pL = 0;
            int pR = 0;
            int i = l;
            int[] left = new int[m - l + 1];
            int[] right = new int[r - m];
            Array.Copy(arr, l, left, 0, left.Length);
            Array.Copy(arr, m + 1, right, 0, right.Length);


            while (pL < left.Length && pR < right.Length)
            {
                if (left[pL] < right[pR])
                    arr[i++] = left[pL++];
                else
                    arr[i++] = right[pR++];
            }
            while (pL < left.Length)
                arr[i++] = left[pL++];
            while (pR < right.Length)
                arr[i++] = right[pR++];

            return arr;
        }
    }
}
