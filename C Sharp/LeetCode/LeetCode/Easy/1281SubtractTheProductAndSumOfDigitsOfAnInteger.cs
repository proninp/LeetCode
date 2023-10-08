namespace LeetCode.Easy
{
    /*
     * 1281. Subtract the Product and Sum of Digits of an Integer
     * Given an integer number n, return the difference between the product of its digits and the sum of its digits.
     */
    internal class _1281SubtractTheProductAndSumOfDigitsOfAnInteger
    {
        public int SubtractProductAndSum(int n)
        {
            int sum = 0;
            int mult = 1;
            int temp;
            while (n != 0)
            {
                temp = n % 10;
                n /= 10;
                sum += temp;
                mult *= temp;
            }
            return mult - sum;
        }
    }
}
