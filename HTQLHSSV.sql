Create Database QLHSSV
Use QLHSSV

--Bảng TAIKHOAN
Create Table TAIKHOAN (TaiKhoan varchar(30) not null primary key,
MatKhau char(8) not null)
Insert into TAIKHOAN (TaiKhoan,MatKhau)
Values
('QuyenNha','12345678'),
('TranDoHoa','87654321')
Select * from TAIKHOAN

--Bảng KHOA
Create Table KHOA (TenKhoa nvarchar(20) not null primary key,
DiaChi nvarchar(150) not null,
DienThoaiKhoa char(11) not null)
Insert into KHOA(TenKhoa,DiaChi,DienThoaiKhoa)
Values
(N'Thống kê - Tin học',N'Khoa TK-TH, Tầng 6, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','05113910885'),
(N'Marketing',N'Khoa Marketing, Tầng 6, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','02363525358'),
(N'Kế toán',N'Khoa Kế toán, Tầng 7, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','02363836987'),
(N'Quản trị kinh doanh',N'Khoa Quản trị kinh doanh, Tầng 5, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','0236836934'),
(N'Du lịch',N'Khoa Du lịch, Tầng 7, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','05113912668'),
(N'Kinh doanh quốc tế',N'Khoa Kinh doanh quốc tế, Tầng 4, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','02363936935'),
(N'Thương mại điện tử',N'Khoa Thương mại điện tử, Tầng 4, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','02363985912'),
(N'Tài chính',N'Khoa Tài chính, Tầng 5, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','02363525459'),
(N'Kinh tế',N'Khoa Kinh tế, Tầng 7, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','05113836923'),
(N'Luật',N'Khoa Luật, Tầng 6, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','05113958418'),
(N'Ngân hàng',N'Khoa Ngân hàng, Tầng 4, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','02363847001'),
(N'Lý luận chính trị',N'Khoa Lý luận chính trị, Tầng 5, Tòa nhà Đa năng, Trường ĐHKT-ĐHĐN','02363956185')
Select * from KHOA

--Bảng LOPSINHHOAT
Create Table LOPSH (MaLop char(7) not null primary key,
TenLop nvarchar(50) not null,
TenKhoa nvarchar(20) not null,
Constraint FK_TenKhoa Foreign Key (TenKhoa) References KHOA(TenKhoa))
Insert into LOPSH (MaLop,TenLop,TenKhoa)
Values
(N'45K01',N'Kinh doanh quốc tế',N'Kinh doanh quốc tế'),
(N'45K03',N'Du lịch',N'Du lịch'),
(N'45K04',N'Kinh tế',N'Kinh tế'),
(N'45K05',N'Thống tế',N'Thống kê - Tin học'),
(N'45K06',N'Kế toán',N'Kế toán'),
(N'45K07',N'Ngân hàng',N'Ngân hàng'),
(N'45K08',N'Kinh doanh thương mại',N'Thương mại điện tử'),
(N'45K12',N'Quản trị Marketing',N'Marketing'),
(N'45K13',N'Luật kinh tế',N'Luật'),
(N'45K14',N'Tin học quản lý',N'Thống kê - Tin học'),
(N'45K15',N'Tài chính doanh nghiệp',N'Tài chính'),
(N'45K17',N'Quản trị nguồn nhân lực',N'Quản trị kinh doanh'),
(N'45K21.1',N'Quản trị Hệ thống thông tin',N'Thống kê - Tin học'),
(N'45K21.2',N'Quản trị Hệ thống thông tin',N'Thống kê - Tin học'),
(N'45K22',N'Thương mại điện tử',N'Thương mại điện tử'),
(N'45K27',N'Lý luận chính trị',N'Lý luận chính trị')
Select * from LOPSH

--Bảng SINHVIEN
Create Table SINHVIEN (MaSV char(12) not null primary key,
HoTen nvarchar(50) not null,
NgaySinh Date not null,
GioiTinh nvarchar(10) not null,
Diachi nvarchar(120),
DienThoai char(10) not null,
MaLop char(7) not null,
Constraint FK_MaLop Foreign Key (MaLop) References LOPSH(MaLop))
Insert into SINHVIEN(MaSV,HoTen,NgaySinh,GioiTinh,Diachi,DienThoai,MaLop)
Values
('191121514100',N'Nguyễn Văn Thanh',N'2001-01-13',N'Nam',N'Đà Nẵng','0978745767',N'45K01'),
('191121514101',N'Nguyễn Thị Thanh Thảo',N'2001-11-20',N'Nữ',N'Đà Nẵng','0832413797',N'45K03'),
('191121514102',N'Hoàng Trung Hiếu',N'2000-10-23',N'Nam',N'Quảng Trị','0345675123',N'45K05'),
('191121514103',N'Trương Thị Thanh Huyền',N'2001-04-05',N'Nữ',N'Hà Tĩnh','0373467132',N'45K07'),
('191121514104',N'Trần Thị Thanh Nhã',N'2001-11-25',N'Nữ',N'Quảng Ngãi','0349716160',N'45K15'),
('191121514105',N'Nguyễn Thị Thanh Bình',N'2001-03-03',N'Nữ',N'Quảng Nam','0345675505',N'45K17'),
('191121514106',N'Trần Thị Kim Liên',N'2001-02-10',N'Nữ',N'Gia Lai','0969296103',N'45K21.1'),
('191121514107',N'Tôn Thất Nhật Tôn',N'2001-06-07',N'Nam',N'Quảng Bình','0363450172',N'45K22'),
('191121514128',N'Trần Đỗ Hòa',N'2001-12-06',N'Nam',N'Huế','0976780737',N'45K14'),
('191121514120',N'Chế Thị Nhã Quyên',N'2001-07-31',N'Nữ',N'Huế','0344463107',N'45K14')
Select * from SINHVIEN

--Bảng DIEMSINHVIEN
Create Table DIEMSV (MaSV char(12) not null, 
MaLop char(7) not null,
DiemTong float
primary key (MaSV,MaLop),
Constraint FK_MaSV Foreign Key (MaSV) References SINHVIEN(MaSV),
Constraint FK_MaLop1 Foreign Key (MaLop) References LOPSH(MaLop))
Insert into DIEMSV(MaSV,MaLop,DiemTong)
Values
('191121514100',N'45K01',8.4),
('191121514101',N'45K03',8.8),
('191121514102',N'45K05',8.0),
('191121514103',N'45K07',9.2),
('191121514104',N'45K15',7.5),
('191121514105',N'45K17',9.8),
('191121514106',N'45K21.1',7.8),
('191121514107',N'45K22',6.7),
('191121514128',N'45K14',10),
('191121514120',N'45K14',10)
Select * from DIEMSV

--Xem bảng
Select * from TAIKHOAN
Select * from KHOA
Select * from LOPSH
Select * from SINHVIEN
Select * from DIEMSV
