--Lịch dạy 
CREATE TABLE Khoa (
    MaKhoa INT PRIMARY KEY,
    TenKhoa VARCHAR(100) NOT NULL
);
CREATE TABLE Lop (
    MaLop INT PRIMARY KEY,
    TenLop VARCHAR(100) NOT NULL,
    SoSinhVien INT NOT NULL,
);
CREATE TABLE GiangVien (
    MaGiangVien INT PRIMARY KEY,
    Ten VARCHAR(50) NOT NULL,
    Ho VARCHAR(50) NOT NULL,
    MaKhoa INT,
    FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa),
    Email VARCHAR(100) NOT NULL,
    DienThoai VARCHAR(20) NOT NULL
);


CREATE TABLE MonHoc (
    MaMonHoc INT PRIMARY KEY,
    TenMonHoc VARCHAR(100) NOT NULL,
    SoTinChi INT NOT NULL,
    MaKhoa INT FOREIGN KEY REFERENCES Khoa(MaKhoa)
);
CREATE TABLE TietHoc(
	MaTietHoc INT PRIMARY KEY,
	TietBatDau INT,
	TietKetThuc INT,
);
CREATE TABLE LichDay (
    MaLichDay INT ,
    MaGiangVien INT FOREIGN KEY REFERENCES GiangVien(MaGiangVien),
	MaMonHoc INT FOREIGN KEY REFERENCES MonHoc(MaMonHoc),
	MaLop INT FOREIGN KEY REFERENCES Lop(MaLop),
	NgayBatDau Datetime,
	NgayKetThuc Datetime,
    Hocky INT NOT NULL,
    NamHoc INT NOT NULL,
	constraint pk_LichDay primary key (MaLichDay,MaLop)
);
CREATE TABLE ChiTietLichDay (
    MaChiTietLichDay INT ,
    MaLichDay INT,
    MaLop INT,  
    MaMonHoc INT,
    NgayDay VARCHAR(10) NOT NULL,
    MaTietHoc INT,
    TrangThai NVARCHAR(255),
    FOREIGN KEY (MaLichDay, MaLop) REFERENCES LichDay(MaLichDay, MaLop),  
    FOREIGN KEY (MaMonHoc) REFERENCES MonHoc(MaMonHoc),
    FOREIGN KEY (MaTietHoc) REFERENCES TietHoc(MaTietHoc),
	constraint pk_chiTietLichDay primary key (MaChiTietLichDay,MaLichDay,MaMonHoc)
);
