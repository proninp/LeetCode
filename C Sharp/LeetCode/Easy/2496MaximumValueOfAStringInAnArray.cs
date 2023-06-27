using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2496. Maximum Value of a String in an Array
     * The value of an alphanumeric string can be defined as:
     * The numeric representation of the string in base 10, if it comprises of digits only.
     * The length of the string, otherwise.
     * Given an array strs of alphanumeric strings, return the maximum value of any string in strs.
     */
    internal class _2496MaximumValueOfAStringInAnArray
    {
        public int MaximumValue(string[] strs)
        {
            int max = 0;
            foreach(string str in strs)
            {
                if (!int.TryParse(str, out int val))
                    val = str.Length;
                if (val > max)
                    max = val;
            }
            return max;

        }
    }
}
