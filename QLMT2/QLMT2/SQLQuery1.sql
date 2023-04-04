create database QLMT2
go
use QLMT2
GO

CREATE TABLE Products
(
	ProductId INT PRIMARY KEY,
	ProductName VARCHAR(50),
	ProductImage VARBINARY(MAX),
	Soluong INT,
	MoTaSanPham NVARCHAR(500),
	GiaBan INT
)
GO
CREATE TABLE Accounts
(
	id INT PRIMARY KEY NOT NULL,
	DisplayName NVARCHAR(100) NOT NULL,
	PASS VARCHAR(1000) NOT NULL
)
GO
CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL,
	DateCheckOut DATE,
	idProduct INT NOT NULL,
	Status INT NOT NULL DEFAULT 0, -- 1 la da thanh toan, 2 la chua thanh toan
	FOREIGN KEY (idProduct) REFERENCES Products(ProductID) 
)

CREATE TABLE BillInfor
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idProduct INT NOT NULL,
	Status INT NOT NULL DEFAULT 0,
	FOREIGN KEY (idBill) REFERENCES Bill(id),
	FOREIGN KEY (idProduct) REFERENCES Products(ProductID)
)

INSERT INTO Accounts VALUES (92264, N'Nguyễn Thế Hiểu', '@Hieu20182021');
INSERT INTO Accounts VALUES (91217, N'Phạm Hồng Hà', 'toikhongbiet');
select * from Accounts
select * from Accounts where id = 92264 and PASS = '@hIEU20182021'