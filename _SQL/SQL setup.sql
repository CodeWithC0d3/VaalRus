--CREATE DATABASE Vaalrus; 

DROP TABLE IF EXISTS Customer, Quotation, Booking, Quotationstatus, Payment, Accommodationtype, Accommodation, Accommodationset;


CREATE TABLE Customer (
    Customer_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_FirstName varchar(50),
    Customer_LastName varchar(50),
	Customner_IDNumber char(13),
	Customer_Email varchar(50),
	Customner_Cell varchar(15),
    PhysicalAddress varchar(50) -- Address seems to be a key word in SQL

);

CREATE TABLE Quotation (
    Qutotation_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_ID int NOT NULL, -- FK
    Reservation_Date DATE,
	Duration int,
	TotalPrice Decimal,
	PaymentStatus bit DEFAULT 0, -- Status seems to be a key word in SQL
    QuoteCreated_DateTime DateTime,
	CreatedBy varchar(50)

);

CREATE TABLE Booking (
    Booking_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_ID INT NOT NULL, -- FK
	Quotation_ID INT NOT NULL, -- FK
    StartDate DATE,
	EndDate DATE,
	Checkin_Time DATETIME,
	Checkin_Out DATETIME

);

CREATE TABLE Quotationstatus (
    Status_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Status_Type tinyint DEFAULT 0 --- leave as tinint (3 values: 0 pending, 1 accepted, 2 rejected)

);

CREATE TABLE Payment (
    Payment_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Qutotation_ID int NOT NULL, -- FK
    ReceivedAmount decimal,
    Payment_Date date,
	Payment_Status bit DEFAULT 0
);



CREATE TABLE Accommodation (
    Accommodation_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Accommodation_TypeID int NOT NULL, -- FK
	Number_Of_occupants int,
	Accommodation_Price Decimal

);

CREATE TABLE Accommodationtype (
    Accommodation_TypeID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	AccommodationType bit DEFAULT 0, -- Type seems to be a key word in SQL

);


CREATE TABLE Accommodationset (
    Quotation_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY, --FK also
    Accommodation_ID int NOT NULL, --FK
	Number_Of_Occupants int

);








