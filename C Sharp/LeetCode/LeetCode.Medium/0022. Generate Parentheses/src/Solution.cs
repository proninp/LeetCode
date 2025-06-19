namespace LeetCode.Medium._0022._Generate_Parentheses.src;

public class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        GenerateRecursive(n - 1, n, "(", result);
        return result;
    }

    private void GenerateRecursive(int openedRemain, int closedRemain, string s, IList<string> result)
    {
        if (openedRemain == 0 && closedRemain == 0)
            result.Add(s);
        else
        {
            if (openedRemain > 0)
                GenerateRecursive(openedRemain - 1, closedRemain, s + "(", result);
            if (openedRemain < closedRemain)
                GenerateRecursive(openedRemain, closedRemain - 1, s + ")", result);
        }
    }
}