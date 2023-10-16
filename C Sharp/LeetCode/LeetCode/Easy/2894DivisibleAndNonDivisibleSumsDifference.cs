namespace LeetCode.Easy
{
    public class _2894DivisibleAndNonDivisibleSumsDifference
    {
        /*
         * 2894. Divisible and Non-divisible Sums Difference
         * 
         * You are given positive integers n and m.
         * Define two integers, num1 and num2, as follows:
         * num1: The sum of all integers in the range [1, n] that are not divisible by m.
         * num2: The sum of all integers in the range [1, n] that are divisible by m.
         * Return the integer num1 - num2.
         * 
         * Constraints:
         * 1 <= n, m <= 1000
         */
        public int DifferenceOfSums(int n, int m)
        {
            int n1 = 0, n2 = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % m != 0)
                    n1 += i;
                else
                    n2 += i;
            }
            return n1 - n2;
        }
    }
}
