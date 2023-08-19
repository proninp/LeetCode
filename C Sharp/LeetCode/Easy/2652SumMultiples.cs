﻿namespace LeetCode.Easy
{
    /*
     * 2652. Sum Multiples
     * Given a positive integer n, find the sum of all integers in the range [1, n] inclusive that are divisible by 3, 5, or 7.
     * Return an integer denoting the sum of all numbers in the given range satisfying the constraint.
     */
    internal class _2652SumMultiples
    {
        public int SumOfMultiples(int n)
        {
            int sum = 0;
            for (int i = 3; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                    sum += i;
            }
            return sum;
        }
    }
}
