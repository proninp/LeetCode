using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Medium
{
    /*
     * 1418. Display Table of Food Orders in a Restaurant
     * Given the array orders, which represents the orders that customers have done in a restaurant.
     * More specifically orders[i]=[customerNamei,tableNumberi,foodItemi] where customerNamei is the name of the customer,
     * tableNumberi is the table customer sit at, and foodItemi is the item customer orders.
     * Return the restaurant's “display table”.
     * The “display table” is a table whose row entries denote how many of each food item each table ordered.
     * The first column is the table number and the remaining columns correspond to each food item in alphabetical order.
     * The first row should be a header whose first column is “Table”, followed by the names of the food items.
     * Note that the customer names are not part of the table.
     * Additionally,the rows should be sorted in numerically increasing order.
     */
    public class _1418DisplayTableOfFoodOrdersInARestaurant
    {
        public static IList<IList<string>> DisplayTable(List<List<string>> orders)
        {
            var tablesMap = new SortedDictionary<int, Dictionary<string, int>>();
            var foodSet = new HashSet<string>();
            foreach(var order in orders)
            {
                string item = order.ElementAt(2);
                foodSet.Add(item);
                int table = int.Parse(order.ElementAt(1));
                if (!tablesMap.ContainsKey(table))
                    tablesMap.Add(table, new Dictionary<string, int>());
                if (!tablesMap[table].ContainsKey(item))
                    tablesMap[table].Add(item, 0);
                tablesMap[table][item]++;
            }
            var foods = foodSet.OrderBy(x => x, StringComparer.Ordinal).ToList();
            var ans = new List<IList<string>>();
            ans.Add(new List<string> { "Table" });
            int i = 0;
            foreach(var food in foods)
                ans[i].Add(food);
            foreach(var table in tablesMap)
            {
                i++;
                ans.Add(new List<string>() { table.Key.ToString() });
                foreach(var food in foods)
                {
                    if (table.Value.ContainsKey(food))
                        ans[i].Add(table.Value[food].ToString());
                    else
                        ans[i].Add("0");
                }
            }
            return ans;
        }

    }
}
