/*
 * 197. Rising Temperature
 * Table: Weather

 * +---------------+---------+
 * | Column Name   | Type    |
 * +---------------+---------+
 * | id            | int     |
 * | recordDate    | date    |
 * | temperature   | int     |
 * +---------------+---------+
 * id is the primary key for this table.
 * This table contains information about the temperature on a certain day.
 
 * Write an SQL query to find all dates' Id with higher temperatures compared to its previous dates (yesterday).
 * Return the result table in any order.
 */
SELECT n.id 
FROM Weather n
JOIN Weather y ON n.recordDate = DATEADD(dd, 1, y.recordDate) AND n.temperature > y.temperature