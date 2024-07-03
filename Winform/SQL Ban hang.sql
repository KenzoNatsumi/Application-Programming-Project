USE MASTER
GO
CREATE DATABASE QLBANHANGDIENLANH
GO
USE QLBANHANGDIENLANH
GO
CREATE TABLE NHACUNGCAP
(
MaNCC varchar (10) primary key not null,
TenNCC nvarchar (50) not null,
)
go
Create table KHACHHANG
(
MaKH varchar (10) primary key not null,
TenKH nvarchar (50) not null,
Diachi nvarchar (50) null,
SoDT nvarchar (20) null,
)
go
create table NHANVIEN
(
MaNV varchar (10) primary key not null,
TenNV nvarchar (50) not null,
GioiTinh nvarchar (10) default N'Nam' ,
Diachi nvarchar (50) null,
SoDT nvarchar (20)null,
NgaySinh datetime default getdate() null,
)
go
create table SANPHAM
(
MaSP varchar (10) primary key not null,
TenSP nvarchar (50) not null,
MaNCC varchar (10) foreign key (MaNCC) references NHACUNGCAP(MaNCC),
SoLuong int not null,
GiaNhap money not null,
GiaBan money not null,
GhiChu nvarchar (50) null,
)
go
create table HOADON
(
MaHD varchar (10) primary key not null,
MaNV varchar (10) foreign key (MaNV) references NHANVIEN(MaNV) not null,
MaKH varchar (10) foreign key (MaKH) references KHACHHANG(MaKH) not null,
NgayBan datetime default getdate() null,
TongTien money not null,
)
go
Create Table CTHD
(
MaHD varchar (10),
MaSP varchar (10),
SoLuong int null,
DonGia money null,
GiamGia money null,
ThanhTien money null,
primary key (MaHD,MaSP),
foreign key (MaHD) references HOADON(MaHD),
foreign key (MaSP) references SANPHAM(MaSP),
)
GO
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC]) VALUES ('NCC01', N'SUNHOUSE')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC]) VALUES ('NCC02', N'KANGAROO')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC]) VALUES ('NCC03', N'HP')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC]) VALUES ('NCC04', N'NAGAKAWA')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC]) VALUES ('NCC05', N'LG')
GO
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [Diachi], [SoDT]) VALUES ('KH01', N'Nguyễn Văn A', N'Hà Nội', '123456789')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [Diachi], [SoDT]) VALUES ('KH02', N'Nguyễn Văn B', N'Hải Phòng', '123456489')
INSERT [dbo].[KHACHHANG] ([MaKH], [TenKH], [Diachi], [SoDT]) VALUES ('KH03', N'Trần Phước C', N'Bà Rịa - Vũng Tàu','123436789')
GO
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [Diachi], [SoDT], [NgaySinh]) VALUES ('NV01', N'Lê Nguyễn Đăng Khoa', N'Nam', N'TPHCM', '3414567890', CAST(N'2005-04-11T00:00:00' AS SmallDateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [Diachi], [SoDT], [NgaySinh]) VALUES ('NV02', N'Bùi Công Hậu', N'Nam', N'TPHCM', '3414567390', CAST(N'2005-05-09T00:00:00' AS SmallDateTime))
INSERT [dbo].[NHANVIEN] ([MaNV], [TenNV], [GioiTinh], [Diachi], [SoDT], [NgaySinh]) VALUES ('NV03', N'Bùi Hoàng Huy', N'Nam', N'TPHCM', '3414567190', CAST(N'2005-07-16T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [MaNCC], [SoLuong], [GiaNhap], [GiaBan], [GhiChu]) VALUES ('SP01', N'MÁY LỌC NƯỚC RO NÓNG NGUỘI LẠNH HOÀ PHÁT HPN635 10 LÕI', 'NCC03', '30', '60000002', '6690000', N'Bảo hành 1 năm')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [MaNCC], [SoLuong], [GiaNhap], [GiaBan], [GhiChu]) VALUES ('SP02', N'QUẠT ĐIỀU HOÀ SUNHOUSE SHD7745', 'NCC02', '45', '2000000', '2490000', N'Bảo hành 1 năm')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [MaNCC], [SoLuong], [GiaNhap], [GiaBan], [GhiChu]) VALUES ('SP03', N'TỦ ĐÔNG KANGAROO INVERTER 430 LÍT KGFZ490IG1', 'NCC01', '25', '12000000', '12380000', N'Bảo hành 2 năm')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [MaNCC], [SoLuong], [GiaNhap], [GiaBan], [GhiChu]) VALUES ('SP04', N'NAGAKAWA INVERTER 1.5 HP NISC12R2T28', 'NCC04', '23', '6000000', '6790000', N'Bảo hành 1 năm')
INSERT [dbo].[SANPHAM] ([MaSP], [TenSP], [MaNCC], [SoLuong], [GiaNhap], [GiaBan], [GhiChu]) VALUES ('SP05', N'LG INVERTER 1.5 HP V13WIN1', 'NCC05', '30', '10000000', '10790000', N'Bảo hành 2 năm')
GO
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [NgayBan], [TongTien]) VALUES ('HD01', 'NV02', 'KH01', CAST(N'2024-05-16T00:00:00' AS SmallDateTime), '2490000')
INSERT [dbo].[HOADON] ([MaHD], [MaNV], [MaKH], [NgayBan], [TongTien]) VALUES ('HD02', 'NV01', 'KH02', CAST(N'2024-05-04T00:00:00' AS SmallDateTime), '10790000')
GO
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES ('HD01', 'SP02', '1', '2490000', '0', '2490000')
INSERT [dbo].[CTHD] ([MaHD], [MaSP], [SoLuong], [DonGia], [GiamGia], [ThanhTien]) VALUES ('HD02', 'SP05', '1', '10790000', '0', '10790000')
GO