IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'FinalenDaniel')
BEGIN
    CREATE DATABASE FinalenDaniel;
END
GO

USE FinalenDaniel;
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Employees' AND type = 'U')
BEGIN
    CREATE TABLE Employees (
        EmployeeID INT PRIMARY KEY IDENTITY(1,1),
        Name VARCHAR(25),
        Authority VARCHAR(10) -- може да бъде 'сервитьор', 'барман', 'управител'
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Menu' AND type = 'U')
BEGIN
    CREATE TABLE Menu (
        DrinkID INT PRIMARY KEY IDENTITY(1,1),
        DrinkName VARCHAR(100),
        Price DECIMAL(5,2)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Tables' AND type = 'U')
BEGIN
    CREATE TABLE Tables (
        TableID INT PRIMARY KEY,
        IsOccupied BIT
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Orders' AND type = 'U')
BEGIN
    CREATE TABLE Orders (
        OrderID INT PRIMARY KEY IDENTITY(1,1),
        TableID INT,
        EmployeeID INT,
        Date DATE,
        FOREIGN KEY (TableID) REFERENCES Tables(TableID),
        FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'OrderDetails' AND type = 'U')
BEGIN
    CREATE TABLE OrderDetails (
        OrderDetailID INT PRIMARY KEY IDENTITY(1,1),
        OrderID INT,
        DrinkID INT,
        Quantity INT,
        FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
        FOREIGN KEY (DrinkID) REFERENCES Menu(DrinkID)
    );
END
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE name = 'Transactions' AND type = 'U')
BEGIN
    CREATE TABLE Transactions (
        TransactionID INT PRIMARY KEY IDENTITY(1,1),
        OrderID INT,
        Amount DECIMAL(5,2),
        Date DATE,
        FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
    );
END
GO

-- Insert initial data into Employees
IF NOT EXISTS (SELECT * FROM Employees)
BEGIN
    INSERT INTO Employees (Name, Authority) VALUES
    ('Иван Иванов', 'сервитьор'),
    ('Мария Петрова', 'барман'),
    ('Димитър Георгиев', 'управител');
END
GO

-- Insert initial data into Menu
IF NOT EXISTS (SELECT * FROM Menu)
BEGIN
    INSERT INTO Menu (DrinkName, Price) VALUES
    ('Кафе', 1.00),
    ('Безкофеиново кафе', 0.70),
    ('Нес кафе', 0.60),
    ('Капучино', 0.80),
    ('Мляко с нес', 0.70),
    ('Чай билков', 0.60),
    ('Чай черен/зелен', 0.75),
    ('Мляко', 0.50),
    ('Суха сметана', 0.10),
    ('Течна сметана', 0.15),
    ('Мед', 0.15),
    ('Минерална вода', 0.60),
    ('Безалкохолно', 0.95),
    ('Натурален сок', 1.10);
END
GO

-- Insert initial data into Tables
IF NOT EXISTS (SELECT * FROM Tables)
BEGIN
    INSERT INTO Tables (TableID, IsOccupied) VALUES
    (1, 0),
    (2, 0),
    (3, 0),
    (4, 0),
    (5, 0);
END
GO
