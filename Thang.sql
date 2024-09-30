Create Database QLTruongHoc
use QLTruongHoc

CREATE TABLE Khoa
(
	makhoa int primary key,
	tenkhoa nvarchar(50) not null,
)

CREATE TABLE Lop(
    MaLop INT PRIMARY KEY,
    TenLop VARCHAR(100) NOT NULL,
    SoSinhVien INT,
);

CREATE TABLE Phong(
	MaPhong INT PRIMARY KEY,
	TenPhong VARCHAR(100) NOT NULL,
	SoSinhVien INT,
)

CREATE TABLE GiangVien (
    MaGiangVien INT PRIMARY KEY,
    Ten VARCHAR(50) NOT NULL,
    Ho VARCHAR(50) NOT NULL,
    MaKhoa INT,
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
    Email VARCHAR(100) NOT NULL,
    DienThoai VARCHAR(20) NOT NULL
);

CREATE TABLE SinhVien(
	Masv int PRIMARY KEY,
	Ten nvarchar(50),
	MaKhoa INT,
	FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
	Email VARCHAR(100) NOT NULL,
    DienThoai VARCHAR(20) NOT NULL,
);

CREATE TABLE MonHoc (
    MaMonHoc INT PRIMARY KEY,
    TenMonHoc VARCHAR(100) NOT NULL,
    SoTinChi INT NOT NULL,
    MaKhoa INT FOREIGN KEY REFERENCES Khoa(MaKhoa)
);

CREATE TABLE ThoiGian(
	MaTG int primary key,
	HocKy int,
	NamHoc varchar(30),
)

CREATE TABLE LichHocDuKien(
	MaLHDK int primary key,
	MaMonHoc int FOREIGN KEY REFERENCES MonHoc(MaMonHoc),
	MaGiangVien int FOREIGN KEY REFERENCES GiangVien(MaGiangVien),
	MaPhong int FOREIGN KEY REFERENCES Phong(MaPhong),
	MaTG int FOREIGN KEY REFERENCES ThoiGian(MaTG),
)
CREATE TABLE DangKyMonHoc(
	MaDK int primary key,
	Masv int FOREIGN KEY REFERENCES SinhVien(Masv),
	MaLHDK int FOREIGN KEY REFERENCES LichHocDuKien(MaLHDK),
)
CREATE TABLE DiemHocPhan(
	MaDiemHP int primary key,
	MaDK int FOREIGN KEY REFERENCES DangKyMonHoc(MaDK),
	Diem1 float,
	Diem2 float,
)
