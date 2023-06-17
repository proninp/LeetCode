/*
 * 1174. Immediate Food Delivery II
 * Table: Delivery
 * +-----------------------------+---------+
 * | Column Name                 | Type    |
 * +-----------------------------+---------+
 * | delivery_id                 | int     |
 * | customer_id                 | int     |
 * | order_date                  | date    |
 * | customer_pref_delivery_date | date    |
 * +-----------------------------+---------+
 * delivery_id is the primary key of this table.
 * The table holds information about food delivery to customers that make orders at
 * some date and specify a preferred delivery date (on the same order date or after it).
 * If the customer's preferred delivery date is the same as the order date, then the order is called immediate;
 * otherwise, it is called scheduled.
 * The first order of a customer is the order with the earliest order date that the customer made.
 * It is guaranteed that a customer has precisely one first order.
 * Write an SQL query to find the percentage of immediate orders in the first orders of all customers,
 * rounded to 2 decimal places.
 */
SELECT ROUND(AVG([delivery_type] * 100.0), 2) [immediate_percentage]
FROM (
  SELECT customer_id
        , IIF(order_date = customer_pref_delivery_date, 1, 0) [delivery_type]
        , ROW_NUMBER() OVER(PARTITION BY customer_id ORDER BY order_date) [id]
  FROM Delivery d) sub
WHERE [id] = 1