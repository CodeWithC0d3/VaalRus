--CREATE DATABASE Vaalrus; 
-- First Create a database in the explorer then run the script below

CREATE TABLE Booking (
    Booking_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_ID int NOT NULL, -- FK
	Quotation_ID int NOT NULL, -- FK
    StartDate DATE,
	EndDate DATE,
	Checkin_Time Time,
	Checkin_Out Time

);

CREATE TABLE Quotation (
    Qutotation_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_ID int NOT NULL, -- FK
    Reservation_Date DATE,
	Duration int,
	TotalPrice Decimal,
	PaymentStatus bit, -- Status seems to be a key word in SQL
    QuoteCreated_DateTime DateTime,
	CreatedBy varchar(50)

);

CREATE TABLE Quotationstatus (
    Status_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Status_Type bit

);

CREATE TABLE Payment (
    Payment_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Qutotation_ID int NOT NULL, -- FK
    ReceivedAmount decimal,
    Payment_Date date,
	Payment_Status bit
);

CREATE TABLE Customer (
    Customer_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_FirstName varchar(50),
    Customer_LastName varchar(50),
	Customner_IDNumber tinyint,
	Customer_Email varchar(50),
	Customner_Cell int,
    PhysicalAddress varchar(50) -- Address seems to be a key word in SQL

);

CREATE TABLE Accommodationset (
    Quotation_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY, --FK also
    Accommodation_ID int NOT NULL, --FK
	Number_Of_occupants int

);

CREATE TABLE Accommodation (
    Accommodation_ID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Accommodation_TypeID int NOT NULL, -- FK
	Number_Of_occupants int,
	Accommodation_Price Decimal

);

CREATE TABLE Accommodationtype (
    Accommodation_TypeID int NOT NULL IDENTITY(1,1) PRIMARY KEY,
	AccommodationType bit, -- Type seems to be a key word in SQL

);




