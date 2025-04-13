namespace LeetCode.Easy._0303._Range_Sum_Query___Immutable.src;

public class NumArray
{
    private readonly int[] _prefixSum;

    public NumArray(int[] nums)
    {
        _prefixSum = new int[nums.Length + 1];
        for (int i = 1; i < _prefixSum.Length; i++)
        {
            _prefixSum[i] = _prefixSum[i - 1] + nums[i - 1];
        }
    }

    public int SumRange(int left, int right)
    {
        return _prefixSum[right + 1] - _prefixSum[left];
    }
}

