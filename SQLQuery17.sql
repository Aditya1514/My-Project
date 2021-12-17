select *from EntryListZoo
select *from ZooAnimalList

--InnerJoin
 select EntryListZoo.Sno,EntryListZoo.Name,EntryListZoo.Location,
 ZooAnimalList.Sno,ZooAnimalList.AnimalName,ZooAnimalList.Category
 from EntryListZoo
 Inner jOin ZooAnimalList
 on EntryListZoo.Sno=ZooAnimalList.Sno;

 select EntryListZoo.Name,EntryListZoo.Location,ZooAnimalList.AnimalName,ZooAnimalList.Category
 from EntryListZoo
  inner join ZooAnimalList
 on EntryListZoo.Sno=ZooAnimalList.Sno;

  --Full outer join
   select EntryListZoo.Name,EntryListZoo.Location,ZooAnimalList.AnimalName,ZooAnimalList.Category
   from EntryListZoo
   full outer join ZooAnimalList
   on EntryListZoo.Sno=ZooAnimalList.Sno;

 --creating a view
   create view view1 as
   select Name,Gender,Address
   from EntryListZoo
   where  gender='Male';
   select *from view1


