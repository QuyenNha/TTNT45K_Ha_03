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
Create Table KHOA (TenKhoa nvarchar(50) not null primary key,
DiaChi nvarchar(150) not null,
DienThoaiKhoa char(11) not null)
Insert into KHOA(TenKhoa,DiaChi,DienThoaiKhoa)
Values
(N'Hệ thống thông tin quản lý',N'Tầng 1, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113913885'),
(N'Kế toán',N'Tầng 2, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113230885'),
(N'Kiểm toán',N'Tầng 3, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113912485'),
(N'Kinh doanh quốc tế',N'Tầng 4, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05253910885'),
(N'Kinh doanh thương mại',N'Tầng 5, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05115410885'),
(N'Kinh tế',N'Tầng 6, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05118710885'),
(N'Luật',N'Tầng 7, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113910815'),
(N'Luật kinh tế',N'Tầng 8, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113911685'),
(N'Quản lý nhà nước',N'Tầng 10, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113110885'),
(N'Quản trị dịch vụ du lịch và lữ hành',N'Tầng 100, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113110885'),
(N'Marketing',N'Tầng 11, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113922885'),
(N'Quản trị khách sạn',N'Tầng 14, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05126910885'),
(N'Quản trị kinh doanh',N'Tầng 15, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05126910885'),
(N'Quản trị nhân lực',N'Tầng 16, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113910275'),
(N'Tài chính - Ngân hàng',N'Tầng 17, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05262391885'),
(N'Thống kê kinh tế',N'Tầng 18, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','05113923185'),
(N'Thương mại điện tử',N'Tầng 19, Tòa nhà Đà nẵng, Trường ĐHKT-ĐHĐN','0511391081')
Select * from KHOA

--Bảng LOPSINHHOAT
Create Table LOPSH (MaLop char(7) not null primary key,
TenLop nvarchar(50) not null,
TenKhoa nvarchar(50) not null,
Constraint FK_TenKhoa Foreign Key (TenKhoa) References KHOA(TenKhoa))
Insert into LOPSH (MaLop,TenLop,TenKhoa)
Values
(N'45K01',N'Ngoại thương',N'Kinh doanh quốc tế'),
(N'45K02',N'Quản trị kinh doanh tổng quát',N'Quản trị kinh doanh'),
(N'45K03',N'Quản trị kinh doanh du lịch',N'Quản trị dịch vụ du lịch và lữ hành'),
(N'45K04',N'Kinh tế phát triển',N'Kinh tế'),
(N'45K05',N'Thống kê Kinh tế - Xã hội',N'Thống kê kinh tế'),
(N'45K06',N'Kế toán',N'Kế toán'),
(N'45K07',N'Ngân Hàng',N'Tài chính - Ngân Hàng'),
(N'45K08',N'Quản trị kinh doanh thương mai',N'Kinh doanh thương mại'),
(N'45K09',N'Quản trị Marketing',N'Marketing'),
(N'45K12',N'Kinh tế chính trị',N'Quản lý nhà nước'),
(N'45K13',N'Luật kinh doanh',N'Luật kinh tế'),
(N'45K14',N'Tin học quản lý',N'Hệ thống thông tin quản lý'),
(N'45K15',N'Tài chính doanh nghiệp',N'Tài chính - Ngân hàng'),
(N'45K16',N'Quản trị tài chính',N'Quản trị kinh doanh'),
(N'45K17',N'Quản trị nguồn nhân lực',N'Quản trị nhân lực'),
(N'45K18',N'Kiểm toán',N'Kiểm toán'),
(N'45K19',N'Luật học',N'Luật'),
(N'45K20',N'Kinh tế đầu tư',N'Kinh tế'),
(N'45K21',N'Quản trị hệ thống thông tin',N'Hệ thống thông tin quản lý'),
(N'45K22',N'Thương mại điện tử',N'Thương mại điện tử'),
(N'45K23',N'Quản trị khách sạn',N'Quản trị khách sạn'),
(N'45K25',N'Quản trị chuỗi cung ứng và logistics',N'Quản trị kinh doanh'),
(N'45K26',N'Quản trị sự kiện',N'Quản trị dịch vụ du lịch và lữ hành'),
(N'45K27',N'Hành chính công',N'Quản lý nhà nước'),
(N'45K28',N'Truyền thông Marketing',N'Marketing')
Select * from LOPSH

--Bảng SINHVIEN
Create Table SINHVIEN (MaSV char(12) not null primary key,
HoTen nvarchar(50) not null,
NgaySinh Date not null,
GioiTinh nvarchar(10) not null,
Diachi nvarchar(120),
DienThoai char(10) not null,
MaLop char(7) not null,
DiemTB char(3) not null,
Constraint FK_MaLop Foreign Key (MaLop) References LOPSH(MaLop))
Insert into SINHVIEN(MaSV,HoTen,NgaySinh,GioiTinh,Diachi,DienThoai,MaLop,DiemTB)
Values
('191121514100',N'Nguyễn Văn Thanh',N'2001-01-13',N'Nam',N'Đà Nẵng','0978745767',N'45K01',N'9,5'),
('191121514101',N'Nguyễn Thị Thanh Thảo',N'2001-11-20',N'Nữ',N'Đà Nẵng','0832413797',N'45K03',N'8,5'),
('191121514102',N'Hoàng Trung Hiếu',N'2000-10-23',N'Nam',N'Quảng Trị','0345675123',N'45K05',N'7,5'),
('191121514103',N'Trương Thị Thanh Huyền',N'2001-04-05',N'Nữ',N'Hà Tĩnh','0373467132',N'45K07',N'10'),
('191121514104',N'Trần Thị Thanh Nhã',N'2001-11-25',N'Nữ',N'Quảng Ngãi','0349716160',N'45K15',N'9'),
('191121514105',N'Nguyễn Thị Thanh Bình',N'2001-03-03',N'Nữ',N'Quảng Nam','0345675505',N'45K17',N'5'),
('191121514106',N'Trần Thị Kim Liên',N'2001-02-10',N'Nữ',N'Gia Lai','0969296103',N'45K21',N'10'),
('191121514107',N'Tôn Thất Nhật Tôn',N'2001-06-07',N'Nam',N'Quảng Bình','0363450172',N'45K22',N'7'),
('191121514128',N'Trần Đỗ Hòa',N'2001-12-06',N'Nam',N'Huế','0976780737',N'45K14',N'10'),
('191121514120',N'Chế Thị Nhã Quyên',N'2001-07-31',N'Nữ',N'Huế','0344463107',N'45K14',N'9')
Select * from SINHVIEN

--Bảng DIEMSINHVIEN
Create Table DIEMSV (MaSV char(12) not null, 
MaLop char(7) not null,
DiemTong float
primary key (MaSV,MaLop),
Constraint FK_MaSV Foreign Key (MaSV) References SINHVIEN(MaSV),
Constraint FK_MaLop1 Foreign Key (MaLop) References LOPSH(MaLop))
Select * from DIEMSV

--Xem bảng
Select * from TAIKHOAN
Select * from KHOA
Select * from LOPSH
Select * from SINHVIEN
Select * from DIEMSV
