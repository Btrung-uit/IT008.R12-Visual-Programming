IF DB_ID(N'QuanLySanPham') IS NULL
    CREATE DATABASE QuanLySanPham;
GO

USE QuanLySanPham;
GO

IF OBJECT_ID(N'dbo.SanPham', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.SanPham
    (
        MaSanPham varchar(5) NOT NULL PRIMARY KEY,
        TenSanPham nvarchar(100) NOT NULL,
        SoLuong int NOT NULL CHECK (SoLuong >= 0),
        DonGia decimal(18, 2) NOT NULL CHECK (DonGia >= 0),
        DonViTinh nvarchar(20) NOT NULL
    );
END;
GO

IF NOT EXISTS (SELECT 1 FROM dbo.SanPham)
BEGIN
    INSERT INTO dbo.SanPham (MaSanPham, TenSanPham, SoLuong, DonGia, DonViTinh)
    VALUES
        ('SP001', N'Bột giặt OMO', 800, 50000, N'Bịch'),
        ('SP002', N'Pepsi', 500, 200000, N'Thùng'),
        ('SP003', N'Dầu ăn Trường An', 200, 120000, N'Thùng');
END;
GO
