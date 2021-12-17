--case
select * ,grade =
case
when Age<25 then 'A'
when Age=25  then 'B'
when Age>25 then 'C'
end
from EntryListZoo
go
--IFF 
 select *from EntryListZoo
 select Name,Location,Gender,
 IIF(Age<25,'Teenager','Senior')
 as generation
 from EntryListZoo;
 --IIF in boolean
 select IIF (2<3, 'True', 'False');