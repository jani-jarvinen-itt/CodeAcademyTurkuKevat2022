-- Harjoitus 1.a
SELECT *
FROM Customers
WHERE Country = 'Finland'

-- Harjoitus 1.b
SELECT *
FROM Orders
WHERE CustomerID = (SELECT CustomerID
					FROM Customers
					WHERE CompanyName = 'Que Del�cia')

-- Harjoitus 1.c
SELECT *
FROM Employees
WHERE City = 'London'
