CREATE DATABASE miniStoreV2;
USE miniStoreV2;

DROP TABLE Orders_Details;


CREATE TABLE Users( --COMPRADOR
	userID INT IDENTITY(1,1) PRIMARY KEY,
	userName VARCHAR(25),
	personalPassword VARCHAR(30),
)
CREATE TABLE Products(
	productID VARCHAR(10) PRIMARY KEY,
	productName VARCHAR(30),
	unitPrice FLOAT,
	productDescription VARCHAR(20), --?
)
CREATE TABLE Orders(
	orderID INT PRIMARY KEY,
	userID INT REFERENCES Users(UserID),
	total FLOAT
)

CREATE TABLE Orders_Details( --aca irian el listado de productos
	idRandom INT IDENTITY(1,1) PRIMARY KEY,
	orderID INT REFERENCES Orders(orderID),
	productID VARCHAR(10) REFERENCES Products(productID),
	quantity INT,
	subtotal FLOAT
)
CREATE TABLE bugsReport(
	reportID INT IDENTITY(1,1) PRIMARY KEY,
	userID INT REFERENCES Users(userID),
	problemDescription TEXT,
	isFixed BIT,  --1(true,resuelto) o 0(false no resuelto)
)
--SELECT * FROM Users;
INSERT INTO Users(userName,personalPassword) VALUES('karlV', 'holamundo');
INSERT INTO Users(userName,personalPassword) VALUES('AndresG', 'androso123');
INSERT INTO Users(userName,personalPassword) VALUES('admin', '123');

--DELETE Orders;
--DELETE Orders_Details;

INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('IP500','IPad', 500, 'IOS + Microsofto 365' );
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('La1000','Laptop Dell', 1000, 'Windows 10' );
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('An100','Antivirus', 100, '1 year' );
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('Vi2000','Visual Studio Enterprise', 2000, '1 year' );
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('Py50','PyCharm', 50, 'Python IDE' );
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('In50','IntelliJ', 50, 'Java IDE' );
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('We500','WebStorm', 500, 'Web IDE' );
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('PS100','PS4 Dualshock', 100, 'First generation' );
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('AR600','Arcade', 600, 'snes games' );
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('VR900','VR', 900, 'Latest version');
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('Ol1500','Oled TV', 1500, '4k + 3D');
INSERT INTO Products(productID, productName, unitPrice, productDescription) VALUES('Ai150','Air Pods', 150, 'First generation');

SELECT * FROM Products ORDER BY productID desc;
SELECT * FROM bugsReport;
SELECT * FROM Orders, Orders_Details where Orders.orderID = Orders_Details.orderID;
SELECT * FROM Orders;

--INSERT INTO Orders(orderID,userID,total) VALUES(156, 1, 999);