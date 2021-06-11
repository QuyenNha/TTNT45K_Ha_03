Create Database QLHSSV
Use QLHSSV

--Bảng TAIKHOAN
Create Table TAIKHOAN (TaiKhoan varchar(30) not null primary key,
MatKhau char(8) not null)

--Bảng KHOA
Create Table KHOA (MaKhoa char(3) not null primary key,
TenKhoa nvarchar(20) not null,
DiaChi nvarchar(150) not null,
DienThoaiKhoa char(11) not null)

--Bảng LOPSINHHOAT
Create Table LOPSH (MaLop char(7) not null primary key,
TenLop nvarchar(50) not null,
MaKhoa char(3) not null,
Constraint FK_MaKhoa Foreign Key (MaKhoa) References KHOA(MaKhoa))

--Bảng SINHVIEN
Create Table SINHVIEN (MaSV char(12) not null primary key,
HoTen nvarchar(50) not null,
NgaySinh Date not null,
GioiTinh nvarchar(10) not null,
Diachi nvarchar(120),
DienThoai char(10) not null,
MaLop char(7) not null,
Constraint FK_MaLop Foreign Key (MaLop) References LOPSH(MaLop))

--Bảng DIEMSINHVIEN
Create Table DIEMSV (MaSV char(12) not null, 
MaLop char(7) not null,
DiemTong float
primary key (MaSV,MaLop),
Constraint FK_MaSV Foreign Key (MaSV) References SINHVIEN(MaSV),
Constraint FK_MaLop1 Foreign Key (MaLop) References LOPSH(MaLop))


--
Select * from TAIKHOAN
Select * from KHOA
Select * from LOPSH
Select * from SINHVIEN
Select * from DIEMSV


