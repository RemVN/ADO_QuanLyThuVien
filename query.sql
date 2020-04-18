-- create tables

create table CaNhan (
	MaSo int not null IDENTITY(1,1) primary key,
	HoTen nvarchar(100),
	NgaySinh date,
	GioiTinh bit,
	SDT varchar(15),
	DiaChi nvarchar(200)
)

create table SinhVien (
	MaSo int not null, 
	MaKhoa int not null,
	Lop varchar(15),
)

create table Khoa (
	MaKhoa int not null IDENTITY(1,1) primary key,
	TenKhoa varchar(30),
)

create table NhanVien (
	MaSo int not null,
	TenDangNhap varchar(50),
	MatKhau varchar(50),
)	

create table Sach (
	MaSach int not null IDENTITY(1,1) primary key,
	MaLoaiSach int,
	MaViTri int,
	MaNXB int, 
	MaTG int, 
	TenSach nvarchar(200),
	TinhTrang nvarchar(10), 
	NamXB int, 
	GiaSach float
)

create table LoaiSach (
	MaLoaiSach int not null IDENTITY(1,1) primary key,
	TenLoaiSach nvarchar(100)
)

create table ViTri (
	MaViTri int not null IDENTITY(1,1) primary key,
	TenViTri nvarchar(200)
)

create table NXB (
	MaNXB int not null IDENTITY(1,1) primary key,
	TenNXB nvarchar(100)
)

create table MuonTra (
	MSPhieuMuon int not null IDENTITY(1,1) primary key,
	MaSoSV int not null,
	MaSoNV int not null,
	MaSach int not null,
	NgayMuon date,
	NgayHenTra date,
	NgayTra date,
	DaTra bit
)

create table TacGia (
	MaTG int not null IDENTITY(1,1) primary key,
	TenTacGia nvarchar(100),
	SDT varchar(15),
)

alter table SinhVien add foreign key (MaSo) references CaNhan(MaSo)
alter table NhanVien add foreign key (MaSo) references CaNhan(MaSo)

alter table MuonTra add foreign key (MaSoSV) references CaNhan(MaSo)
alter table MuonTra add foreign key (MaSoNV) references CaNhan(MaSo)
alter table MuonTra add foreign key (MaSach) references Sach(MaSach)

alter table Sach add foreign key (MaLoaiSach) references LoaiSach(MaLoaiSach)
alter table Sach add foreign key (MaViTri) references ViTri(MaViTri)
alter table Sach add foreign key (MaNXB) references NXB(MaNXB)
alter table Sach add foreign key (MaTG) references TacGia(MaTG)


-- insert test data

insert into CaNhan (HoTen, NgaySinh, GioiTinh, SDT, DiaChi) values 
(N'Nguyễn Văn A', '19990523', 1, '0912312351', 'TPHCM')

