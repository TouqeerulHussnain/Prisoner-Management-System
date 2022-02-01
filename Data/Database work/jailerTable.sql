/*

	Jailer table

*/

create table JailerTable (	jailerID int,
							jailerName varchar(30),
							jailerPass varchar(20),
							jailerEmail varchar(30),
							jailerAddress varchar(50),
							jailerAge int,
							jailerPhone bigint
							
							);/*
insert into JailerTable (jailerID ,
							jailerName ,
							jailerPass,
							jailerEmail ,
							jailerAddress
							jailerAge ,
							jailerPhone
							 ) 
							values
							(1,
							'pass',
							'Ali',
							33,
							'adbad@gmail.com',
							'mohallah')

							*/
select * from JailerTable
