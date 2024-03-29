/*
 * 1527. Patients With a Condition
 * Table: Patients
 * +--------------+---------+
 * | Column Name  | Type    |
 * +--------------+---------+
 * | patient_id   | int     |
 * | patient_name | varchar |
 * | conditions   | varchar |
 * +--------------+---------+
 * In SQL, patient_id is the primary key for this table.
 * 'conditions' contains 0 or more code separated by spaces. 
 * This table contains information of the patients in the hospital.
 * Find the patient_id, patient_name and conditions of the patients who have Type I Diabetes.
 * Type I Diabetes always starts with DIAB1 prefix.
 * Return the result table in any order.
 */
SELECT patient_id
       , patient_name
       , conditions
FROM Patients
WHERE conditions LIKE 'DIAB1%' OR conditions LIKE '% DIAB1%'