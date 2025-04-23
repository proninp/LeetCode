SELECT ui.unique_id
    , e.name
FROM Employees e
LEFT JOIN EmployeeUNI ui ON e.id = ui.id