CREATE DATABASE Vaalrus; 

--CANT DROP TABLES LIKE THIS BECUASE OF FOREIGN KEYs
--DROP TABLE IF EXISTS Accommodationset;
--DROP TABLE IF EXISTS Accommodation;
--DROP TABLE IF EXISTS Accommodationtype;
--DROP TABLE IF EXISTS Payment;
--DROP TABLE IF EXISTS Booking;
--DROP TABLE IF EXISTS Quotation;
--DROP TABLE IF EXISTS Quotationstatus;
--DROP TABLE IF EXISTS Customer;

use Vaalrus
GO
CREATE TABLE Customer (
    Customer_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_FirstName VARCHAR(50) NOT NULL,
    Customer_LastName VARCHAR(50),
	Customer_IDNumber CHAR(13) NOT NULL,
	Customer_Email VARCHAR(50) UNIQUE,
	Customer_Cell VARCHAR(15) NOT NULL,
    Customer_Address NVARCHAR(250) -- Address seems to be a keyword in SQL

);

CREATE TABLE Quotationstatus (
    Status_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Status_Type VARCHAR(20)

);

CREATE TABLE Quotation (
    Quotation_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
    Customer_ID INT NOT NULL REFERENCES Customer(Customer_ID), -- FK
    Reservation_Date DATE NOT NULL,
	Duration INT NOT NULL,
	TotalPrice SMALLMONEY NOT NULL,
	PaymentStatus INT NOT NULL REFERENCES Quotationstatus(Status_ID), -- Status seems to be a keyword in SQL
    QuoteCreated_DateTime DATETIME NOT NULL,
	CreatedBy VARCHAR(50) NOT NULL

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

CREATE TABLE Payment (
    Payment_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Quotation_ID INT NOT NULL REFERENCES Quotation(Quotation_ID), -- FK
    ReceivedAmount SMALLMONEY, -- SQL has a currency option, wasn't sure what to go with
    Payment_Date DATETIME,
	Payment_Status BIT DEFAULT 0
);

CREATE TABLE Accommodationtype (
    Accommodation_TypeID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	AccommodationType VARCHAR(20) -- Type seems to be a key word in SQL

);

CREATE TABLE Accommodation (
--what about a name of each place???
    Accommodation_ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Accommodation_TypeID INT NOT NULL REFERENCES Accommodationtype(Accommodation_TypeID), -- FK
	Number_Of_Occupants INT NOT NULL,
	Accommodation_Price SMALLMONEY NOT NULL -- SQL has a currency option, wasn't sure what to go with

);


CREATE TABLE Accommodationset (
    Quotation_ID INT NOT NULL PRIMARY KEY REFERENCES Quotation(Quotation_ID),
	--Quotation_ID INT NOT NULL REFERENCES Quotation(Quotation_ID), --FK also
    Accommodation_ID INT NOT NULL REFERENCES Accommodation(Accommodation_ID), --FK
	Number_Of_Occupants INT,
	--CONSTRAINT PK_QuoteID FOREIGN KEY (Quotation_ID) REFERENCES Quotation(Quotation_ID)

);








