namespace LeetCode.Medium._0074._Search_a_2D_Matrix.src;

public class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        foreach (var matrixRow in matrix)
        {
            if (target > matrixRow[matrixRow.Length - 1]) continue;
            
            int left = 0, right = matrixRow.Length - 1;
            while (left <= right)
            {
                var mid = left + (right - left) / 2;
                if (matrixRow[mid] < target)
                {
                    left = mid + 1;
                }
                else if (matrixRow[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    return true;
                }
            }
        }
        return false;
    }
}