 create table Departments(
 id int primary key auto_increment,
dept_no int not null,
dept_name varchar(20) not null,
 dept_balance double not null);

  insert into departments(dept_no, dept_name, dept_balance) values (10,"mechanical",200000);
   insert into departments(dept_no, dept_name, dept_balance) values (20,"Electrical",300000);
   