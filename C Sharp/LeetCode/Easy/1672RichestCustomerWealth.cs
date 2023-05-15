using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    /*
     * 1672. Richest Customer Wealth
     * You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank.
     * Return the wealth that the richest customer has.
     * A customer's wealth is the amount of money they have in all their bank accounts.
     * The richest customer is the customer that has the maximum wealth.
     */
    internal class _1672RichestCustomerWealth
    {
        public int MaximumWealth(int[][] accounts) => accounts.Select(x => x.Sum()).Max();
    }
}
