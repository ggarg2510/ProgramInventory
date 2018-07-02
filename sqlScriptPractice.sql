show tables;
select * from logins order by logged_on desc;
select row_count(),pswd from users;
truncate table users;
insert into users(user_name,pswd,access,created_on) values('Factory','factory','Admin',now());
select count(*) from users where user_name='Factory' and pswd='factory';
delete from users where idusers=9;
show tables;
desc users;
show columns from users like 'access';
select * from module;
select max(idModule)+1 from Module;
select * from batch;
select * from programme;
SELECT NameProgramme FROM programme;

insert into programme(NameProgramme, StartProgramme, ExpCloseProgramme, created_on)
values(' ', '2016/05/15', '2016/05/16', now());
 
select * from course;
select * from users;
select * from Inquiry;
select * from student;
select * from programme;
select * from module;
select * from admission;
use programme_inventory;
desc admission;

desc Inquiry;
desc student;
insert into inquiry(Name, College, Address, Phone_1, Phone_2, Email_ID, Inquired_About, Inquiry_Date, Attended_By, Is_Acknowledged)
values('Gaurav', 'SBIT', 'UTTAM NAGAR', '9717435873', '7530848399','garg_gaurav25@rocketmail.com', 'vjjjv',now(),'Admin',0);

select count(*) from users;
select row_count(), NameModule, Description, Fee from module;
set  @a:=0;
select @a:=@a+1 serial_number, idusers from users;

select idusers,@acount:=@acount+1 serial_number
from (SELECT @acount:= 0) AS acount,users
order by name asc;

SET @count:=0;SELECT @count:=@count+1 AS 'count', idusers FROM users;

show procedure status where db='programme_inventory';
show procedure status where db='programme_inventory' and name like '%Get%';
show create procedure GetAllProducts2;

select * from new_table;
        Select Access FROM USERS 
            WHERE user_name='zzz'; drop table new_table;' AND pswd='1234'
