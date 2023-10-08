namespace LeetCode.Easy
{
    /*
     * 1486. XOR Operation in an Array
     * You are given an integer n and an integer start.
     * Define an array nums where nums[i] = start + 2 * i (0-indexed) and n == nums.length.
     * Return the bitwise XOR of all elements of nums.
     */
    internal class _1486XOROperationInAnArray
    {
        public int XorOperation(int n, int start)
        {
            int[] nums = new int[n];
            nums[0] = start;
            for (int i = 1; i < n; i++)
            {
                nums[i] = start + 2 * i;
                nums[0] ^= nums[i];
            }
            return nums[0];
        }
    }
}
