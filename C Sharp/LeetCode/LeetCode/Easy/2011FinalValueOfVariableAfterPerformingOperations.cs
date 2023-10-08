using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 2011. Final Value of Variable After Performing Operations
     * There is a programming language with only four operations and one variable X:
     * ++X and X++ increments the value of the variable X by 1.
     * --X and X-- decrements the value of the variable X by 1.
     * Initially, the value of X is 0.
     * Given an array of strings operations containing a list of operations, return the final value of X after performing all the operations
     */
    internal class _2011FinalValueOfVariableAfterPerformingOperations
    {
        public static int FinalValueAfterOperations(string[] operations)
        {
            int res = 0;
            foreach (string operation in operations)
                res += (operation[1] == '+') ? 1 : -1; 
            return res;
        }
    }
}
