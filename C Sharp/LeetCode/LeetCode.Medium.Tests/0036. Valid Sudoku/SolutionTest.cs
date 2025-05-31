using LeetCode.Medium._0036._Valid_Sudoku.src;

namespace LeetCode.Medium.Tests._0036._Valid_Sudoku;

public class SolutionTest
{
    public static IEnumerable<object[]> TestData()
    {
        yield return new object[]
        {
            new char[][]
            {
                ['5', '3', '.', '.', '7', '.', '.', '.', '.'],
                ['6', '.', '.', '1', '9', '5', '.', '.', '.'],
                ['.', '9', '8', '.', '.', '.', '.', '6', '.'],
                ['8', '.', '.', '.', '6', '.', '.', '.', '3'],
                ['4', '.', '.', '8', '.', '3', '.', '.', '1'],
                ['7', '.', '.', '.', '2', '.', '.', '.', '6'],
                ['.', '6', '.', '.', '.', '.', '2', '8', '.'],
                ['.', '.', '.', '4', '1', '9', '.', '.', '5'],
                ['.', '.', '.', '.', '8', '.', '.', '7', '9']
            },
            true
        };
    }
    
    [Theory]
    [MemberData(nameof(TestData))]
    public void BasicTests(char[][] board, bool expected)
    {
        var s = new Solution();
        var actual = s.IsValidSudoku(board);
        Assert.Equal(actual, expected);
    }
}