create database db_may28

go
use db_may28

go


CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    TenDN VARCHAR(20),
    MatKhau VARCHAR(30)
);
go
CREATE TABLE SINHVIEN(
	mssv varchar(20),
	TenSV nvarchar(50),
	MaLop char(10),
	NgaySinh nvarchar(11),
	GioiTinh nvarchar(5),
	CMND nvarchar(20)
)
INSERT INTO SINHVIEN (mssv, TenSV, MaLop, NgaySinh, GioiTinh, CMND)
VALUES 
('SV001', 'Nguyen Van A', 'L01', '01/01/2000', 'Nam', '123456789'),
('SV002', 'Tran Thi B', 'L02', '02/02/2001', 'Nu', '987654321'),
('SV003', 'Le Thi C', 'L03', '03/03/2002', 'Nu', '456789123'),
('SV004', 'Pham Van D', 'L04', '04/04/2003', 'Nam', '321654987'),
('SV005', 'Hoang Thi E', 'L05', '05/05/2004', 'Nu', '789456123');

insert into users values('a','a')
select*from users
select*from SINHVIEN