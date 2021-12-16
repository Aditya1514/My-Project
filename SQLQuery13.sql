select *from HumanResources.Employee

--selecting bussines entity Id loginId
 select BusinessEntityId,LoginId,JobTitle from HumanResources.Employee where JobTitle='Research and Development Manager';
 select BusinessEntityId,LoginId,JobTitle from HumanResources.Employee where JobTitle<>'Research and Development Manager';

 --selecting middle name
 select *from Person.Person
 select  *from Person.Person where MiddleName like('J%');

 --selecting middle names of j&b
 select FirstName,LastName from Person.Person where MiddleName like  '[j,B]';

 --Extracting from productID,StandardCost using where
  select*from  Production.ProductCostHistory 
  select productID,StandardCost from Production.ProductCostHistory where ModifiedDate='2012-05-29 00:00:00.000';

  --selecting modifies date basis of greater
  select BusinessEntityID, FirstName, MiddleName, LastName, ModifiedDate 
  from Person.Person 
  where ModifiedDate > '2014-12-29';

  select *from [Production].[Product]
    --selecting product id and name starting with chain
    select productID,Name from production.product where Name like('%Chain%');

   -- statring with helmet
    select productID,Name from production.product where Name like('%helmet%');

	select *from  [Sales].[SalesOrderHeader]
	SELECT SalesOrderID, OrderDate, TotalDue 
    FROM Sales.SalesOrderHeader 
    WHERE SubTotal BETWEEN 4000 AND 7000
	 
      
 