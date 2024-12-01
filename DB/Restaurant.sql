-------------Database creation-------------
--create database Restaurant
USE master
GO
DROP DATABASE IF EXISTS Restaurant
GO
Create database Restaurant
GO
use Restaurant

------------Table Creation-----------------
CREATE TABLE Employee (
  
    SSN VARCHAR(11) PRIMARY KEY,
    FName VARCHAR(20) NOT NULL,
	LName VARCHAR(20) NOT NULL,
	Position VARCHAR(30) NOT NULL,
	WorkingHours INT NOT NULL DEFAULT 0,
    Salary DECIMAL(10, 2) NOT NULL DEFAULT 0,
	SuperSSN VARCHAR(11) DEFAULT NULL,
	City VARCHAR(30),
    Street VARCHAR(30),
	Building VARCHAR(30),
	FOREIGN KEY (SuperSSN) REFERENCES Employee(SSN)
	ON DELETE SET NULL
	ON UPDATE CASCADE
);

CREATE TABLE Ingredient(
	IngredientID VARCHAR(30) PRIMARY KEY,
	IngredientName VARCHAR(30) NOT NULL,
	IngredientStock INT DEFAULT 0,
	IngredientPrice DECIMAL(5,2) NOT NULL
);

CREATE TABLE Request(
	ID VARCHAR(30) PRIMARY KEY,
	IngredientID VARCHAR(30) NOT NULL,
	ChefSSN VARCHAR(11) NOT NULL,
	RequestDate DATE NOT NULL,
	RequestStatus VARCHAR(20) DEFAULT 'Pending',
	ManagerSSN VARCHAR(11) NOT NULL,
	FOREIGN KEY (IngredientID) REFERENCES Ingredient(IngredientID)
	--ON DELETE RESTRICT law m4 by3ml by default
	ON UPDATE CASCADE,
	FOREIGN KEY (ChefSSN) REFERENCES Employee(SSN)
	--ON DELETE RESTRICT law m4 by3ml by default
	ON UPDATE CASCADE,
	FOREIGN KEY (ManagerSSN) REFERENCES Employee(SSN)
	--ON DELETE RESTRICT law m4 by3ml by default
	ON UPDATE CASCADE
);

CREATE TABLE MenuItem (
    ItemID VARCHAR(30) PRIMARY KEY,
    ItemName VARCHAR(50) NOT NULL,
    CookingTime TIME DEFAULT '00:00:00',
    ItemStatus VARCHAR(50) DEFAULT 'Available',
	ChefSSN VARCHAR(11),
	FOREIGN KEY (ChefSSN) REFERENCES Employee(SSN)
);

CREATE TABLE ContainsIngredient (
    ItemID VARCHAR(30),
    IngredientID VARCHAR(30),
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
	SupplierID VARCHAR(30) PRIMARY KEY,
	FName VARCHAR(20) NOT NULL,
	LName VARCHAR(20) NOT NULL
);

CREATE TABLE Customer(
	PhoneNumber VARCHAR(15) PRIMARY KEY,
	FName VARCHAR(20),
	LName VARCHAR(20),
);

CREATE TABLE Locations (
	LocationID VARCHAR(30) PRIMARY KEY,
    City VARCHAR(30) NOT NULL,
    Street VARCHAR(30) NOT NULL,
    Building VARCHAR(30) NOT NULL
);

CREATE TABLE CustomerLocations (
    PhoneNumber VARCHAR(15),
    LocationID VARCHAR(30),
    PRIMARY KEY (PhoneNumber, LocationID),
    FOREIGN KEY (PhoneNumber) REFERENCES Customer(PhoneNumber)
	ON DELETE CASCADE,
    FOREIGN KEY (LocationID) REFERENCES Locations(LocationID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

CREATE TABLE RestaurantTable (
    TableNumber INT PRIMARY KEY,
	CustomerPhoneNumber VARCHAR(15),
	FOREIGN KEY (CustomerPhoneNumber) REFERENCES Customer(PhoneNumber)
	ON DELETE SET NULL
	ON UPDATE CASCADE
);

CREATE TABLE Supplies (
    SupplierID VARCHAR(30),
    IngredientID VARCHAR(30),
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
	OrderID VARCHAR(30) PRIMARY KEY,
	OrderState VARCHAR(15) DEFAULT 'Pending' NOT NULL,
	OrderDate DATE NOT NULL,
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
    OrderID VARCHAR(30),
    ItemID VARCHAR(30),
    Quantity INT NOT NULL,
    PRIMARY KEY (OrderID, ItemID),
    FOREIGN KEY (OrderID) REFERENCES CustomerOrder(OrderID)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
    FOREIGN KEY (ItemID) REFERENCES MenuItem(ItemID)
	ON DELETE CASCADE
	ON UPDATE CASCADE
);

------------INSERT VALUES------------
INSERT INTO Employee (SSN, FName, LName, Position, WorkingHours, Salary, SuperSSN, City, Street, Building)
VALUES 
    ('12345678901', 'John', 'Doe', 'Chef', 40, 2500.00, '23456789012', 'New York', '5th Ave', 'Building 1'),
    ('23456789012', 'Jane', 'Smith', 'Manager', 45, 3500.00, NULL, 'Los Angeles', 'Sunset Blvd', 'Building 2'),
    ('34567890123', 'Emily', 'Johnson', 'Waiter', 35, 1500.00, '23456789012', 'Chicago', 'Oak Street', 'Building 3');

INSERT INTO Ingredient (IngredientID, IngredientName, IngredientStock, IngredientPrice)
VALUES
    ('INGR001', 'Flour', 100, 2.50),
    ('INGR002', 'Sugar', 50, 1.80),
    ('INGR003', 'Butter', 30, 3.00),
    ('INGR004', 'Eggs', 200, 0.50);

INSERT INTO Request (ID, IngredientID, ChefSSN, RequestDate, RequestStatus, ManagerSSN)
VALUES
    ('REQ001', 'INGR001', '12345678901', '2024-12-01', 'Pending', '23456789012'),
    ('REQ002', 'INGR002', '12345678901', '2024-12-02', 'Approved', '23456789012'),
    ('REQ003', 'INGR003', '34567890123', '2024-12-03', 'Pending', '23456789012');

INSERT INTO MenuItem (ItemID, ItemName, CookingTime, ItemStatus, ChefSSN)
VALUES
    ('ITEM001', 'Burger', '00:20:00', 'Available', '12345678901'),
    ('ITEM002', 'Pizza', '00:25:00', 'Available', '12345678901'),
    ('ITEM003', 'Pasta', '00:15:00', 'Available', '34567890123');

INSERT INTO ContainsIngredient (ItemID, IngredientID, Quantity)
VALUES
    ('ITEM001', 'INGR001', 2.00),
    ('ITEM001', 'INGR002', 1.00),
    ('ITEM002', 'INGR001', 3.00),
    ('ITEM002', 'INGR003', 1.50),
    ('ITEM003', 'INGR004', 1.00);

INSERT INTO Supplier (SupplierID, FName, LName)
VALUES
    ('SUPP001', 'ABC', 'Supplies'),
    ('SUPP002', 'XYZ', 'Supplier');

INSERT INTO Customer (PhoneNumber, FName, LName)
VALUES
    ('1234567890', 'Michael', 'Brown'),
    ('0987654321', 'Sarah', 'Davis');

INSERT INTO Locations (LocationID, City, Street, Building)
VALUES
    ('LOC001', 'New York', '5th Ave', 'Building 1'),
    ('LOC002', 'Los Angeles', 'Sunset Blvd', 'Building 2');

INSERT INTO CustomerLocations (PhoneNumber, LocationID)
VALUES
    ('1234567890', 'LOC001'),
    ('0987654321', 'LOC002');

INSERT INTO RestaurantTable (TableNumber, CustomerPhoneNumber)
VALUES
    (1, '1234567890'),
    (2, '0987654321');

INSERT INTO Supplies (SupplierID, IngredientID, SupplyDate)
VALUES
    ('SUPP001', 'INGR001', '2024-12-01'),
    ('SUPP001', 'INGR002', '2024-12-02'),
    ('SUPP002', 'INGR003', '2024-12-03');

INSERT INTO CustomerOrder (OrderID, OrderState, OrderDate, OrderFeedback, CustomerPhoneNumber, WaiterSSN)
VALUES
    ('ORD001', 'Pending', '2024-12-01', 'Good', '1234567890', '34567890123'),
    ('ORD002', 'Delivered', '2024-12-02', 'Excellent', '0987654321', '12345678901');

INSERT INTO Order_Contains_MenuItem (OrderID, ItemID, Quantity)
VALUES
    ('ORD001', 'ITEM001', 2),
    ('ORD001', 'ITEM002', 1),
    ('ORD002', 'ITEM003', 3);
