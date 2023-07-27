/*
 * 1321. Restaurant Growth
 * Table: Customer
 * +---------------+---------+
 * | Column Name   | Type    |
 * +---------------+---------+
 * | customer_id   | int     |
 * | name          | varchar |
 * | visited_on    | date    |
 * | amount        | int     |
 * +---------------+---------+
 * (customer_id, visited_on) is the primary key for this table.
 * This table contains data about customer transactions in a restaurant.
 * visited_on is the date on which the customer with ID (customer_id) has visited the restaurant.
 * amount is the total paid by a customer.
 * You are the restaurant owner and you want to analyze a possible expansion (there will be at least one customer every day).
 * Write an SQL query to compute the moving average of how much the customer paid
 * in a seven days window (i.e., current day + 6 days before). average_amount should be rounded to two decimal places.
 * Return result table ordered by visited_on in ascending order.
 */
WITH q AS (
       SELECT visited_on
              , SUM(amount) * 1.00 AS total
       FROM Customer
       GROUP BY visited_on
),
qq AS (
       SELECT *, 
       ROW_NUMBER() OVER(ORDER BY visited_on) n,
       ROUND(SUM(total) OVER(ORDER BY visited_on ROWS BETWEEN 6 PRECEDING AND CURRENT ROW) ,2) amount,
       ROUND(AVG(total) OVER(ORDER BY visited_on ROWS BETWEEN 6 PRECEDING AND CURRENT ROW) ,2) average_amount
       FROM q
)
SELECT Visited_on
       , amount
       , average_amount
FROM qq
WHERE n >= 7