-------------Database creation-------------
--create database Restaurant
USE master;
GO
ALTER DATABASE Restaurant SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
GO
DROP DATABASE IF EXISTS Restaurant;
GO
CREATE DATABASE Restaurant;
GO
ALTER DATABASE Restaurant SET MULTI_USER;
GO
USE Restaurant;
GO

------------Table Creation-----------------
CREATE TABLE Employee (
  
    SSN VARCHAR(11) PRIMARY KEY,
    FName VARCHAR(20) NOT NULL,
	LName VARCHAR(20) NOT NULL,
	Position VARCHAR(30) NOT NULL,
	WorkingHours INT NOT NULL DEFAULT 0,
    Salary DECIMAL(10, 2) NOT NULL DEFAULT 0,
	SuperSSN VARCHAR(11),
	City VARCHAR(30),
    Street VARCHAR(30),
	Building VARCHAR(30),
	EPassword VARCHAR(30) NOT NULL,
	FOREIGN KEY (SuperSSN) REFERENCES Employee(SSN)
);

CREATE TABLE Ingredient(
	IngredientID INT IDENTITY(1,1) PRIMARY KEY,
	IngredientName VARCHAR(30) NOT NULL,
	IngredientStock INT DEFAULT 0,
	IngredientPrice DECIMAL(5,2) NOT NULL
);

CREATE TABLE Request(
	ID INT IDENTITY(1,1) PRIMARY KEY,
	IngredientID INT NOT NULL,
	ChefSSN VARCHAR(11) NOT NULL,
	RequestDate DATE NOT NULL,
	RequestStatus VARCHAR(20) DEFAULT 'Pending',
	ManagerSSN VARCHAR(11) NOT NULL,
	FOREIGN KEY (IngredientID) REFERENCES Ingredient(IngredientID)
	ON DELETE NO ACTION
	ON UPDATE CASCADE,
	FOREIGN KEY (ChefSSN) REFERENCES Employee(SSN)
	ON DELETE NO ACTION,
	FOREIGN KEY (ManagerSSN) REFERENCES Employee(SSN)
	ON DELETE NO ACTION
);

CREATE TABLE MenuItem (
    ItemID INT IDENTITY(1,1) PRIMARY KEY,
    ItemName VARCHAR(50) NOT NULL,
    CookingTime TIME DEFAULT '00:00:00',
    ItemStatus VARCHAR(50) DEFAULT 'Available',
	ChefSSN VARCHAR(11),
	FOREIGN KEY (ChefSSN) REFERENCES Employee(SSN)
);

CREATE TABLE ContainsIngredient (
    ItemID INT,
    IngredientID INT,
    Quantity DECIMAL(5, 2) NOT NULL,
    PRIMARY KEY (ItemID, IngredientID),
    FOREIGN KEY (ItemID) REFERENCES MenuItem(ItemID)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
    FOREIGN KEY (IngredientID) REFERENCES Ingredient(IngredientID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE Supplier(
	SupplierID INT IDENTITY(1,1) PRIMARY KEY,
	FName VARCHAR(20) NOT NULL,
	LName VARCHAR(20) NOT NULL
);

CREATE TABLE Customer(
	PhoneNumber VARCHAR(15) PRIMARY KEY,
	FName VARCHAR(20) NOT NULL,
	LName VARCHAR(20) NOT NULL,
	EPassword VARCHAR(30) NOT NULL
);

CREATE TABLE Locations (
	LocationID INT IDENTITY(1,1) PRIMARY KEY,
    City VARCHAR(30) NOT NULL,
    Street VARCHAR(30) NOT NULL,
    Building VARCHAR(30) NOT NULL
);

CREATE TABLE CustomerLocations (
    PhoneNumber VARCHAR(15),
    LocationID INT,
    PRIMARY KEY (PhoneNumber, LocationID),
    FOREIGN KEY (PhoneNumber) REFERENCES Customer(PhoneNumber)
	ON DELETE CASCADE,
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE RestaurantTable (
    TableNumber INT IDENTITY(1,1) PRIMARY KEY,
	CustomerPhoneNumber VARCHAR(15) DEFAULT NULL,
	FOREIGN KEY (CustomerPhoneNumber) REFERENCES Customer(PhoneNumber)
	ON DELETE SET NULL
	ON UPDATE CASCADE
);

CREATE TABLE Supplies (
    SupplierID INT,
    IngredientID INT,
    SupplyDate DATE,
    PRIMARY KEY (SupplierID, IngredientID, SupplyDate),
    FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
    FOREIGN KEY (IngredientID) REFERENCES Ingredient(IngredientID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE CustomerOrder(
	OrderID INT IDENTITY(1,1) PRIMARY KEY,
	OrderState VARCHAR(15) DEFAULT 'Pending' NOT NULL,
	OrderDate DATETIME NOT NULL,
	OrderFeedback VARCHAR(255),
	CustomerPhoneNumber VARCHAR(15),
	WaiterSSN VARCHAR(11),
	FOREIGN KEY (CustomerPhoneNumber) REFERENCES Customer(PhoneNumber)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	FOREIGN KEY (WaiterSSN) REFERENCES Employee(SSN)
	ON DELETE SET NULL
	ON UPDATE CASCADE
);

CREATE TABLE Order_Contains_MenuItem (
    OrderID INT,
    ItemID INT,
    Quantity INT NOT NULL,
    PRIMARY KEY (OrderID, ItemID),
    FOREIGN KEY (OrderID) REFERENCES CustomerOrder(OrderID)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
    FOREIGN KEY (ItemID) REFERENCES MenuItem(ItemID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);
GO
------------INSERT VALUES------------
INSERT INTO Employee (SSN, FName, LName, Position, WorkingHours, Salary, SuperSSN, City, Street, Building,EPassword)
VALUES 
    ('23456789012', 'Jane', 'Smith', 'Manager', 45, 3500.00, NULL, 'Los Angeles', 'Sunset Blvd', 'Building 2', 'mypassword1234'),
    ('12345678901', 'John', 'Doe', 'Chef', 40, 2500.00, '23456789012', 'New York', '5th Ave', 'Building 1','mypassword123'),
    ('34567890123', 'Emily', 'Johnson', 'Waiter', 35, 1500.00, '23456789012', 'Chicago', 'Oak Street', 'Building 3','mypassword12');

INSERT INTO Ingredient (IngredientName, IngredientStock, IngredientPrice)
VALUES
    ('Flour', 100, 2.50),
    ('Sugar', 50, 1.80),
    ('Butter', 30, 3.00),
    ('Eggs', 200, 0.50);

INSERT INTO Request (IngredientID, ChefSSN, RequestDate, RequestStatus, ManagerSSN)
VALUES
    (1, '12345678901', '2024-12-01', 'Pending', '23456789012'),
    (2, '12345678901', '2024-12-02', 'Approved', '23456789012'),
    (3, '34567890123', '2024-12-03', 'Pending', '23456789012');

INSERT INTO MenuItem (ItemName, CookingTime, ItemStatus, ChefSSN)
VALUES
    ('Burger', '00:20:00', 'Available', '12345678901'),
    ('Pizza', '00:25:00', 'Available', '12345678901'),
    ('Pasta', '00:15:00', 'Available', '34567890123');

INSERT INTO ContainsIngredient (ItemID, IngredientID, Quantity)
VALUES
    (1, 1, 2.00),
    (1, 2, 1.00),
    (2, 1, 3.00),
    (2, 3, 1.50),
    (3, 4, 1.00);

INSERT INTO Supplier (FName, LName)
VALUES
    ('ABC', 'Supplies'),
    ('XYZ', 'Supplier');

INSERT INTO Customer (PhoneNumber, FName, LName, EPassword)
VALUES
    ('01234567890', 'Michael', 'Brown', 'mypassword93'),
    ('00987654321', 'Sarah', 'Davis','mypassword87');

INSERT INTO Locations (City, Street, Building)
VALUES
    ('New York', '5th Ave', 'Building 1'),
    ('Los Angeles', 'Sunset Blvd', 'Building 2');

INSERT INTO CustomerLocations (PhoneNumber, LocationID)
VALUES
    ('01234567890', 1),
    ('00987654321', 2);

INSERT INTO RestaurantTable (CustomerPhoneNumber)
VALUES
    ('01234567890'),
    (NULL);

INSERT INTO Supplies (SupplierID, IngredientID, SupplyDate)
VALUES
    (1, 1, '2024-12-01'),
    (1, 2, '2024-12-02'),
    (2, 3, '2024-12-03');

INSERT INTO CustomerOrder (OrderState, OrderDate, OrderFeedback, CustomerPhoneNumber, WaiterSSN)
VALUES
    ('Pending', '2024-12-01 01:01:01', 'Good', '01234567890', '34567890123'),
    ('Delivered', '2024-12-02 01:01:01', 'Excellent', '00987654321', '12345678901');

INSERT INTO Order_Contains_MenuItem (OrderID, ItemID, Quantity)
VALUES
    (1, 1, 2),
    (1, 2, 1),
    (2, 3, 3);