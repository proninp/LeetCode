namespace LeetCode.Easy
{
    /*
     * 1822. Sign of the Product of an Array
     * 
     * There is a function signFunc(x) that returns:
     * 1 if x is positive.
     * -1 if x is negative.
     * 0 if x is equal to 0.
     * You are given an integer array nums. Let product be the product of all values in the array nums.
     * Return signFunc(product).
     */
    public class _1822SignOfTheProductOfAnArray
    {
        public int ArraySign(int[] nums)
        {
            int lz = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                    lz++;
                else if (nums[i] == 0)
                    return 0;
            }
            return lz % 2 != 0 ? -1 : 1;
        }
    }
}
