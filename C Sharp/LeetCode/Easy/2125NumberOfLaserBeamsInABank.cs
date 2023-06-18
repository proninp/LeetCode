using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2125. Number of Laser Beams in a Bank
     * Anti-theft security devices are activated inside a bank.
     * You are given a 0-indexed binary string array bank representing the floor plan of the bank,
     * which is an m x n 2D matrix. bank[i] represents the ith row, consisting of '0's and '1's.
     * '0' means the cell is empty, while'1' means the cell has a security device.
     * There is one laser beam between any two security devices if both conditions are met:
     * The two devices are located on two different rows: r1 and r2, where r1 < r2.
     * For each row i where r1 < i < r2, there are no security devices in the ith row.
     * Laser beams are independent, i.e., one beam does not interfere nor join with another.
     * Return the total number of laser beams in the bank.
     */
    internal class _2125NumberOfLaserBeamsInABank
    {
        public int NumberOfBeams(string[] bank)
        {
            int beams = 0;
            int prev = 0;
            foreach (var line in bank)
            {
                int curr = 0;
                foreach (var cell in line)
                {
                    if (cell == '1')
                        curr++;
                }
                if (curr != 0)
                {
                    beams += curr * prev;
                    prev = curr;
                }
                    
            }
            return beams;
        }
    }
}
