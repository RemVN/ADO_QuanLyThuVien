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
		(s.MaSach = @MaSach)
	or (s.TenSach like CONCAT(@TenSach, '%') and @TenSach is not null)
	or (s.TinhTrang = @TinhTrang and @TinhTrang is not null)
	or (s.NamXB = @NamXB and @NamXB is not null)
	or (s.GiaSach = @GiaSach and @GiaSach is not null)
	or (l.TenLoaiSach like CONCAT(@LoaiSach, '%') and @LoaiSach is not null)
	or (v.TenViTri like CONCAT(@ViTri, '%') and @ViTri is not null)
	or (n.TenNXB like CONCAT(@NXB, '%') and @NXB is not null)
	or (tg.TenTacGia like CONCAT(@TacGia, '%') and @TacGia is not null)
	or (
		dbo.getMuonTraCode(s.MaSach) = @MuonTra
		and @MuonTra != -1)
	)
	order by s.MaSach
	OFFSET 0 ROWS
	FETCH NEXT @limit ROWS ONLY;
end
go