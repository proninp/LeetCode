/*
 * 1978. Employees Whose Manager Left the Company
 * Table: Employees
 * +-------------+----------+
 * | Column Name | Type     |
 * +-------------+----------+
 * | employee_id | int      |
 * | name        | varchar  |
 * | manager_id  | int      |
 * | salary      | int      |
 * +-------------+----------+
 * employee_id is the primary key for this table.
 * This table contains information about the employees, their salary,
 * and the ID of their manager.
 * Some employees do not have a manager (manager_id is null). 
 * Write an SQL query to report the IDs of the employees whose salary is strictly less
 * than $30000 and whose manager left the company.
 * When a manager leaves the company, their information is deleted from the Employees table,
 * but the reports still have their manager_id set to the manager that left.
 * Return the result table ordered by employee_id.
 */

-- Solution 1:
SELECT e.employee_id
FROM Employees e
WHERE e.salary < 30000 AND
      e.manager_id NOT IN 
      (SELECT employee_id
       FROM Employees)
ORDER BY 1

-- Solution 2:
SELECT e1.employee_id
FROM Employees e1
LEFT JOIN Employees e2 ON e1.manager_id = e2.employee_id
WHERE e1.salary < 30000 AND e1.manager_id IS NOT NULL AND e2.employee_id IS NULL
ORDER BY 1