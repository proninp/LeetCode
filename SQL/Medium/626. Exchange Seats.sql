/*
 * 626. Exchange Seats
 * Table: Seat
 * +-------------+---------+
 * | Column Name | Type    |
 * +-------------+---------+
 * | id          | int     |
 * | student     | varchar |
 * +-------------+---------+
 * id is the primary key column for this table.
 * Each row of this table indicates the name and the ID of a student.
 * id is a continuous increment.
 * Write an SQL query to swap the seat id of every two consecutive students.
 * If the number of students is odd, the id of the last student is not swapped.
 * Return the result table ordered by id in ascending order.
 */
SELECT id
    , IIF(id % 2 = 0, prevId, COALESCE(nextId, student)) student
FROM
(
    SELECT id
           , student
           , LAG(student) OVER (ORDER BY id) AS prevId
           , LEAD(student) OVER (ORDER BY id) AS nextId
    FROM Seat
) s