create table tbStaff(
	staffID smallint primary key,
	Staffname varchar(30), 
	Gender varchar(1), 
	Birthdate datetime, 
	Position varchar(20),
	salary smallmoney, 
	Phone varchar(15),
	Email varchar(40), 
	SAddress varchar(50),
	Hireddate datetime,  
	ExpiredDate datetime, 
	Stopwork bit) 
go

create table tbUser (UserID smallint primary key, 
	UserName varchar(30) ,
	UserPassword varchar(30),
	AccountType varchar(20),
	RegisterDate datetime,
	StaffID smallint,
	constraint FKStaffID foreign key (StaffID) References tbStaff(StaffID))
go

Create table tbSupplier(
	SupplierID smallint primary key, 
	SupplierName varchar(30),
	SupplierPhone varchar(15),
	Country varchar(20))
go
Create table tbRoomType(
	RTypeID smallint primary key, 
	RType varchar(20), 
	NumofBed smallint,
	Price smallmoney)
go

Create table tbRoom(
	RoomNo smallint primary key, 
	Availablebed smallint, 
	Building varchar (10), 
	Rfloor varchar(3), 
	RtypeID smallint, 
	Constraint FKRTypeID foreign key (RTypeID) References tbRoomType (RTypeID))
go
	create table tbDoctor(
	DocID smallint primary key, 
	Docname varchar(35), 
	Gender varchar(1), 
	Birthdate datetime, 
	DAddress varchar(100),
	Specialize varchar(30),
	Nation varchar(15), 
	Degree varchar(10), 
	salary smallint, 
	Phone varchar(20),
	Email varchar(40), 
	Contractdate datetime, 
	ExpiredDate datetime, 
	Stopwork bit)

go
	Create table tbServices(
	ServiceID smallint primary key,
	ServiceName varchar(30), 
	cost smallmoney, 
	Info varchar(50))
go
	
create table tbPatient (
	PID smallint primary key,
	PName varchar(30),
	Gender varchar(1), 
	PType varchar(10), 
	Nation varchar(20), 
	Birhtdate datetime, 
	PAddress varchar(50), 
	Phone varchar(15), 
	illstatus varchar(10),
	BloodType varchar(3), 
	Occupation varchar(30))
go

	Create table tbMeCategory(
	MeCategoryID smallint primary key, 
	Category varchar(20), 
	DosageForm varchar(15),
	Country varchar(15),
	Usage varchar(50) )
go

	Create table tbMedicine( 
	MeID smallint primary key, 
	MeName varchar(35),
	MeType varchar(20),
	/*PriceIn smallmoney, 
	PirceOut smallmoney, */
	StockQty smallint, 
	MeCategoryID smallint, 
	constraint FKMeCategoryID  Foreign key (MeCategoryID) references tbMeCategory (MeCategoryID))

go
	create table tbDocSchedule(
	ScheduleID smallint primary key, 
	DocID smallint, 
	ScheduleDate datetime, 
	TimeIn datetime, 
	TimeOut datetime, 
	Building varchar(3) not null, 
	Attendance bit not null, 
	constraint fkDocID foreign key(DocID) references tbDoctor(DocID)) 
go

	create table tbImport(ImportID int primary key,
	ImportDate datetime ,
	SupplierID smallint,
	StaffID smallint ,
	constraint FKStaffID9 foreign key(StaffID) references tbStaff(StaffID),
	constraint FKSupplierID foreign key(SupplierID) references tbSupplier(SupplierID))
	
go
	
	create table tbImport_Detail(
	ImportID int,
	MeID smallint Not Null,
	ImportQty integer Not Null,
	UnitPrice smallmoney Not Null,
	Amount smallmoney Not Null,
	constraint FKImportID foreign key(ImportID) references tbImport(ImportID),
	constraint FKMeID1 foreign key(MeID) references tbMedicine(MeID),
	constraint PKImportIDMeID Primary key(ImportID,MeID))
go

	Create table tbMeTreatment( 
	MTID smallint primary key, 
	TotalAmount smallmoney, 
	PID smallint , 
	Constraint FKPID Foreign key (PID) references tbPatient (PID))
go 

	create table tbMeTreatment_Detail(
	MeID smallint , 
	MTID smallint , 
	DateIssue Datetime , 
	Qty int  , 
	Total smallmoney ,
	DocID smallint , 
	constraint FKMeID Foreign key (MeID) references tbMedicine (MeID) , 
	constraint FKMTID Foreign key (MTID) references tbMeTreatment (MTID) , 
	constraint FKDocID1 Foreign key (DocID) references tbDoctor (DocID) , 
	constraint FKMeMT primary key (MeID,MTID));
go 

	Create table tbCheckIN(
	CheckInID smallint primary key, 
	CheckInDate datetime,illstatus varchar(30), 
	PID smallint, 
	DocID smallint, 
	StaffID smallint, 
	RoomNo smallint,
	constraint FKPID1 Foreign key (PID) references tbPatient(PID), 
	constraint FKStaffID1 Foreign key (StaffID) references tbStaff (StaffID),
	constraint FKDocID2 Foreign key (DocID) references tbDoctor(DocID), 
	constraint FKRoomNo1 Foreign key (RoomNo) references tbRoom(RoomNo) );
go 

	Create table tbCheckOut( 
	CheckOutID smallint primary key, 
	CheckInDate datetime,
	CheckOutDate datetime,
	illstatus varchar(30), 
	Amount smallmoney,PID smallint , 
	DocID smallint, 
	StaffID smallint, 
	RoomNo smallint, 
	constraint FKPID2 Foreign key (PID) references tbPatient(PID), 
	constraint FKStaffID2 Foreign key (StaffID) references tbStaff(StaffID) , 
	constraint FKDocID3 Foreign key (DocID) references tbDoctor(DocID), 
	constraint FKRoomNo2 Foreign key (RoomNo) references tbRoom(RoomNo) )
go

	Create table tbSerTreatment (
	STID smallint primary key, 
	DateIssue datetime, 
	TotalAmount smallint, 
	PID smallint, StaffID smallint, 
	constraint FKStaffID3 Foreign key (StaffID) references tbStaff (staffID),
	constraint FKPtID Foreign key (PID) references tbPatient (PID))
 go
	
	create table tbSerTreatment_Detail (
	SerID smallint Not Null,
	STID smallint Not Null,
	PID smallint Not Null,
	Qty smallint Not Null,
	Charge smallint Not Null,
	Total smallmoney Not Null,
	DocID smallint Not Null,
	constraint FKSerID foreign key(SerID) references tbServices(ServiceID),
	constraint FKSTID foreign key(STID) references tbSerTreatment(STID),
	constraint FKPID7 foreign key(PID) references tbPatient(PID),
	constraint FKDocID7 foreign key(DocID) references tbDoctor(DocID),
	constraint PKSerIDSTID Primary key(SerID,STID))
go 
	create table tbpayment (
	PaymentID smallint primary key, 
	PaymentDate datetime, 
	RCharge smallmoney, 
	MeCharge smallmoney, 
	SerCharge smallmoney,
	staffID smallint,
	PID smallint, 
	constraint FKStaffID4 Foreign key (StaffID) references tbStaff (staffID),
	constraint FKPID3 foreign key (PID) references tbPatient (PID))