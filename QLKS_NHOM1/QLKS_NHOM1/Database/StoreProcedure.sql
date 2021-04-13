USE QL_KS

-----------------------Thiệp Khách Hàng------------------------
CREATE PROCEDURE SP_KHACHHANG_GetAll
AS
BEGIN
  SELECT *
  FROM KHACHHANG
END
GO

CREATE PROCEDURE SP_KHACHHANG_Insert
  @HoTen NVARCHAR(50),
  @CMND INT,
  @GioiTinh NVARCHAR(3),
  @Tuoi INT,
  @SDT INT,
  @MaPhong INT
AS
BEGIN
  INSERT INTO KHACHHANG
    (HoTen, CMND, GioiTinh, Tuoi, SDT, MaPhong)
  VALUES(@HoTen, @CMND, @GioiTinh, @Tuoi, @SDT, @MaPhong)
END
GO

CREATE PROCEDURE SP_KHACHHANG_Delete
  @MaKH INT
AS
BEGIN
  DELETE KHACHHANG
  WHERE MaKH = @MaKH
END
GO

CREATE PROCEDURE SP_KHACHHANG_Update
  @MaKH INT,
  @HoTen NVARCHAR(50),
  @CMND INT,
  @GioiTinh NVARCHAR(3),
  @Tuoi INT,
  @SDT INT,
  @MaPhong INT
AS
BEGIN
  UPDATE KHACHHANG
  SET HoTen = @HoTen,
	  CMND = @CMND,
	  GioiTinh = @GioiTinh,
	  Tuoi = @Tuoi,
	  SDT = @SDT,
	  MaPhong = @MaPhong
  WHERE MaKH = @MaKH
END
GO

CREATE PROCEDURE SP_KHACHHANG_Search
  @searchValue NVARCHAR(200)
AS
BEGIN
  SELECT *
  FROM KHACHHANG
  WHERE MaKH LIKE N'%' + @searchValue + '%'
    OR  HoTen LIKE N'%' + @searchValue + '%'
    OR  CMND LIKE N'%' + @searchValue + '%'
    OR  GioiTinh LIKE N'%' + @searchValue + '%'
    OR  Tuoi LIKE N'%' + @searchValue + '%'
	OR  SDT LIKE N'%' + @searchValue + '%'
    OR  MaPhong LIKE N'%' + @searchValue + '%'
END
GO

CREATE PROCEDURE SP_PHONG_GetAll
AS
BEGIN
  SELECT *
  FROM PHONG
END
GO
