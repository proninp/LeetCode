/*
 * 550. Game Play Analysis IV
 * Table: Activity
 * +--------------+---------+
 * | Column Name  | Type    |
 * +--------------+---------+
 * | player_id    | int     |
 * | device_id    | int     |
 * | event_date   | date    |
 * | games_played | int     |
 * +--------------+---------+
 * (player_id, event_date) is the primary key of this table.
 * This table shows the activity of players of some games.
 * Each row is a record of a player who logged in and played a number of games (possibly 0)
 * before logging out on someday using some device.
 * Write an SQL query to report the fraction of players that logged in again
 * on the day after the day they first logged in, rounded to 2 decimal places.
 * In other words, you need to count the number of players that logged in for at least two consecutive days
 * starting from their first login date, then divide that number by the total number of players.
 */
WITH fl AS (
  SELECT player_id
        , MIN(event_date) first_login
  FROM Activity al
  GROUP BY player_id
)
SELECT ROUND(COUNT(a.player_id) * 1.0 / (SELECT COUNT(DISTINCT player_id) FROM Activity), 2) fraction
FROM Activity a
JOIN fl ON a.player_id = fl.player_id AND DATEDIFF(day, fl.first_login, a.event_date) = 1