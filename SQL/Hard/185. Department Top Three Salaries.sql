/*
 * 185. Department Top Three Salaries
 * +--------------+---------+
 * | Column Name  | Type    |
 * +--------------+---------+
 * | id           | int     |
 * | name         | varchar |
 * | salary       | int     |
 * | departmentId | int     |
 * +--------------+---------+
 * id is the primary key column for this table.
 * departmentId is a foreign key of the ID from the Department table.
 * Each row of this table indicates the ID, name, and salary of an employee. It also contains the ID of their department.
 * Table: Department
 * +-------------+---------+
 * | Column Name | Type    |
 * +-------------+---------+
 * | id          | int     |
 * | name        | varchar |
 * +-------------+---------+
 * id is the primary key column for this table.
 * Each row of this table indicates the ID of a department and its name. 
 * A company's executives are interested in seeing who earns the most money in each of the company's departments.
 * A high earner in a department is an employee who has a salary in the top three unique salaries for that department.
 * Write an SQL query to find the employees who are high earners in each of the departments.
 * Return the result table in any order.
 */

SELECT d.name Department
       , q.name Employee
       , salary
FROM (
	SELECT DENSE_RANK() OVER(PARTITION BY departmentId ORDER BY salary DESC) num
			, departmentId
			, name 
			, salary
	FROM Employee) q
LEFT JOIN Department d ON d.id = q.departmentId
WHERE num <= 3