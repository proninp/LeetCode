using System.Linq;

namespace LeetCode.Easy
{
    /*
     * 2652. Sum Multiples
     * Given a positive integer n, find the sum of all integers in the range [1, n] inclusive that are divisible by 3, 5, or 7.
     * Return an integer denoting the sum of all numbers in the given range satisfying the constraint.
     */
    public class _2652SumMultiples
    {
        public int SumOfMultiples(int n) =>
            (n < 3) ? 0 : Enumerable.Range(3, n - 2).Where(x => x % 3 == 0 || x % 5 == 0 || x % 7 == 0).Sum();
    }
}
