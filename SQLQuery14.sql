select *from Production.ProductReview

select ProductID,EmailAddress from Production.ProductReview
where Rating =5;

--order by
select *from Person.Person

select BusinessEntityID,MiddleName,LastName,FirstName from Person.Person
order by BusinessEntityID desc;

select BusinessEntityID,MiddleName,LastName,FirstName from Person.Person
order by LastName desc,FirstName desc;

--Showing LastName using where clause
use AdventureWorks2019
go 
SELECT LastName 
FROM Person.Person 
WHERE LastName = 'Smith'; 

--InnerJoin
SELECT JobTitle, BirthDate, FirstName, LastName 
FROM HumanResources.Employee AS E 
INNER JOIN Person.Person as P ON E.BusinessEntityID = P.BusinessEntityID; 

select ReviewerName,EmailAddress from Production.ProductReview as P
inner join HumanResources.Employee AS E 
on P.ProductReviewID=E.BusinessEntityID

select *from Production.Product
select *from Sales.SalesOrderDetail
--writing subqueries
SELECT ProductID, Name 
FROM Production.Product 
WHERE ProductID IN (SELECT ProductID FROM Sales.SalesOrderDetail); 



select *from HumanResources.Employee

SELECT a.EmployeeID AS Employee 
 a.Title AS EmployeeTitle, 
 b.EmployeeID AS ManagerID, 
 b.Title AS ManagerTitle, 
 c.FirstName, c.MiddleName, c.LastName 
FROM HumanResources.Employee AS a 
LEFT OUTER JOIN HumanResources.Employee AS b 
ON a.ManagerID = b.EmployeeID 
LEFT OUTER JOIN Person.Contact AS c ON a.EmployeeID = c.ContactID;