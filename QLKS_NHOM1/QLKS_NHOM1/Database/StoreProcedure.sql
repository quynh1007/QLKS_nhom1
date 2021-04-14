
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