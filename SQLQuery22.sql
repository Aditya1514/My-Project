select *from employee

select *from department
select *from employee1
--procedure with innerjoin
create procedure employeePlace2
as 
select employee.e_id,employee.e_name,employee.e_salary,employee.e_dept,department.d_d,department.d_location from employee
inner join department
on employee.e_dept=department.d_d
go
exec employeePlace2;

--sorting Data
select *from  Person.Person
 select  distinct BusinessEntityID ,LastName,MiddleName,FirstName
 from Person.Person
 order by LastName DESC,MiddleName DESC,FirstName DESC;
