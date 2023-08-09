namespace LeetCode.Easy
{
    /*
     * 2413. Smallest Even Multiple
     * Given a positive integer n, return the smallest positive integer that is a multiple of both 2 and n.
     */
    internal class _2413SmallestEvenMultiple
    {
        public int SmallestEvenMultiple(int n) => (n % 2 == 0) ? n : n * 2;
    }
}