namespace LeetCode.Easy
{
    /*
     * 1480. Running Sum of 1d Array
     * Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
     * Return the running sum of nums.
     */
    internal class _1480RunningSumOf1dArray
    {
        public int[] RunningSum(int[] nums)
        {
            var output = new int[nums.Length];
            output[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
                output[i] += nums[i] + output[i - 1];
            return output;
        }
    }
}
