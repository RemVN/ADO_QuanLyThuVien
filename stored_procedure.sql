
-- get table tac gia with offset and limit

create proc getTacGia
	@offset int,
	@limit int
as
begin 
	select * from TacGia tg
	where 1 = 1 
	order by tg.MaTG
	OFFSET @offset ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go

exec getTacGia 0, 10
go

-- get table sach with offset and limit 

create proc getSach
	@offset int,
	@limit int
as
begin 
	select s.MaSach, s.TenSach, s.TinhTrang, s.NamXB, s.GiaSach, l.TenLoaiSach, v.TenViTri, n.TenNXB, tg.TenTacGia, dbo.getTinhTrangMuonTraBookSide(s.MaSach) as MuonTra
	from Sach s, LoaiSach l, ViTri v, NXB n, TacGia tg
	where s.MaLoaiSach = l.MaLoaiSach and s.MaViTri = v.MaViTri
	and s.MaNXB = n.MaNXB and s.MaTG = tg.MaTG
	order by s.MaSach
	OFFSET @offset ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go

-- get table loai sach with offset and limit 

create proc getLoaiSach
	@offset int,
	@limit int
as
begin 
	select * from LoaiSach ls 
	where 1 = 1
	order by ls.MaLoaiSach
	OFFSET @offset ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go

-- get table NXB with offset and limit 

create proc getNXB
	@offset int,
	@limit int
as
begin 
	select * from NXB 
	where 1 = 1
	order by NXB.MaNXB
	OFFSET @offset ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go


-- get table ViTri with offset and limit 

create proc getViTri
	@offset int,
	@limit int
as
begin 
	select * from ViTri vt 
	where 1 = 1
	order by vt.MaViTri
	OFFSET @offset ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go


-- search sach

create proc searchSach
	@MaSach int,
	@TenSach nvarchar(200),
	@TinhTrang nvarchar(10),
	@NamXB int,
	@GiaSach float,
	@LoaiSach nvarchar(100),
	@ViTri nvarchar(100),
	@NXB nvarchar(100),
	@TacGia nvarchar(100),
	@MuonTra int,
	@limit int
as
begin 
	--declare @TinhTrangMuonTra nvarchar(20)
	select 
	s.MaSach, s.TenSach, s.TinhTrang, s.NamXB, s.GiaSach, l.TenLoaiSach, v.TenViTri, n.TenNXB, tg.TenTacGia, dbo.getTinhTrangMuonTraBookSide(s.MaSach) as MuonTra
	from Sach s, LoaiSach l, ViTri v, NXB n, TacGia tg 
	where s.MaLoaiSach = l.MaLoaiSach and s.MaViTri = v.MaViTri
	and s.MaNXB = n.MaNXB and s.MaTG = tg.MaTG
	and (
		(s.MaSach = @MaSach or @MaSach is null)
	and (s.TenSach like CONCAT(@TenSach, '%') or @TenSach is null)
	and (s.TinhTrang = @TinhTrang or @TinhTrang is null)
	and (s.NamXB = @NamXB or @NamXB is null)
	and (s.GiaSach = @GiaSach or @GiaSach is null)
	and (l.TenLoaiSach = @LoaiSach or @LoaiSach is null)
	and (v.TenViTri = @ViTri or @ViTri is null)
	and (n.TenNXB = @NXB or @NXB is null)
	and (tg.TenTacGia = @TacGia or @TacGia is null)
	and (dbo.getMuonTraCode(s.MaSach) = @MuonTra or @MuonTra is null)
	)
	order by s.MaSach
	OFFSET 0 ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go

create function getMuonTraCode
	(@MaSach as int)
returns int
as
begin
	if exists (
		select * from MuonTra where MaSach = @MaSach
		and DaTra = 0
	)
	begin
		return 0;
	end
	return 1;
end
go


exec searchSach null, null, null, null, null, null, null, null, null, 0, 100
go

create proc sp_TinhTrangMuonTra
	@MaSach int
as
begin
	if exists (
		select * from MuonTra where MaSach = @MaSach
		and DaTra = 0
	)
	begin
		return N'đang mượn'
	end
	return N'đã trả'
end
go

create function getTinhTrangMuonTraBookSide
	(@MaSach as int)
returns nvarchar(20)
as
begin
	if exists (
		select * from MuonTra where MaSach = @MaSach
		and DaTra = 0
	)
	begin
		return N'Đang mượn'
	end
	return N'Khả dụng'
end
go

create function getTinhTrangMuonTra
	(@MaSach as int)
returns nvarchar(20)
as
begin
	if exists (
		select * from MuonTra where MaSach = @MaSach
		and DaTra = 0
	)
	begin
		return N'đang mượn'
	end
	return N'đã trả'
end
go


--NHAN VIEN

create proc searchNhanVien
	@MaSo int,
	@TenDangNhap nvarchar(50),
	@ChucVu int,
	@TrangThai int,
	@HoTen nvarchar(100),
	@NgaySinh datetime,
	@GioiTinh int,
	@SDT nvarchar(50),
	@DiaChi nvarchar(150),
	@limit int
as
begin
	select 
	cn.MaSo, nv.TenDangNhap, nv.MatKhau, 
	dbo.getChucVuDisplayName(nv.ChucVu) as ChucVu, 
	dbo.getTrangThaiNhanVienDisplayName(nv.TrangThai) as TrangThai, 
	cn.HoTen, cn.NgaySinh, 
	dbo.getGioiTinhDisplayName(cn.GioiTinh) as GioiTinh, 
	cn.SDT, cn.DiaChi  
	from NhanVien nv, CaNhan cn
	where nv.MaSo = cn.MaSo
	and (
		(@MaSo = nv.MaSo or @MaSo is null)
		and (@TenDangNhap = nv.TenDangNhap or @TenDangNhap is null)
		and (@ChucVu = nv.ChucVu or @ChucVu is null)
		and (@TrangThai = nv.TrangThai or @TrangThai is null)
		and (@HoTen like concat(cn.HoTen, '%') or @HoTen is null)
		and (@NgaySinh = cn.NgaySinh or @NgaySinh is null)
		and (@GioiTinh = cn.GioiTinh or @GioiTinh is null)
		and (@SDT = cn.SDT or @SDT is null)
		and (@DiaChi = cn.DiaChi or @DiaChi is null)
	)
	order by cn.MaSo
	OFFSET 0 ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go

exec searchNhanVien null, null, null, null, null, null, 1, null, null, 100

-- get all author
create proc getAllTacGia
as
begin 
	select * from TacGia where 1=1
end
go

create proc getAllLoaiSach
as
begin 
	select * from LoaiSach where 1=1
end
go

create proc getAllNXB
as
begin 
	select * from NXB where 1=1
end
go

create proc getAllViTri
as
begin 
	select * from ViTri where 1=1
end
go

-- lay du lieu nhan vien

create proc getNhanVien
	@offset int,
	@limit int
as
begin
	select 
	cn.MaSo, nv.TenDangNhap, nv.MatKhau, 
	dbo.getChucVuDisplayName(nv.ChucVu) as ChucVu, 
	dbo.getTrangThaiNhanVienDisplayName(nv.TrangThai) as TrangThai, 
	cn.HoTen, cn.NgaySinh, 
	dbo.getGioiTinhDisplayName(cn.GioiTinh) as GioiTinh, 
	cn.SDT, cn.DiaChi 
	from NhanVien nv, CaNhan cn
	where nv.MaSo = cn.MaSo
	order by cn.MaSo
	OFFSET @offset ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go

exec getNhanVien 0, 100
go

create function getGioiTinhDisplayName
	(@GioiTinh as int)
	returns nvarchar(10)
as
begin
	if (@GioiTinh = 0)
	begin 
		return N'Nữ';
	end
	return N'Nam';
end
go

create function getChucVuDisplayName
	(@ChucVu as int)
	returns nvarchar(30)
as
begin
	if (@ChucVu = 0) begin
		return N'Quản lý';
	end
	return N'Thủ thư';
end
go

create function getTrangThaiNhanVienDisplayName
	(@TinhTrang as int)
	returns nvarchar(30)
as
begin
	if (@TinhTrang = 0)
	begin
		return N'Khoá';
	end
	return N'Mở';
end
go

-- Sinh vien

create proc getSinhVien
	@offset int,
	@limit int
as
begin
	select 
	sv.MaSo, k.TenKhoa, Lop.TenLop, sv.NgayCap, sv.NgayHetHan, cn.HoTen, cn.NgaySinh, dbo.getGioiTinhDisplayName(cn.GioiTinh) as GioiTinh, cn.SDT, cn.DiaChi
	from SinhVien sv, CaNhan cn, Lop, Khoa k
	where 
	sv.MaSo = cn.MaSo and
	sv.MaKhoa = k.MaKhoa and
	sv.MaLop = lop.MaLop 
	order by sv.MaSo
	OFFSET @offset ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go

exec getSinhVien 0, 100
go

create proc searchSinhVien
	@MaSo int,
	@MaKhoa int,
	@MaLop int,
	@NgayCap datetime,
	@NgayHetHan datetime,
	@HoTen nvarchar(50),
	@NgaySinh datetime,
	@GioiTinh int,
	@SDT nvarchar(100),
	@DiaChi nvarchar(150),
	@limit int
as
begin 
	select 
	sv.MaSo, k.TenKhoa, Lop.TenLop, sv.NgayCap, sv.NgayHetHan, cn.HoTen, cn.NgaySinh, dbo.getGioiTinhDisplayName(cn.GioiTinh) as GioiTinh, cn.SDT, cn.DiaChi
	from SinhVien sv, CaNhan cn, Lop, Khoa k
	where 
	sv.MaSo = cn.MaSo and
	sv.MaKhoa = k.MaKhoa and
	sv.MaLop = lop.MaLop and
	(
		(@MaSo = cn.MaSo or @MaSo is null) 
		and (@MaKhoa = k.MaKhoa or @MaKhoa is null)
		and (@MaLop = Lop.MaLop or @MaLop is null)
		and (@NgayCap = sv.NgayCap or @NgayCap is null)
		and (@NgayHetHan =  sv.NgayHetHan or @NgayHetHan is null)
		and (@HoTen = cn.HoTen or @HoTen is null)
		and (@NgaySinh = cn.NgaySinh or @NgaySinh is null) 
		and (@GioiTinh = cn.GioiTinh or @GioiTinh is null)
		and (@SDT = cn.SDT or @SDT is null)
		and (@DiaChi = cn.DiaChi or @DiaChi  is null)
	)
	order by sv.MaSo
	OFFSET 0 ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go

select cn.*, nv.TenDangNhap, nv.MatKhau, nv.TrangThai  from NhanVien nv, CaNhan cn
where nv.MaSo = cn.MaSo

select * from LoaiSach ls 
where 1 = 1
order by ls.MaLoaiSach

select s.MaSach, s.TenSach, s.TinhTrang, s.NamXB, s.GiaSach, l.TenLoaiSach, v.TenViTri, n.TenNXB, tg.TenTacGia 
from Sach s, LoaiSach l, ViTri v, NXB n, TacGia tg
where s.MaLoaiSach = l.MaLoaiSach and s.MaViTri = v.MaViTri
and s.MaNXB = n.MaNXB and s.MaTG = tg.MaTG
order by s.MaSach

select sv.MaSo, k.TenKhoa, sv.Lop, cn.HoTen, cn.NgaySinh, cn.GioiTinh, cn.SDT, cn.DiaChi 
from SinhVien sv, Khoa k, CaNhan cn
where sv.MaSo = cn.MaSo and sv.MaKhoa = k.MaKhoa
order by sv.MaSo

select * from TacGia tg
where tg.TenTacGia like 'Nguyen%' or tg.TenTacGia is null
order by tg.MaTG

