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
DienThoai char(11) not null)
Insert into KHOA(TenKhoa,DiaChi,DienThoai)
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
TenKhoa nvarchar(50) not null,
Constraint FK_TenKhoa Foreign Key (TenKhoa) References KHOA(TenKhoa))
Insert into LOPSH (MaLop,TenLop,TenKhoa)
Values
('45K01',N'Ngoại thương',N'Kinh doanh quốc tế'),
('45K02',N'Quản trị kinh doanh tổng quát',N'Quản trị kinh doanh'),
('45K03',N'Quản trị kinh doanh du lịch',N'Du lịch'),
('45K04',N'Kinh tế phát triển',N'Kinh tế'),
('45K05',N'Thống kê Kinh tế - Xã hội',N'Thống kê - Tin học'),
('45K06',N'Kế toán',N'Kế toán'),
('45K07',N'Ngân hàng',N'Ngân hàng'),
('45K08',N'Quản trị kinh doanh thương mại',N'Thương mại điện tử'),
('45K09',N'Kinh tế chính trị',N'Lý luận chính trị'),
('45K12',N'Quản trị Marketing',N'Marketing'),
('45K13',N'Luật kinh doanh',N'Luật'),
('45K14',N'Tin học quản lý',N'Thống kê - Tin học'),
('45K15',N'Tài chính doanh nghiệp',N'Tài chính'),
('45K16',N'Quản trị tài chính',N'Tài chính'),
('45K17',N'Quản trị nguồn nhân lực',N'Quản trị kinh doanh'),
('45K18',N'Kiểm toán',N'Kế toán'),
('45K19',N'Luật học',N'Luật'),
('45K20',N'Kinh tế đầu tư',N'Kinh tế'),
('45K21',N'Quản trị hệ thống thông tin',N'Thống kê - Tin học'),
('45K22',N'Thương mại điện tử',N'Thương mại điện tử'),
('45K23',N'Quản trị khách sạn',N'Du lịch'),
('45K25',N'Quản trị chuỗi cung ứng và logistics',N'Quản trị kinh doanh'),
('45K26',N'Quản trị sự kiện',N'Du lịch'),
('45K27',N'Hành chính công',N'Lý luận chính trị'),
('45K28',N'Truyền thông Marketing',N'Marketing')
Select * from LOPSH

--Bảng SINHVIEN
Create Table SINHVIEN (MaSV char(12) not null primary key,
HoTen nvarchar(50) not null,
NgaySinh Date not null,
GioiTinh nvarchar(10) not null,
DiaChi nvarchar(120),
DienThoai char(10) not null,
MaLop char(7) not null,
DiemTB float
Constraint FK_MaLop Foreign Key (MaLop) References LOPSH(MaLop))
Insert into SINHVIEN(MaSV,HoTen,NgaySinh,GioiTinh,DiaChi,DienThoai,MaLop,DiemTB)
Values
('191121601102',N'Nguyễn Văn Thanh',N'2001-01-13',N'Nam',N'Đà Nẵng','0978745767','45K01',9),
('191121703455',N'Nguyễn Thị Thanh Thảo',N'2001-11-20',N'Nữ',N'Đà Nẵng','0832413797','45K03',9),
('191121505133',N'Hoàng Trung Hiếu',N'2000-10-23',N'Nam',N'Quảng Trị','0345675123','45K05',9),
('191121407102',N'Trương Thị Thanh Huyền',N'2001-04-05',N'Nữ',N'Hà Tĩnh','0373467132','45K07',9),
('191122015124',N'Trần Thị Thanh Nhã',N'2001-11-25',N'Nữ',N'Quảng Ngãi','0349716160','45K15',9),
('191121317123',N'Nguyễn Thị Thanh Bình',N'2001-03-03',N'Nữ',N'Quảng Nam','0345675505','45K17',9),
('191121521209',N'Trần Thị Kim Liên',N'2001-02-10',N'Nữ',N'Gia Lai','0969296103','45K21',9),
('191124022252',N'Tôn Thất Nhật Tôn',N'2001-06-07',N'Nam',N'Quảng Bình','0363450172','45K22',9),
('191121514108',N'Trần Đỗ Hòa',N'2001-07-09',N'Nam',N'Huế','0762548324','45K14',9),
('191121514120',N'Chế Thị Nhã Quyên',N'2001-07-31',N'Nữ',N'Huế','0344463107','45K14',9)
Select * from SINHVIEN

--Bảng MONPHAN
Create Table MONHOC (MaMH char(7) not null primary key,
TenMH nvarchar(100) not null,
TinChi int,
TenKhoa nvarchar (50) not null,
Constraint FK_TenKhoa1 Foreign key (TenKhoa) References KHOA(TenKhoa))
Insert into MONHOC(MaMH,TenMH,TinChi,TenKhoa)
Values
('HOS3010',N'An ninh và an toàn trong khách sạn',2,N'Du lịch'),
('MIS3006',N'Cấu trúc dữ liệu và giải thuật',3,N'Thống kê - Tin học'),
('MKT3004',N'Chiến lược marketing',3,N'Marketing'),
('SMT3008',N'Tổ chức bộ máy hành chính Nhà nước',3,N'Lý luận chính trị'),
('HRM3001',N'Quản trị nguồn nhân lực',3,N'Quản trị kinh doanh'),
('LAW3030',N'Luật luật sư',2,N'Luật'),
('BAN3001',N'Định giá tài sản',3,N'Tài chính'),
('COM3002',N'Quản trị bán lẻ',3,N'Thương mại điện tử'),
('ACC1001',N'Nguyên lý kế toán',3,N'Kế toán'),
('MIS3005',N'Toán rời rạc',3,N'Thống kê - Tin học')
Select * from MONHOC

--Xem bảng
Select * from TAIKHOAN
Select * from KHOA
Select * from LOPSH
Select * from SINHVIEN
Select * from MONHOC