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
	Quantity DECIMAL(5,2) NOT NULL,
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
INSERT INTO Employee (SSN, FName, LName, Position, WorkingHours, Salary, SuperSSN, City, Street, Building, EPassword)
VALUES 
    ('23456789012', 'Jane', 'Smith', 'Manager', 45, 3500.00, NULL, 'Los Angeles', 'Sunset Blvd', 'Building 2', 'mypassword1234'),
    ('12345678901', 'John', 'Doe', 'Chef', 40, 2500.00, '23456789012', 'New York', '5th Ave', 'Building 1', 'mypassword123'),
    ('34567890123', 'Emily', 'Johnson', 'Waiter', 35, 1500.00, '23456789012', 'Chicago', 'Oak Street', 'Building 3', 'mypassword12'),
    ('45678901234', 'Mike', 'Williams', 'Chef', 38, 2600.00, '23456789012', 'Boston', 'Beacon Street', 'Building 4', 'mypassword345'),
    ('56789012345', 'Sarah', 'Davis', 'Waiter', 32, 1400.00, '23456789012', 'Miami', 'Ocean Drive', 'Building 5', 'mypassword678'),
    ('67890123456', 'Tom', 'Brown', 'Chef', 50, 3700.00, '23456789012', 'San Francisco', 'Market Street', 'Building 6', 'mypassword910'),
    ('78901234567', 'Anna', 'Taylor', 'Chef', 42, 2550.00, '67890123456', 'Seattle', 'Pike Street', 'Building 7', 'mypassword112'),
    ('89012345678', 'Lisa', 'Moore', 'Waiter', 30, 1350.00, '67890123456', 'Austin', 'Congress Ave', 'Building 8', 'mypassword131'),
    ('90123456789', 'Paul', 'White', 'Chef', 48, 3600.00, '67890123456', 'Denver', 'Larimer Street', 'Building 9', 'mypassword151'),
    ('12345678912', 'Chris', 'Green', 'Chef', 41, 2400.00, '90123456789', 'Dallas', 'Main Street', 'Building 10', 'mypassword171'),
    ('22345678912', 'Pat', 'Lewis', 'Waiter', 33, 1300.00, '90123456789', 'Orlando', 'Disney Blvd', 'Building 11', 'mypassword191'),
    ('32345678912', 'Kelly', 'Harris', 'Chef', 46, 3550.00, '90123456789', 'Houston', 'Post Oak Blvd', 'Building 12', 'mypassword212'),
    ('42345678912', 'Sam', 'Clark', 'Chef', 37, 2450.00, '32345678912', 'Phoenix', 'Camelback Road', 'Building 13', 'mypassword232'),
    ('52345678912', 'Drew', 'Young', 'Waiter', 34, 1450.00, '32345678912', 'Las Vegas', 'Fremont Street', 'Building 14', 'mypassword252'),
    ('62345678912', 'Taylor', 'Hall', 'Chef', 36, 2700.00, '32345678912', 'Philadelphia', 'Chestnut Street', 'Building 15', 'mypassword272'),
    ('72345678912', 'Jordan', 'Allen', 'Chef', 49, 3800.00, '32345678912', 'Charlotte', 'Tryon Street', 'Building 16', 'mypassword292'),
    ('82345678912', 'Morgan', 'King', 'Chef', 43, 2600.00, '72345678912', 'Atlanta', 'Peachtree Street', 'Building 17', 'mypassword312'),
    ('92345678912', 'Jamie', 'Wright', 'Waiter', 31, 1250.00, '72345678912', 'San Diego', 'Broadway', 'Building 18', 'mypassword332'),
    ('10345678912', 'Robin', 'Scott', 'Chef', 39, 2750.00, '72345678912', 'Nashville', 'Music Row', 'Building 19', 'mypassword352'),
    ('11345678912', 'Alex', 'Baker', 'Waiter', 28, 1100.00, '72345678912', 'Portland', 'Burnside Street', 'Building 20', 'mypassword372');

INSERT INTO Ingredient (IngredientName, IngredientStock, IngredientPrice)
VALUES
    ('Flour', 100, 2.50),
    ('Sugar', 50, 1.80),
    ('Butter', 30, 3.00),
    ('Eggs', 200, 0.50),
    ('Milk', 100, 1.20),
    ('Salt', 40, 0.80),
    ('Yeast', 25, 0.90),
    ('Vanilla Extract', 15, 5.00),
    ('Baking Powder', 20, 1.00),
    ('Cocoa Powder', 35, 4.50),
    ('Honey', 10, 6.00),
    ('Olive Oil', 60, 3.80),
    ('Vegetable Oil', 80, 2.50),
    ('Chicken Breast', 50, 5.00),
    ('Beef Patty', 40, 4.50),
    ('Fish Fillet', 30, 6.50),
    ('Shrimp', 25, 7.00),
    ('Cheddar Cheese', 20, 3.50),
    ('Parmesan Cheese', 15, 4.00),
    ('Tomatoes', 120, 0.90),
    ('Lettuce', 100, 0.75),
    ('Onions', 90, 0.60),
    ('Garlic', 80, 0.50),
    ('Potatoes', 150, 0.60),
    ('Bell Peppers', 70, 1.20);

INSERT INTO Request (IngredientID, Quantity, ChefSSN, RequestDate, RequestStatus, ManagerSSN)
VALUES
    (1, 10, '12345678901', '2024-12-01', 'Pending', '23456789012'),
    (2, 20, '12345678901', '2024-12-02', 'Approved', '23456789012'),
    (3, 30, '34567890123', '2024-12-03', 'Pending', '23456789012');

INSERT INTO MenuItem (ItemName, CookingTime, ItemStatus, ChefSSN)
VALUES
    ('Burger', '00:20:00', 'Available', '12345678901'),
    ('Pizza', '00:25:00', 'Available', '12345678901'), 
    ('Pasta', '00:15:00', 'Available', '34567890123'), 
    ('Caesar Salad', '00:10:00', 'Available', '34567890123'),
    ('Chocolate Cake', '00:30:00', 'Available', '45678901234'), 
    ('Grilled Chicken', '00:35:00', 'Available', '45678901234'), 
    ('Fish Tacos', '00:20:00', 'Available', '56789012345'),    
    ('French Fries', '00:10:00', 'Available', '56789012345'),  
    ('Soup of the Day', '00:15:00', 'Available', '67890123456'),
    ('Steak', '00:40:00', 'Available', '67890123456'),         
    ('Fried Rice', '00:20:00', 'Available', '78901234567'),    
    ('Grilled Salmon', '00:30:00', 'Available', '78901234567'),
    ('Vegetable Stir-Fry', '00:15:00', 'Available', '89012345678'), 
    ('Cheese Omelette', '00:10:00', 'Available', '89012345678'),    
    ('Pancakes', '00:15:00', 'Available', '90123456789'),     
    ('Shrimp Cocktail', '00:10:00', 'Available', '90123456789'), 
    ('BBQ Ribs', '00:45:00', 'Available', '12345678912'),      
    ('Club Sandwich', '00:15:00', 'Available', '12345678912'),  
    ('Tuna Salad', '00:10:00', 'Available', '32345678912'),   
    ('Ice Cream Sundae', '00:05:00', 'Available', '32345678912');


INSERT INTO ContainsIngredient (ItemID, IngredientID, Quantity)
VALUES
    -- 1: Burger
    (1, 13, 1.00), -- Beef Patty
    (1, 21, 1.00), -- Lettuce
    (1, 20, 0.50), -- Tomatoes
    (1, 22, 0.30), -- Onions
    (1, 17, 0.75), -- Cheddar Cheese
    (1, 12, 0.10), -- Olive Oil
    (1, 6, 0.05),  -- Salt

    -- 2: Pizza
    (2, 1, 3.00),  -- Flour
    (2, 2, 1.00),  -- Sugar
    (2, 4, 1.00),  -- Eggs
    (2, 18, 1.50), -- Parmesan Cheese
    (2, 20, 0.50), -- Tomatoes
    (2, 12, 0.20), -- Olive Oil
    (2, 6, 0.10),  -- Salt

    -- 3: Pasta
    (3, 1, 2.50),  -- Flour
    (3, 5, 1.00),  -- Milk
    (3, 18, 1.00), -- Parmesan Cheese
    (3, 20, 0.50), -- Tomatoes
    (3, 23, 0.05), -- Garlic
    (3, 12, 0.15), -- Olive Oil

    -- 4: Caesar Salad
    (4, 21, 1.50), -- Lettuce
    (4, 18, 0.50), -- Parmesan Cheese
    (4, 20, 0.30), -- Tomatoes
    (4, 22, 0.20), -- Onions
    (4, 23, 0.05), -- Garlic
    (4, 12, 0.10), -- Olive Oil

    -- 5: Chocolate Cake
    (5, 1, 3.00),  -- Flour
    (5, 2, 2.00),  -- Sugar
    (5, 4, 4.00),  -- Eggs
    (5, 10, 2.00), -- Cocoa Powder
    (5, 5, 1.00),  -- Milk
    (5, 6, 0.10),  -- Salt

    -- 6: Grilled Chicken
    (6, 15, 1.00), -- Chicken Breast
    (6, 23, 0.10), -- Garlic
    (6, 12, 0.15), -- Olive Oil
    (6, 6, 0.05),  -- Salt
    (6, 7, 0.10),  -- Pepper

    -- 7: Fish Tacos
    (7, 14, 2.00), -- Fish Fillet
    (7, 1, 1.50),  -- Flour
    (7, 21, 0.50), -- Lettuce
    (7, 20, 0.30), -- Tomatoes
    (7, 12, 0.15), -- Olive Oil
    (7, 6, 0.05),  -- Salt

    -- 8: French Fries
    (8, 16, 3.00), -- Potatoes
    (8, 12, 0.10), -- Olive Oil
    (8, 6, 0.05),  -- Salt

    -- 9: Soup of the Day
    (9, 20, 1.00), -- Tomatoes
    (9, 22, 0.50), -- Onions
    (9, 23, 0.10), -- Garlic
    (9, 12, 0.10), -- Olive Oil
    (9, 7, 0.05),  -- Pepper

    -- 10: Steak
    (10, 19, 1.00), -- Steak
    (10, 23, 0.10), -- Garlic
    (10, 12, 0.15), -- Olive Oil
    (10, 6, 0.05),  -- Salt
    (10, 7, 0.10),  -- Pepper

    -- 11: Fried Rice
    (11, 11, 2.50), -- Rice
    (11, 12, 0.10), -- Olive Oil
    (11, 20, 0.50), -- Tomatoes
    (11, 22, 0.30), -- Onions
    (11, 23, 0.10), -- Garlic
    (11, 6, 0.05),  -- Salt

    -- 12: Grilled Salmon
    (12, 14, 1.50), -- Fish Fillet (Salmon)
    (12, 23, 0.10), -- Garlic
    (12, 12, 0.15), -- Olive Oil
    (12, 6, 0.05),  -- Salt
    (12, 7, 0.10),  -- Pepper

    -- 13: Vegetable Stir-Fry
    (13, 21, 1.00), -- Lettuce
    (13, 20, 0.50), -- Tomatoes
    (13, 22, 0.30), -- Onions
    (13, 23, 0.10), -- Garlic
    (13, 12, 0.15), -- Olive Oil
    (13, 6, 0.05),  -- Salt

    -- 14: Cheese Omelette
    (14, 4, 3.00),  -- Eggs
    (14, 17, 0.75), -- Cheddar Cheese
    (14, 12, 0.10), -- Olive Oil
    (14, 6, 0.05),  -- Salt

    -- 15: Pancakes
    (15, 1, 2.00),  -- Flour
    (15, 2, 1.00),  -- Sugar
    (15, 4, 2.00),  -- Eggs
    (15, 5, 1.00),  -- Milk
    (15, 6, 0.05),  -- Salt
    (15, 9, 0.10),  -- Baking Powder

    -- 16: Shrimp Cocktail
    (16, 8, 1.50),  -- Shrimp
    (16, 21, 0.50), -- Lettuce
    (16, 12, 0.10), -- Olive Oil
    (16, 6, 0.05),  -- Salt

    -- 17: BBQ Ribs
    (17, 19, 2.00), -- Steak (Ribs)
    (17, 23, 0.10), -- Garlic
    (17, 12, 0.20), -- Olive Oil
    (17, 6, 0.05),  -- Salt
    (17, 24, 0.50), -- BBQ Sauce

    -- 18: Club Sandwich
    (18, 1, 1.00),  -- Flour (Bread)
    (18, 20, 0.50), -- Tomatoes
    (18, 22, 0.30), -- Onions
    (18, 21, 0.75), -- Lettuce
    (18, 17, 0.50), -- Cheddar Cheese

    -- 19: Tuna Salad
    (19, 14, 1.50), -- Fish Fillet (Tuna)
    (19, 21, 1.00), -- Lettuce
    (19, 20, 0.50), -- Tomatoes
    (19, 12, 0.15), -- Olive Oil
    (19, 6, 0.05),  -- Salt

    -- 20: Ice Cream Sundae
    (20, 5, 2.00),  -- Milk
    (20, 2, 1.50),  -- Sugar
    (20, 4, 1.00),  -- Eggs
    (20, 25, 1.00); -- Ice Cream Topping

INSERT INTO Supplier (FName, LName)
VALUES
    ('Alice', 'Anderson'),
    ('Bob', 'Brown'),
    ('Charlie', 'Clark'),
    ('Diana', 'Davis'),
    ('Edward', 'Evans'),
    ('Fiona', 'Foster'),
    ('George', 'Green'),
    ('Hannah', 'Harris'),
    ('Ian', 'Irwin'),
    ('Julia', 'Johnson'),
    ('Kevin', 'King'),
    ('Laura', 'Lewis'),
    ('Michael', 'Moore'),
    ('Nancy', 'Nelson'),
    ('Oliver', 'Owens'),
    ('Paula', 'Parker'),
    ('Quinn', 'Quinn'),
    ('Rachel', 'Reed'),
    ('Samuel', 'Scott'),
    ('Tina', 'Turner');

INSERT INTO Customer (PhoneNumber, FName, LName, EPassword)
VALUES
    ('01234567890', 'Michael', 'Brown', 'Sunshine@93'),
    ('01123456789', 'Sarah', 'Davis', 'BlueSky@87'),
    ('01098765432', 'John', 'Smith', 'CleverFox!76'),
    ('01543210987', 'Emily', 'Johnson', 'LemonTree#64'),
    ('01234567901', 'James', 'Williams', 'Violet@Flow3r'),
    ('01134567890', 'Linda', 'Taylor', 'OceanBreeze$45'),
    ('01598765432', 'David', 'Miller', 'Mango!Tango38'),
    ('01234567902', 'Sophia', 'Wilson', 'CherryBlossom2#9'),
    ('01023456789', 'Daniel', 'Moore', 'HappyFeet!21'),
    ('01565432109', 'Charlotte', 'Jackson', 'SilverMoon*13'),
    ('01298765432', 'Oliver', 'White', 'Jungle@Rain6'),
    ('01123458967', 'Amelia', 'Harris', 'Tropical!Breeze1'),
    ('01598765433', 'Liam', 'Martin', 'WhisperingWinds#99'),
    ('01054321098', 'Isabella', 'Thompson', 'RedRose@92'),
    ('01176543123', 'Lucas', 'Garcia', 'Pineapple!Sunset85'),
    ('01287654356', 'Harper', 'Martinez', 'Golden@Sunset77'),
    ('01543278012', 'Ethan', 'Roberts', 'CrystalLake!68'),
    ('01165432987', 'Ava', 'Perez', 'MidnightStar#60'),
    ('01056789076', 'Mason', 'Lewis', 'StarryNight$53'),
    ('01576543210', 'Ella', 'Young', 'Moonlight!Dream44'),
    ('01287654321', 'Alexander', 'Walker', 'Rainbow!Dawn37'),
    ('01098765456', 'Grace', 'Allen', 'Morning@Dew29'),
    ('01123458987', 'Sebastian', 'Scott', 'Ocean!Whispers22'),
    ('01598765476', 'Victoria', 'King', 'Sunset@Horizon15'),
    ('01065421067', 'Benjamin', 'Adams', 'MountainPeak!8');

INSERT INTO Locations (City, Street, Building)
VALUES
    ('New York', '5th Ave', 'Building 1'),
    ('Los Angeles', 'Sunset Blvd', 'Building 2'),
    ('Chicago', 'Michigan Ave', 'Building 3'),
    ('Houston', 'Main St', 'Building 4'),
    ('Phoenix', 'Central Ave', 'Building 5'),
    ('Philadelphia', 'Market St', 'Building 6'),
    ('San Antonio', 'Alamo St', 'Building 7'),
    ('San Diego', 'Pacific Hwy', 'Building 8'),
    ('Dallas', 'Elm St', 'Building 9'),
    ('San Jose', 'Santa Clara St', 'Building 10'),
    ('Austin', 'Congress Ave', 'Building 11'),
    ('Jacksonville', 'Beach Blvd', 'Building 12'),
    ('Fort Worth', 'Lancaster Ave', 'Building 13'),
    ('Columbus', 'High St', 'Building 14'),
    ('Indianapolis', 'Meridian St', 'Building 15'),
    ('Charlotte', 'Tryon St', 'Building 16'),
    ('San Francisco', 'Market St', 'Building 17'),
    ('Seattle', 'Pike St', 'Building 18'),
    ('Denver', 'Broadway St', 'Building 19'),
    ('Washington DC', 'K St', 'Building 20'),
    ('Boston', 'Boylston St', 'Building 21'),
    ('El Paso', 'Mesa St', 'Building 22'),
    ('Detroit', 'Woodward Ave', 'Building 23'),
    ('Nashville', 'Broadway St', 'Building 24'),
    ('Oklahoma City', 'NW Expressway', 'Building 25'),
    ('Las Vegas', 'Las Vegas Blvd', 'Building 26'),
    ('Louisville', '4th St', 'Building 27'),
    ('Baltimore', 'Charles St', 'Building 28'),
    ('Milwaukee', 'Water St', 'Building 29'),
    ('Portland', 'Burnside St', 'Building 30');

INSERT INTO CustomerLocations (PhoneNumber, LocationID)
VALUES
    ('01234567890', 15),
    ('01123456789', 2),
    ('01098765432', 27),
    ('01543210987', 10),
    ('01234567901', 6),
    ('01134567890', 21),
    ('01598765432', 18),
    ('01234567902', 8),
    ('01023456789', 24),
    ('01565432109', 3),
    ('01298765432', 17),
    ('01123458967', 30),
    ('01598765433', 14),
    ('01054321098', 12),
    ('01176543123', 25),
    ('01287654356', 22),
    ('01543278012', 20),
    ('01165432987', 11),
    ('01056789076', 29),
    ('01576543210', 9),
    ('01287654321', 1),
    ('01098765456', 28),
    ('01123458987', 5),
    ('01598765476', 13),
    ('01065421067', 19);

INSERT INTO RestaurantTable (CustomerPhoneNumber)
VALUES
    ('01234567890'),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL),
    (NULL);

INSERT INTO Supplies (SupplierID, IngredientID, SupplyDate)
VALUES
    (1, 8, '2024-12-01'),
    (2, 15, '2024-12-02'),
    (3, 2, '2024-12-03'),
    (4, 20, '2024-12-04'),
    (5, 18, '2024-12-05'),
    (6, 13, '2024-12-06'),
    (7, 24, '2024-12-07'),
    (8, 5, '2024-12-08'),
    (9, 10, '2024-12-09'),
    (10, 19, '2024-12-10'),
    (11, 3, '2024-12-11'),
    (12, 25, '2024-12-12'),
    (13, 7, '2024-12-13'),
    (14, 1, '2024-12-14'),
    (15, 22, '2024-12-15'),
    (16, 14, '2024-12-16'),
    (17, 4, '2024-12-17'),
    (18, 9, '2024-12-18'),
    (19, 11, '2024-12-19'),
    (20, 12, '2024-12-20'),
    (1, 16, '2024-12-21'),
    (2, 17, '2024-12-22'),
    (3, 6, '2024-12-23'),
    (4, 21, '2024-12-24'),
    (5, 23, '2024-12-25');

INSERT INTO CustomerOrder (OrderState, OrderDate, OrderFeedback, CustomerPhoneNumber, WaiterSSN)
VALUES
    ('Pending', '2024-12-01 01:01:01', 'Good', '01234567890', '34567890123'),
    ('Served', '2024-12-02 12:15:30', 'Excellent', '01123456789', '56789012345'),
    ('Cancelled', '2024-12-03 14:30:00', 'Poor', '01098765432', '89012345678'),
    ('Served', '2024-12-04 16:45:10', 'Good', '01543210987', '92345678912'),
    ('Pending', '2024-12-05 09:10:25', 'Excellent', '01234567901', '11345678912'),
    ('Served', '2024-12-06 18:00:00', 'Average', '01123458967', '34567890123'),
    ('Pending', '2024-12-07 20:30:15', 'Good', '01234567901', '56789012345'),
    ('Cancelled', '2024-12-08 22:00:00', 'Poor', '01598765432', '89012345678'),
    ('Served', '2024-12-09 07:25:45', 'Excellent', '01234567890', '92345678912'),
    ('Pending', '2024-12-10 11:50:00', 'Good', '01123456789', '11345678912'),
    ('Cancelled', '2024-12-11 13:05:30', 'Average', '01098765432', '34567890123'),
    ('Served', '2024-12-12 15:40:25', 'Good', '01123458967', '56789012345'),
    ('Pending', '2024-12-13 17:55:10', 'Excellent', '01234567901', '89012345678'),
    ('Served', '2024-12-14 19:30:30', 'Good', '01598765432', '92345678912'),
    ('Pending', '2024-12-15 10:05:15', 'Good', '01123456789', '11345678912'),
    ('Cancelled', '2024-12-16 12:25:50', 'Poor', '01098765432', '34567890123'),
    ('Served', '2024-12-17 14:40:00', 'Excellent', '01234567890', '56789012345'),
    ('Pending', '2024-12-18 16:10:35', 'Average', '01598765432', '89012345678'),
    ('Served', '2024-12-19 17:20:25', 'Good', '01234567890', '92345678912');


INSERT INTO Order_Contains_MenuItem (OrderID, ItemID, Quantity)
VALUES
    (5, 12, 2),
    (8, 7, 1),
    (3, 16, 3),
    (6, 9, 2),
    (2, 5, 4),
    (10, 3, 1),
    (9, 14, 2),
    (4, 20, 1),
    (7, 13, 3),
    (11, 6, 2),
    (1, 10, 5),
    (14, 17, 2),
    (13, 19, 1),
    (15, 8, 3),
    (16, 4, 1),
    (17, 18, 2),
    (18, 2, 4),
    (19, 15, 3),
    (19, 11, 1),
    (19, 1, 2);