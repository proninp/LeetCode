using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1534. Count Good Triplets
     * Given an array of integers arr, and three integers a, b and c. You need to find the number of good triplets.
     * A triplet (arr[i], arr[j], arr[k]) is good if the following conditions are true:
     * 0 <= i < j < k < arr.length
     * |arr[i] - arr[j]| <= a
     * |arr[j] - arr[k]| <= b
     * |arr[i] - arr[k]| <= c
     * Where |x| denotes the absolute value of x.
     * Return the number of good triplets.
     */
    public class _1534CountGoodTriplets
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    for (int k = j + 1; k < n; k++)
                    {
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            count++;
                    }
                }
            }
            return count;
        }
    }
}
