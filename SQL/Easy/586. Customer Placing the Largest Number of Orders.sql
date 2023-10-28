/*
 * 586. Customer Placing the Largest Number of Orders
 * Table: Orders
 * 
 * +-----------------+----------+
 * | Column Name     | Type     |
 * +-----------------+----------+
 * | order_number    | int      |
  * * | customer_number | int      |
 * +-----------------+----------+
 * order_number is the primary key (column with unique values) for this table.
 * This table contains information about the order ID and the customer ID.

 * Write a solution to find the customer_number for the customer who has placed the largest number of orders.
 * The test cases are generated so that exactly one customer will have placed more orders than any other customer.
*/
WITH q AS (SELECT customer_number
           , COUNT(*) orders
           FROM Orders
           GROUP BY customer_number)
SELECT TOP(1) customer_number
FROM q
ORDER BY orders DESC