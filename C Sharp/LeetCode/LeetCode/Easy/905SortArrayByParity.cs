namespace LeetCode.Easy
{
    /*
     * 905. Sort Array By Parity
     * Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
     * Return any array that satisfies this condition.
     */
    public class _905SortArrayByParity
    {
        public int[] SortArrayByParity(int[] nums)
        {
            int l = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] % 2 == 0)
                {
                    (nums[l], nums[r]) = (nums[r], nums[l]);
                    l++;
                }
            }
            return nums;
        }
    }
}
