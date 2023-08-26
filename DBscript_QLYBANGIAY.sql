USE master
GO
/*******************************************************************************
	XÓA DATABASE NẾU NÓ ĐÃ TỒN TẠI
*******************************************************************************/
IF EXISTS (SELECT NAME FROM master.DBO.SYSDATABASES WHERE NAME = 'QuanLyBanGiay')
BEGIN
	ALTER DATABASE QuanLyBanGiay SET OFFLINE WITH ROLLBACK IMMEDIATE;
	ALTER DATABASE QuanLyBanGiay SET ONLINE;
	DROP DATABASE QuanLyBanGiay;
END
GO

CREATE DATABASE QuanLyBanGiay
GO

USE QuanLyBanGiay
GO

/********************************************************************************
CREATE TABLE
********************************************************************************/

CREATE TABLE [Nhân viên]
(
	[Mã nhân viên] varchar(8) PRIMARY KEY ,
	[Họ tên nhân viên] nvarchar(30) NOT NULL,
	[Ngày sinh] date NOT NULL,
	[Sđt] varchar(10) NOT NULL
);

CREATE TABLE [Tài khoản]
(
	[Tên người dùng] varchar(8) PRIMARY KEY REFERENCES [Nhân viên],
	[Mật khẩu] varchar(15) NOT NULL,
	[Chức vụ] varchar(8)
);

CREATE TABLE [NSX]
(
	[Mã NSX] varchar(8) PRIMARY KEY,
	[Tên NSX] nvarchar(30),
	[Quốc gia] nvarchar(30)
);

CREATE TABLE [Nhà phân phối]
(
	[Mã nhà phân phối] varchar(8) PRIMARY KEY,
	[Tên nhà phân phối] nvarchar(30),
	[Địa chỉ] nvarchar(40),
	[Sđt] varchar(10)
);

CREATE TABLE [Phân phối]
(
	[Mã NSX] varchar(8) REFERENCES [NSX],
	[Mã nhà phân phối] varchar(8) REFERENCES [Nhà phân phối]
);

CREATE TABLE [Giày]
(
	[Mã giày] varchar(8) PRIMARY KEY,
	[Tên giày] nvarchar(30) NOT NULL,
	[Nhà sản xuất] nvarchar(30),
	[Size] float,
	[Màu] nvarchar(20),
	[Số lượng] int,
	[Giá] real NOT NULL
);

CREATE TABLE [Khách hàng]
(
	[Mã khách hàng] varchar(8) PRIMARY KEY,
	[Tên khách hàng] nvarchar(30),
	[Sđt] varchar(10),
	[Địa chỉ] nvarchar(40)
);

CREATE TABLE [Hóa đơn bán hàng]
(
	[Mã hóa đơn] varchar(8) PRIMARY KEY,
	[Mã khách hàng] varchar(8) REFERENCES [Khách hàng],
	[Mã giày] varchar(8) REFERENCES [Giày],
	[Số lượng] int
);

CREATE TABLE [Hóa đơn nhập hàng]
(
	[Mã hóa đơn] varchar(8) PRIMARY KEY,
	[Mã nhà phân phối] varchar(8) REFERENCES [Nhà phân phối],
	[Mã giày] varchar(8) REFERENCES [Giày],
	[Số lượng] int
);

/**********************************************************************
	THÊM DỮ LIỆU 
**********************************************************************/
--Thêm nhân viên
INSERT INTO [Nhân viên]
VALUES
	('TTKN0001', N'Trần Thị Khánh Nhi', '2003-04-11', '0123456789'),
	('TGH00002', N'Trần Gia Huy', '2003-7-14', '0987654321'),
	('TNNT0003', N'Trần Nguyễn Nam Thuận', '2003-03-15', '0987612345');

--Thêm tài khoản
INSERT INTO [Tài khoản]
VALUES
	('TTKN0001', '123456789','Admin'),
	('TGH00002', '123456789',''),
	('TNNT0003', '123456789','');
	
--Thêm NXS
INSERT INTO [NSX]
VALUES
	('00105321', N'Nike', N'Hoa Kỳ'),
	('40609789', N'Puma', N'Đức'),
	('40573879', N'Adidas', N'Đức'),
	('80056104', N'Gucci', N'Ý'),
	('00152110', N'Vans', N'Hoa Kỳ');

--Thêm nhà phân phối

INSERT INTO [Nhà phân phối]
VALUES
	('10000000',N'Nike Việt Nam',N'Việt Nam','0123456789'),
	('20000000',N'Puma Việt Nam',N'Việt Nam','0987654321'),
	('30000000',N'Adidas Việt Nam',N'Việt Nam','0987612345'),
	('40000000',N'Gucci Việt Nam',N'Việt Nam','0234598761'),
	('50000000',N'Vans Việt Nam',N'Việt Nam', '0456712389');

--Thêm Phân Phối
INSERT INTO [Phân phối]
VALUES
	('00105321', '10000000'),
	('40609789', '20000000'),
	('40573879', '30000000'),
	('80056104', '40000000'),
	('00152110', '50000000');

----Thêm Chi tiết giày

----Thêm Khách hàng

----Thêm hóa đơn bán hàng

----Thêm hóa đơn nhập hàng

/*********************************************************************
	Procedure
*********************************************************************/
go
CREATE PROC Tai_khoan_login
@Username varchar(8),
@Password varchar(15)
as
begin
	if exists (select * from [Tài khoản] where [Tên người dùng] = @Username and [Mật khẩu] = @Password)
        select 0 as code
    else if exists(select * from [Tài khoản] where [Tên người dùng] = @Username and [Mật khẩu] != @Password) 
        select 1 as code
    else select 2 as code
end
go

GO
CREATE PROC Khach_hang
@MaKhachHang varchar(8)

AS
BEGIN
	IF EXISTS (SELECT [Mã khách hàng] FROM [Khách hàng] WHERE [Mã khách hàng] = @MaKhachHang)
		SELECT 1 AS CODE
	ELSE SELECT 0 AS CODE
END
GO

