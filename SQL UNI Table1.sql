create table StaffCities
(
CityID int primary key identity(1,1) not null, 
City varchar(50) not null,
);

create table StaffCounty
(
CountyID int primary key identity (1,1) not null,
CountyName varchar(50) not null,
);