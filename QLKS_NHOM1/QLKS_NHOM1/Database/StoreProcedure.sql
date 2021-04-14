
---phong--

CREATE PROCEDURE SP_PHONG_GetAll
AS
BEGIN
  SELECT *
  FROM PHONG
END
GO

CREATE PROCEDURE SP_PHONG_Insert
  @TenPhong NVARCHAR(50),
  @LoaiPhong NVARCHAR(10),
  @GiaPhong int,
  @ChuThich NVARCHAR(50),
  @TinhTrang NVARCHAR(10),
  @MaNV int,
  @MaDichVu int
AS
BEGIN
  INSERT INTO PHONG
    (TenPhong, LoaiPhong, GiaPhong, ChuThich ,TinhTrang , MaNV , MaDichVu )
  VALUES(@TenPhong, @LoaiPhong, @GiaPhong, @ChuThich , @TinhTrang ,@MaNV , @MaDichVu)
END
GO

CREATE PROCEDURE SP_PHONG_Delete
  @MaPhong INT
AS
BEGIN
  UPDATE HOADON
  SET MaPhong = NULL
  WHERE MaPhong = @MaPhong

  UPDATE KHACHHANG
  SET MaPhong = NULL
  WHERE MaPhong = @MaPhong

  DELETE PHONG
  WHERE MaPhong = @MaPhong
END
GO

CREATE PROCEDURE SP_PHONG_Update
  @MaPhong int ,
  @TenPhong NVARCHAR(50),
  @LoaiPhong NVARCHAR(10),
  @GiaPhong int,
  @ChuThich NVARCHAR(50),
  @TinhTrang NVARCHAR(10),
  @MaNV int,
  @MaDichVu int
AS
BEGIN
  UPDATE PHONG
  SET TenPhong = @TenPhong,
  LoaiPhong = @LoaiPhong,
  GiaPhong = @GiaPhong,
  TinhTrang = @TinhTrang,
  MaNV = @MaNV ,
  MaDichVu = @MaDichVu 
  WHERE MaPhong = @MaPhong
END
GO

CREATE PROCEDURE SP_PHONG_Search
  @searchValue NVARCHAR(200)
AS
BEGIN
  SELECT *
  FROM PHONG
  WHERE MaPhong LIKE N'%' + @searchValue + '%'
    OR MaPhong LIKE N'%' + @searchValue + '%'
    OR TenPhong LIKE N'%' + @searchValue + '%'
    OR LoaiPhong LIKE N'%' + @searchValue + '%'
    OR GiaPhong LIKE N'%' + @searchValue + '%'
    OR TinhTrang LIKE N'%' + @searchValue + '%'
	OR MaNV LIKE N'%' + @searchValue + '%'
    OR MaDichVu LIKE N'%' + @searchValue + '%'
END
GO

---nhan vien

CREATE PROCEDURE SP_NHANVIEN_GetAll
AS
BEGIN
  SELECT *
  FROM NHANVIEN
END
GO

--- dich vu

CREATE PROCEDURE SP_DICHVU_GetAll
AS
BEGIN
  SELECT *
  FROM DICHVU
END
GO

CREATE PROCEDURE SP_DICHVU_Insert
  @TenDichVu NVARCHAR(50),
  @Gia int
 
AS
BEGIN
  INSERT INTO DICHVU
    (TenDichVu, Gia)
  VALUES(@TenDichVu, @Gia)
END
GO

CREATE PROCEDURE SP_DICHVU_Delete
  @MaDichVu INT
AS
BEGIN
  UPDATE PHONG
  SET MaDichVu = NULL
  WHERE MaDichVu = @MaDichVu

  DELETE DICHVU
  WHERE MaDichVu = @MaDichVu
END
GO

CREATE PROCEDURE SP_DICHVU_Update
  @MaDichVu int ,
  @TenDichVu NVARCHAR(50),
  @Gia int
AS
BEGIN
  UPDATE DICHVU
  SET TenDichVu = @TenDichVu,
  Gia = @Gia

  WHERE MaDichVu = @MaDichVu
END
GO

CREATE PROCEDURE SP_DICHVU_Search
  @searchValue NVARCHAR(200)
AS
BEGIN
  SELECT *
  FROM DICHVU
  WHERE MaDichVu LIKE N'%' + @searchValue + '%'
    OR TenDichVu LIKE N'%' + @searchValue + '%'
    OR Gia LIKE N'%' + @searchValue + '%'
END
GO