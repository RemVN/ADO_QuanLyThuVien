USE [QuanLyThuVien]
GO
SET IDENTITY_INSERT [dbo].[CaNhan] ON 

INSERT [dbo].[CaNhan] ([MaSo], [HoTen], [NgaySinh], [GioiTinh], [SDT], [DiaChi]) VALUES (12, N'Trương Gia Khang', CAST(N'2000-11-23' AS Date), 1, N'0931123', N'Biên Hoà')
SET IDENTITY_INSERT [dbo].[CaNhan] OFF
INSERT [dbo].[NhanVien] ([MaSo], [TenDangNhap], [MatKhau], [TrangThai], [ChucVu]) VALUES (12, N'admin', N'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', 1, 0)
