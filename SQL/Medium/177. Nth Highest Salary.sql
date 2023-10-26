/*
 * 177. Nth Highest Salary
 * 
 * Table: Employee
 * 
 * +-------------+------+
 * | Column Name | Type |
 * +-------------+------+
 * | id          | int  |
 * | salary      | int  |
 * +-------------+------+
 * id is the primary key (column with unique values) for this table.
 * Each row of this table contains information about the salary of an employee.
 * 
 * Write a solution to find the nth highest salary from the Employee table. If there is no nth highest salary, return null.
 */
CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    RETURN (
        SELECT TOP 1 salary
        FROM (
            SELECT DENSE_RANK() OVER(ORDER BY salary DESC) salaryRank
            , salary
            FROM Employee
        ) sub
        WHERE salaryRank = @N
    );
END;