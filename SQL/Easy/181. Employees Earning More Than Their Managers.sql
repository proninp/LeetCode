/*
 * 181. Employees Earning More Than Their Managers
 * 
 * +-------------+---------+
 * | Column Name | Type    |
 * +-------------+---------+
 * | id          | int     |
 * | name        | varchar |
 * | salary      | int     |
 * | managerId   | int     |
 * +-------------+---------+
 * id is the primary key column for this table.
 * Each row of this table indicates the ID of an employee,
 * their name, salary, and the ID of their manager.
 * Write an SQL query to find the employees who earn more than their managers.
 * Return the result table in any order.
 * The query result format is in the following example.
 */

SELECT e.name Employee
FROM Employee e
LEFT JOIN Employee m ON e.managerId = m.id
WHERE e.salary > m.salary