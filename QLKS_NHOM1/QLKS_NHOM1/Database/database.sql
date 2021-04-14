CREATE DATABASE QL_KS


GO
USE QL_KS







CREATE TABLE NHANVIEN
(
			MaNV INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
			HoTen NVARCHAR(50),
			SDT	int,
			NgaySinh DATE,
			DiaChi NVARCHAR(50),
			GioiTinh NCHAR(3),
			ChucVu NCHAR(10)
			
)


CREATE TABLE DICHVU
(
			MaDichVu INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
			TenDichVu NVARCHAR(50),
			Gia int
)
CREATE TABLE PHONG
(
			MaPhong INT IDENTITY(1,1) PRIMARY KEY NOT NULL	,
			TenPhong NVARCHAR(50),
			LoaiPhong NVARCHAR(10),
			GiaPhong int,
			ChuThich NVARCHAR(50),
			TinhTrang NVARCHAR(10),

			MaNV int REFERENCES NHANVIEN(MaNV),
			MaDichVu int REFERENCES DICHVU(MaDichVu)
)
CREATE TABLE HOADON
(
			MaHD INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
			MaNV int REFERENCES NHANVIEN(MaNV),
			MaPhong INT REFERENCES PHONG(MaPhong),
			Ngay Date,
			GiaHD int

)

CREATE TABLE KHACHHANG
(
			MaKH INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
			HoTen NVARCHAR(10),
			CMND int,
			GioiTinh NVARCHAR(3),
			Tuoi int,
			SDT int,
			MaPhong INT REFERENCES PHONG(MaPhong)


			
			
)
CREATE TABLE TAIKHOAN
(


			MaTK INT IDENTITY(1,1),
			TenTk NVARCHAR(10),
			MK int



)