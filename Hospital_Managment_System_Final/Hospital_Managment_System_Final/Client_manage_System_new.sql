-- Create Database
Create Database NewHospital;

-- Use the database so that all operations will be in that database
Use NewHospital;

--Table PatientInfo
create table PatientInfo(RecordNo int identity(1,1),PatientRegNo int primary key,PatName varchar (200) not null,
PatAddress varchar(400) not null, MobileNo varchar(200) not null, Age int, wieght int, PatBP float, CholestrolHDL float, CholestrolLDL float,Sugurfast float,
SugurPotFast float, Medicines varchar(400), APDate date, fees float);

select *from PatientInfo;


Create table DailyCollection(
	 RecordNo int identity(1,1) primary key,
	 PatientRegNo int not null References PatientInfo(PatientRegNo),
	 APDate date,
	 Fees float,
	 );


	 select *from DailyCollection;

	 select *from PatientInfo;
	 

	 