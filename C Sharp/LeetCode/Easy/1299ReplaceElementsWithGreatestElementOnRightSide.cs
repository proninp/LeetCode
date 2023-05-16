using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    internal class _1299ReplaceElementsWithGreatestElementOnRightSide
    {
        /*
         * 1299. Replace Elements with Greatest Element on Right Side
         * Given an array arr, replace every element in that array with the greatest element
         * among the elements to its right, and replace the last element with -1.
         * After doing so, return the array.
         */
        public static int[] ReplaceElements(int[] arr)
        {
            int rightMax = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int tmp = arr[i];
                arr[i] = rightMax;
                if (tmp > rightMax)
                    rightMax = tmp;
            }
            return arr;
        }
    }
}
