namespace LeetCode.Easy._0448._Find_All_Numbers_Disappeared_in_an_Array.src;

public sealed class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var existsArray = new bool[nums.Length];
        foreach (var e in nums)
            existsArray[e - 1] = true;

        var result = new List<int>();
        for (int i = 0; i < existsArray.Length; i++)
            if (!existsArray[i])
                result.Add(i + 1);
        return result;
    }
}