namespace LeetCode.Easy
{
    /*
     * 2535. Difference Between Element Sum and Digit Sum of an Array
     * You are given a positive integer array nums.
     * The element sum is the sum of all the elements in nums.
     * The digit sum is the sum of all the digits (not necessarily distinct) that appear in nums.
     * Return the absolute difference between the element sum and digit sum of nums.
     * Note that the absolute difference between two integers x and y is defined as |x - y|.
     */
    public class _2535DifferenceBetweenElementSumAndDigitSumOfAnArray
    {
        public int DifferenceOfSum(int[] nums)
        {
            var differenceOfSum = 0;

            foreach (var num in nums)
            {
                if (num > 9)
                {
                    differenceOfSum += num;

                    int allDigit = num;
                    while (allDigit > 0)
                    {
                        differenceOfSum -= allDigit % 10;
                        allDigit /= 10;
                    }
                }
            }

            return differenceOfSum;
        }
    }
}
