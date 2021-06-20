-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[THONGKE5] (@DiaChi_TinhThanhPho nvarchar(50))
AS
BEGIN
SELECT MaSV,HoTen,NgaySinh,GioiTinh,DiaChi_PhuongXa,DiaChi_QuanHuyen,DiaChi_TinhThanhPho, SINHVIEN.DienThoai, LOPSH.MaLop, KHOA.TenKhoa
FROM SINHVIEN
INNER JOIN
LOPSH ON SINHVIEN.MaLop = LOPSH.MaLop 
INNER  JOIN
KHOA ON LOPSH.TenKhoa = KHOA.TenKhoa
WHERE (DiaChi_TinhThanhPho = @DiaChi_TinhThanhPho)
END
