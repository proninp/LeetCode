﻿namespace LeetCode.Medium
{
    /*
     * 1476. Subrectangle Queries
     * Implement the class SubrectangleQueries which receives a rows x cols rectangle as a matrix of integers in the constructor and supports two methods:
     * 1. updateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
     * Updates all values with newValue in the subrectangle whose upper left coordinate is (row1,col1) and bottom right coordinate is (row2,col2).
     * 2. getValue(int row, int col)
     * Returns the current value of the coordinate (row,col) from the rectangle.
     */
    internal class _1476SubrectangleQueries
    {

    }
    public class SubrectangleQueries
    {
        private int[][] _rectangle;

        public SubrectangleQueries(int[][] rectangle)
        {
            _rectangle = rectangle;
        }

        public void UpdateSubrectangle(int row1, int col1, int row2, int col2, int newValue)
        {
            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                    _rectangle[i][j] = newValue;
            }
        }

        public int GetValue(int row, int col) => _rectangle[row][col];
    }
}
