

/*create database*/

/*

create database PrisonerMngSys;

*/

			/*Prsioenr Table*/
create table Prisoner_T( prisonerId int primary key,
						prisonerName varchar(20),
						prisonerAge int,
						pCrime varchar(30),
						pPunishment varchar(30),
						CrimeDate date,
						pReleaseDate date);



						



 
select * from Prisoner_T;
			/* we can generate auto prisoner ID because we are not going to delete the prisoner data*/