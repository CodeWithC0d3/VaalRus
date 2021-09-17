--CREATE DATABASE Vaalrus; 

-- CANT DROP TABLES LIKE THIS BECUASE OF FOREIGN KEYs
-- DROP TABLE IF EXISTS Customer;
-- DROP TABLE IF EXISTS Quotatio;
-- DROP TABLE IF EXISTS Booking;
-- DROP TABLE IF EXISTS Quotationstatus;
-- DROP TABLE IF EXISTS Payment;
-- DROP TABLE IF EXISTS Accommodationtype;
-- DROP TABLE IF EXISTS Accommodation;
-- DROP TABLE IF EXISTS Accommodationset;



CREATE TABLE Customer (
    Customer_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_FirstName VARCHAR(50) NOT NULL,
    Customer_LastName VARCHAR(50),
	Customner_IDNumber CHAR(13) NOT NULL,
	Customer_Email VARCHAR(50) NOT NULL UNIQUE,
	Customner_Cell VARCHAR(15) NOT NULL,
    Customer_Address VARCHAR(50) -- Address seems to be a key word in SQL

);

CREATE TABLE Quotation (
    Quotation_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_ID INT NOT NULL REFERENCES Customer(Customer_ID), -- FK
    Reservation_Date DATE NOT NULL,
	Duration INT NOT NULL,
	TotalPrice DECIMAL,
	PaymentStatus BIT DEFAULT 0, -- Status seems to be a key word in SQL
    QuoteCreated_DateTime DATETIME,
	CreatedBy VARCHAR(50)

);

CREATE TABLE Booking (
    Booking_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_ID INT NOT NULL REFERENCES Customer(Customer_ID), -- FK
	Quotation_ID INT NOT NULL REFERENCES Quotation(Quotation_ID), -- FK
    StartDate DATE,
	EndDate DATE,
	Checkin_Time DATETIME,
	Checkin_Out DATETIME

);

CREATE TABLE Quotationstatus (
    Status_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Status_Type BIT DEFAULT 0

);

CREATE TABLE Payment (
    Payment_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Quotation_ID INT NOT NULL REFERENCES Quotation(Quotation_ID), -- FK
    ReceivedAmount DECIMAL, -- SQL has a currency option, wasn't sure what to go with
    Payment_Date DATETIME,
	Payment_Status BIT DEFAULT 0
);

CREATE TABLE Accommodationtype (
    Accommodation_TypeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	AccommodationType BIT, -- Type seems to be a key word in SQL

);

CREATE TABLE Accommodation (
    Accommodation_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Accommodation_TypeID INT NOT NULL REFERENCES Accommodationtype(Accommodation_TypeID), -- FK
	Number_Of_occupants INT,
	Accommodation_Price DECIMAL -- SQL has a currency option, wasn't sure what to go with

);



CREATE TABLE Accommodationset (
    Quotation_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY, --FK also
    Accommodation_ID INT NOT NULL REFERENCES Accommodation(Accommodation_ID), --FK
	Number_Of_Occupants INT

);








