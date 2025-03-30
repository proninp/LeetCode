namespace LeetCode.Easy._0118._Pascal_s_Triangle.src;

public sealed class Solution
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var result = new int[numRows][];
        for (int i = 0; i < numRows; i++)
        {
            result[i] = new int[i + 1];
            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i)
                {
                    result[i][j] = 1;
                }
                else
                {
                    result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
                }
            }
        }
        return result;
    }
}