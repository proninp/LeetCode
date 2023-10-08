namespace LeetCode.Easy
{
    /*
     * 896. Monotonic Array
     * 
     * An array is monotonic if it is either monotone increasing or monotone decreasing.
     * An array nums is monotone increasing if for all i <= j, nums[i] <= nums[j].
     * An array nums is monotone decreasing if for all i <= j, nums[i] >= nums[j].
     * Given an integer array nums, return true if the given array is monotonic, or false otherwise.
     */
    public class _896MonotonicArray
    {
        public bool IsMonotonic(int[] nums)
        {
            bool isDecr = true, isIncr = true;
            int prev = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > prev)
                    isDecr = false;
                if (nums[i] < prev)
                    isIncr = false;
                if (!isDecr && !isIncr)
                    return false;
                prev = nums[i];
            }
            return true;
        }
    }
}
