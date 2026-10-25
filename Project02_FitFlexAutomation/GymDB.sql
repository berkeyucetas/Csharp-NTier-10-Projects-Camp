create table Trainers(
TrainerID int identity(1,1) primary key,
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
Branch nvarchar(50) not null
);
create table MemberShipTypes(
TypeID int identity(1,1) primary key,
TypeName nvarchar(50) not null,
DurationMonths int not null,
Price decimal(18,2) not null,
);
create table Members(
MemberID int identity(1,1) primary key,
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
Phone nvarchar(20) not null,
RegistrationDate date default getdate(),
ExpireDate date not null,
TrainerID int foreign key references Trainers(TrainerID),
TypeID int foreign key references MemberShipTypes(TypeID),
QRCodeText nvarchar(100) unique not null
);
create table CheckIns(
CheckInID int identity(1,1) primary key,
MemberID int foreign key references Members(MemberID),
AccessTime datetime default getdate(),
Status bit not null
);
