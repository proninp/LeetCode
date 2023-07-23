/* 
 * 1907. Count Salary Categories
 * Table: Accounts
 * +-------------+------+
 * | Column Name | Type |
 * +-------------+------+
 * | account_id  | int  |
 * | income      | int  |
 * +-------------+------+
 * In SQL, account_id is the primary key for this table.
 * Each row contains information about the monthly income for one bank account. 
 * Calculate the number of bank accounts of each salary category. The salary categories are:

 * "Low Salary": All the salaries strictly less than $20000.
 * "Average Salary": All the salaries in the inclusive range [$20000, $50000].
 * "High Salary": All the salaries strictly greater than $50000.
 * The result table must contain all three categories.
 * If there are no accounts in a category, return 0.

 * Return the result table in any order.
 * The result format is in the following example.
*/
SELECT 'Low Salary' category,
       SUM(IIF(income < 20000, 1, 0)) accounts_count
FROM Accounts
UNION ALL
SELECT 'Average Salary',
       SUM(IIF(income < 20000 OR income > 50000, 0, 1))
FROM Accounts
UNION ALL
SELECT 'High Salary'
       , SUM(IIF(income > 50000, 1, 0))
FROM Accounts