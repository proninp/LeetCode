namespace LeetCode.Easy
{
    /*
     * 283. Move Zeroes
     * Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
     * Note that you must do this in-place without making a copy of the array.
     */
    public class _283MoveZeroes
    {
        public void MoveZeroes(int[] nums)
        {
            int l = 0;
            for (int r = 0; r < nums.Length; r++)
            {
                if (nums[r] != 0)
                {
                    (nums[l], nums[r]) = (nums[r], nums[l]);
                    l++;
                }
            }
        }
    }
}
