using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Medium
{
    /*
     * 554. Brick Wall
     * There is a rectangular brick wall in front of you with n rows of bricks.
     * The ith row has some number of bricks each of the same height (i.e., one unit) but they can be of different widths.
     * The total width of each row is the same.
     * Draw a vertical line from the top to the bottom and cross the least bricks.
     * If your line goes through the edge of a brick, then the brick is not considered as crossed.
     * You cannot draw a line just along one of the two vertical edges of the wall, in which case the line will obviously cross no bricks.
     * Given the 2D array wall that contains the information about the wall,
     * return the minimum number of crossed bricks after drawing such a vertical line.
     */
    public class _554BrickWall
    {
        public int LeastBricks(IList<IList<int>> wall)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < wall.Count; i++)
            {
                int position = 0;
                for (int j = 0; j < wall[i].Count - 1; j++)
                {
                    position += wall[i][j];
                    if (!map.ContainsKey(position))
                        map[position] = 1;
                    else
                        map[position]++;
                }
            }
            return wall.Count - (map.Count > 0 ? map.Values.Max() : 0);
        }
    }
}
