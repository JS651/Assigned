---Database Creation
GO
CREATE DATABASE AqsaCelluar
ON
(
NAME=AqsaCelluar,
FILENAME='C:\Program Files (x86)\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Aqsa.mdf',
SIZE=50MB,
MAXSIZE=UNLIMITED,
FILEGROWTH=10%
)

LOG ON
(
NAME = AqsaLog,
FILENAME = 'C:\Program Files (x86)\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\Aqsalog.ldf',
SIZE = 20MB,
MAXSIZE = UNLIMITED,
FILEGROWTH = 10%
)
GO
---Tables Creation

USE AqsaCelluar
CREATE TABLE Customers 
(
  CustomerId int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  LastName varchar(50) NOT NULL,
  FirstName varchar(50) NOT NULL,
  ContactNumber varchar(14) DEFAULT NULL,
  Email varchar(75) NOT NULL,
  CONSTRAINT CustomerEmail UNIQUE(Email),
  INDEX FullName (LastName,FirstName)
)

CREATE TABLE RepairDevices
(
  DeviceId int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  CustomerId int NOT NULL FOREIGN KEY REFERENCES Customers (CustomerId),
  SerialNum varchar(50) NOT NULL,
  DeviceType varchar(50) DEFAULT NULL,
  Model varchar(50) DEFAULT NULL,
  RepairType varchar(50) NOT NULL,
  ProblemDescription varchar(100),
  CONSTRAINT RepairSerialNum UNIQUE(SerialNum),
  INDEX Device(SerialNum,DeviceType)
);

CREATE TABLE Parts 
(
  PartId int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  PartName varchar(50) NOT NULL,
  PartType varchar(75) NOT NULL,
  PartCost decimal(10,2) NOT NULL DEFAULT '0.00',
  PartQuantity smallint NOT NULL DEFAULT '1',
  PartDescription varchar(100),
  CONSTRAINT PartsPart UNIQUE(PartName,PartType),
  INDEX Part(PartName,PartType)
);

CREATE TABLE Repairmen (
  RepairmenId int NOT NULL IDENTITY(1000,1) PRIMARY KEY ,
  LastName varchar(50) NOT NULL,
  FirstName varchar(50) NOT NULL,
  CONSTRAINT RepairmenFullname UNIQUE (LastName,FirstName),
  INDEX FullName (LastName,FirstName)
);

CREATE TABLE RepairJobs 
(
  JobNum int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  RepairmenId int NOT NULL REFERENCES Repairmen(RepairmenId),
  PartId int NOT NULL FOREIGN KEY REFERENCES Parts(PartId),
  CustomerId int NOT NULL FOREIGN KEY REFERENCES Customers(CustomerId),
  DeviceId int NOT NULL FOREIGN KEY REFERENCES RepairDevices(DeviceId),
  DateReceived date NOT NULL,
  DateReturned date NOT NULL,
  DateEnded date DEFAULT NULL,
  LabourCost decimal(10,2) NOT NULL DEFAULT '0.00',
  Cost decimal(10,2) NOT NULL DEFAULT '0.00',
  TotalCost decimal(10,2) NOT NULL DEFAULT '0.00',
  CONSTRAINT RepairDates CHECK(DateReturned >= DateReceived),
  INDEX DateReceived (DateReceived),
  INDEX DateReturned (DateReturned)
);

CREATE TABLE Product (
  ProductId int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  ProductNumber varchar(50) NOT NULL,
  ProductName varchar(50) NOT NULL,
  Cost decimal(10,2) NOT NULL DEFAULT '0.00',
  ProductDescription varchar(100),
  CONSTRAINT ProductNumber UNIQUE (ProductNumber),
  INDEX Product(ProductNumber,ProductName)
);

CREATE TABLE Inventory (
  StockId int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  ProductId int NOT NULL FOREIGN KEY REFERENCES Product(ProductId),
  PartId int NOT NULL FOREIGN KEY REFERENCES Parts(PartId),
  ProductNumber varchar(50) NOT NULL,
  PartNumber varchar(50) NOT NULL,
  Cost decimal(10,2) NOT NULL DEFAULT '0.00',
  Quantity smallint NOT NULL,
  CONSTRAINT InventoryQuantity CHECK(Quantity>=0),
  INDEX ProductNumber (ProductNumber),
  INDEX PartNumber (PartNumber)
);

CREATE TABLE Orders
(
  OrderId int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  OrderDate date NOT NULL,
  CollectionDate date NOT NULL,
  OrderCode varchar(15) NOT NULL,
  CONSTRAINT OrderCode UNIQUE (OrderCode)
);

CREATE TABLE ProductOrders
(
  OrderId int NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
  ProductId int NOT NULL FOREIGN KEY REFERENCES Product(ProductId),
  ProductQuantity smallint NOT NULL DEFAULT '1',
  ProductCost decimal(10,2) NOT NULL DEFAULT '0.00',
   CONSTRAINT ProductOrders PRIMARY KEY (OrderID,ProductId)
);

CREATE TABLE PartOrders
(
  OrderId int NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
  PartId int NOT NULL FOREIGN KEY REFERENCES Product(ProductId),
  PartQuantity smallint NOT NULL DEFAULT '1',
  PartCost decimal(10,2) NOT NULL DEFAULT '0.00',
  CONSTRAINT PartOrders PRIMARY KEY (OrderID,PartId)
);

CREATE TABLE Invoice
(
  InvoiceNumber int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  OrderId int NOT NULL FOREIGN KEY REFERENCES Orders(OrderId),
  JobNum int NOT NULL FOREIGN KEY REFERENCES RepairJobs(JobNum),
  ProductOrderCost decimal(10,2) NOT NULL DEFAULT '0.00',
  PartOrderCost decimal(10,2) NOT NULL DEFAULT '0.00',
  RepairJobCost decimal(10,2) NOT NULL DEFAULT '0.00',
  TotalCost decimal(10,2) NOT NULL DEFAULT '0.00'
);

CREATE TABLE Payments 
(
  PaymentNum int NOT NULL IDENTITY(1000,1) PRIMARY KEY,
  PaymentDate date NOT NULL,
  Amount decimal(10,2) NOT NULL DEFAULT '0.00',
  InvoiceNumber int NOT NULL FOREIGN KEY REFERENCES Invoice(InvoiceNumber)
);

---Population

---Views
GO
CREATE VIEW ProductOrderView
AS
SELECT o.OrderDate,p.ProductName,po.ProductQuantity,po.ProductCost
FROM Orders o
INNER JOIN ProductOrders po 
ON o.OrderID = po.OrderID
INNER JOIN Product p 
ON po.ProductId=p.ProductId;
GO
CREATE VIEW AvgRepairTimeByDeviceType 
AS
SELECT rd.DeviceType, rm.LastName+', '+rm.FirstName AS Repairman, AVG(DATEDIFF(day,rj.DateReceived,rj.DateReturned)) ASAvgRepairTime
FROM RepairDevices rd
INNER JOIN RepairJobs rj ON rd.DeviceId=rj.DeviceId
INNER JOIN Repairmen rm ON rj.RepairmenId=rm.RepairmenId
GROUP BY rd.DeviceType, rm.LastName,rm.FirstName;
GO
CREATE VIEW BusyDaysOfWeek 
AS
SELECT DATENAME(WEEKDAY, rj.DateReceived) AS DayOfWeek,
COUNT(*) AS TotalRepairs,
(SELECT COUNT(*) FROM PartOrders po
INNER JOIN Orders o 
ON 
po.OrderId =o.OrderId
WHERE DATENAME(WEEKDAY,o.OrderDate)=DateNAME(WEEKDAY,rj.DateReceived)) AS TotalPartOrders
FROM RepairJobs rj
GROUP BY DATENAME(WEEKDAY, rj.DateReceived);
GO
---Query

SELECT
YEAR(DateReturned) AS Year,
MONTH(DateReturned) AS Month,
SUM(RepairJobCost) AS Revenue
FROM RepairJobs
JOIN Invoice
ON
RepairJobs.JobNum = Invoice.JobNum
WHERE
DateReturned >=DATEADD(year,-1,GETDATE())
GROUP BY 
YEAR(DateReturned), MONTH(DateReturned)
ORDER BY 
Year,Month;

SELECT
DeviceType,SUM(PartQuantity) AS TotalQuantity, SUM(PartCost * PartQuantity) AS TotalCost
FROM RepairJobs
JOIN Parts
ON
RepairJobs.PartId=Parts.PartId
JOIN RepairDevices 
ON RepairJobs.DeviceId=RepairDevices.DeviceId
GROUP BY DeviceType
ORDER BY TotalCost DESC;
GO
---Stored Procedures
USE AqsaCellular
GO
CREATE PROCEDURE GetCustomerDetails @CustomerId int
AS
BEGIN
SELECT * FROM Customers
WHERE CustomerId = @CustomerId;
END;
GO
CREATE PROCEDURE CalculateTotalCost
@JobNum int
AS
BEGIN
DECLARE @LabourCost decimal(10,2),@PartCost decimal(10,2),@TotalCost decimal(10,2)
SELECT @LabourCost= LabourCost 
FROM RepairJobs 
WHERE JobNum=@JobNum
SELECT @PartCost=SUM(PartCost * PartQuantity)FROM Parts p
JOIN RepairJobs rj ON p.PartId=rj.PartId
WHERE rj.JobNum = @JobNum
SET @TotalCost= @LabourCost+ @PartCost
UPDATE RepairJobs SET Cost = @PartCost,TotalCost=@TotalCost WHERE JobNum=@JobNum
GO
CREATE PROCEDURE GenerateInvoice
@CustomerId Int,
@OrderCode varchar(15)
AS
BEGIN 
DECLARE @OrderId int,@ProductOrderCost decimal(10,2),@PartOrderCost decimal(10,2), @RepairJobCost decimal(10,2),@TotalCost int
SELECT @OrderId=OrderId FROM Orders WHERE OrderCode = @OrderCode
SELECT @ProductOrderCost = SUM(ProductCost*ProductQuantity) FROM ProductOrders WHERE OrderId = @OrderId
SELECT @PartOrderCost = SUM(PartCost*PartQuantity) FROM PartOrders WHERE OrderId = @OrderId
SELECT @RepairJobCost = SUM(Cost*Count(JobNum)) FROM RepairJobs WHERE CustomerId = @CustomerId AND DateReturned IS NOT NULL
SET @TotalCost=@ProductOrderCost+@PartOrderCost+@RepairJobCost
INSERT INTO Invoice (OrderId, ProductOrderCost,PartOrderCost,RepairJobCost,TotalCost)
VALUES(@OrderId,@ProductOrderCost,@PartOrderCost,@RepairJobCost,@TotalCost)
END

---Triggers
GO
CREATE TRIGGER UpdateInventory
ON RepairJobs
AFTER INSERT
AS
BEGIN 
DECLARE @PartId int
SELECT @PartId = inserted.PartId FROM inserted
UPDATE Inventory 
SET Quantity=Quantity-(SELECT Quantity FROM PartOrders Where PartId =@PartId)
WHERE PartId = @PartId;
END


---Login
CREATE Login RepairmanLogin 
WITH PASSWORD ='password123';
GRANT SELECT ON RepairJob TO RepairmanLogin;

---Other Objects
GO
CREATE FUNCTION TotalRepairCostFunc (@JobNum int)
RETURNS decimal(10,2)
AS
BEGIN
DECLARE @TotalCost decimal(10,2);
SELECT @TotalCost=Cost+LabourCost
FROM RepairJobs
WHERE JobNum=@JobNum;
SELECT @TotalCost=@TotalCost+SUM(PartCost*PartQuantity)
FROM Parts p
JOIN PartOrders po ON p.PartId=po.PartId
WHERE po.OrderId=(SELECT OrderId FROM Invoice WHERE InvoiceNumber = (SELECT InvoiceNumber FROM RepairJobs WHERE JobNum = @JobNum));
RETURN @TotalCost;
END
