namespace LeetCode.Easy
{
    /*
     * 338. Counting Bits
     * Given an integer n, return an array ans of length n + 1 such that for each i (0 <= i <= n),
     * ans[i] is the number of 1's in the binary representation of i.
     */
    public class _338CountingBits
    {
        public int[] CountBits(int n)
        {
            int[] bits = new int[n + 1];
            for (int i = 1; i <= n; i++)
                bits[i] = bits[i & (i - 1)] + 1;
            return bits;
        }
    }
}
