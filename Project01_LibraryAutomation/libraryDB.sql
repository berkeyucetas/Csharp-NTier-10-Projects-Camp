create table members(
MemberID int identity(1,1) primary key,
FirstName nvarchar(50)  not null,
LastName nvarchar(75) not null,
Phone nvarchar(15) not null,
Email nvarchar(max) not null
);
create table Books(
BookID int identity(1,1) primary key,
Tittle nvarchar(100) not null,
Author nvarchar(100) not null,
ISBN nvarchar(20) not null,
Stock int not null
);
create table Borrows(
BorrowID int identity(1,1) primary key,
MemberID int foreign key references Members(MemberID),
BookID int foreign key references Books(BookID),
BorrowDate datetime not null,
DueDate datetime not null,
ReturnDate datetime not null,
IsReturned bit not null default 0
);