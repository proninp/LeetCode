/*
 * 1179. Reformat Department Table
 * Table: Department
 * 
 * +-------------+---------+
 * | Column Name | Type    |
 * +-------------+---------+
 * | id          | int     |
 * | revenue     | int     |
 * | month       | varchar |
 * +-------------+---------+
 * In SQL,(id, month) is the primary key of this table.
 * The table has information about the revenue of each department per month.
 * The month has values in ["Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"].
 *  
 * Reformat the table such that there is a department id column and a revenue column for each month.
 * 
 * Return the result table in any order.
 */
SELECT DISTINCT id
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Jan') Jan_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Feb') Feb_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Mar') Mar_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Apr') Apr_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'May') May_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Jun') Jun_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Jul') Jul_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Aug') Aug_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Sep') Sep_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Oct') Oct_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Nov') Nov_Revenue
       , (SELECT SUM(revenue) FROM Department WHERE id = d.id AND [month] = 'Dec') Dec_Revenue
FROM Department d