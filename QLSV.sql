-- Dùng để xóa Database cũ
USE master; 
DROP DATABASE QuanLySinhVien;

CREATE DATABASE QuanLySinhVien;
GO
USE QuanLySinhVien;
GO
CREATE TABLE admin (
	tk NVARCHAR(50) PRIMARY KEY,
	mk NVARCHAR(50),
);
GO
CREATE TABLE gv (
	tk NVARCHAR(50) PRIMARY KEY,
	mk NVARCHAR(50),
);
CREATE TABLE truongkhoa (
	tk NVARCHAR(50) PRIMARY KEY,
	mk NVARCHAR(50),
);
GO
CREATE TABLE nguoidung (
	tk NVARCHAR(50) PRIMARY KEY,
	mk NVARCHAR(50),
);
GO
CREATE TABLE khoa (
	makhoa NVARCHAR(10) PRIMARY KEY,
	tenkhoa NVARCHAR(50),
);
GO
CREATE TABLE lop (
	malop NVARCHAR(10) PRIMARY KEY,
	tenlop NVARCHAR(50),
	makhoa NVARCHAR(10) FOREIGN KEY REFERENCES khoa(makhoa),
);
GO
CREATE TABLE chinhsach (
	macs NVARCHAR(10) PRIMARY KEY,
	tencs NVARCHAR(50),
	chedo NVARCHAR(50),
);
GO
CREATE TABLE sinhvien (
	masv NVARCHAR(10) PRIMARY KEY,
	tensv NVARCHAR(30),
	gioitinh NVARCHAR(5),
	ngaysinh DATE,
	sdt NVARCHAR(11),
	diachi NVARCHAR(50),
	macs NVARCHAR(10) FOREIGN KEY REFERENCES chinhsach(macs),
	malop NVARCHAR(10) FOREIGN KEY REFERENCES lop(malop),
);
GO
CREATE TABLE giaovien (
	magv NVARCHAR(10) PRIMARY KEY,
	tengv NVARCHAR(30),
	gioitinh NVARCHAR(5),
	ngaysinh DATE,
	sdt NVARCHAR(11),
	diachi NVARCHAR(50),
);
GO
CREATE TABLE monhoc (
	mamh NVARCHAR(10) PRIMARY KEY,
	tenmh NVARCHAR(50),
	sotiet int,
	magv NVARCHAR(10) FOREIGN KEY REFERENCES giaovien(magv),
);
GO
CREATE TABLE diem (
	id int PRIMARY KEY,
	masv NVARCHAR(10) FOREIGN KEY REFERENCES sinhvien(masv),
	mamh NVARCHAR(10) FOREIGN KEY REFERENCES monhoc(mamh),
	diem FLOAT,
);
GO
INSERT INTO admin (tk, mk) VALUES ('admin1', 'password1'), ('admin2', 'password2');
GO
INSERT INTO gv (tk, mk) VALUES ('gv1', 'password1'), ('gv2', 'password2');
GO
INSERT INTO truongkhoa (tk, mk) VALUES ('truongkhoa1', 'password1'), ('truongkhoa2', 'password2');
GO
INSERT INTO nguoidung (tk, mk) VALUES ('nguoidung1', 'password1'), ('nguoidung2', 'password2');
GO
INSERT INTO khoa (makhoa, tenkhoa)
VALUES
    ('CNTT', N'Công nghệ thông tin'),
    ('KT', N'Kinh tế'),
    ('KTMT', N'Khoa học và Kỹ thuật máy tính');
GO
INSERT INTO lop (malop, tenlop, makhoa)
VALUES
    ('CNTT1', N'K18 - Công nghệ thông tin', 'CNTT'),
    ('KT1', N'K20 - Kinh tế', 'KT'),
    ('KTMT1', N'K22 - Khoa học và Kỹ thuật máy tính', 'KTMT');
GO
INSERT INTO chinhsach (macs, tencs, chedo)
VALUES
    ('CS1', N'Chính sách Học bổng', N'Học viên đạt GPA >= 3.5 được hỗ trợ học phí'),
    ('CS2', N'Chính sách Đào tạo Quốc tế', N'Học viên tham gia chương trình đào tạo quốc tế');
GO
INSERT INTO sinhvien (masv, tensv, gioitinh, ngaysinh, sdt, diachi, macs, malop)
VALUES
    ('SV001', N'Nguyễn Văn A', N'Nam', '1995-03-20', '0901234567', N'123 Đường ABC, Quận 1, TP.HCM', 'CS1', 'CNTT1'),
    ('SV002', N'Trần Thị B', N'Nữ', '1998-06-10', '0987654321', N'456 Đường XYZ, Quận 2, TP.HCM', 'CS2', 'KT1');
GO
INSERT INTO giaovien (magv, tengv, gioitinh, ngaysinh, sdt, diachi)
VALUES
    ('GV001', N'Nguyễn Thị C', N'Nữ', '1980-08-15', '0123456789', N'789 Đường KLM, Quận 3, TP.HCM'),
    ('GV002', N'Trần Văn D', N'Nam', '1975-05-10', '0987654321', N'987 Đường UVW, Quận 4, TP.HCM');
GO
INSERT INTO monhoc (mamh, tenmh, sotiet, magv)
VALUES
    ('MH001', N'Toán Cao cấp', 40, 'GV001'), 
    ('MH002', N'Lập trình Java', 30, 'GV002'); 
GO
INSERT INTO diem (id, masv, mamh, diem)
VALUES
    (1, 'SV001', 'MH001', 8.5), 
    (2, 'SV002', 'MH002', 9.0); 

-- Hiển thị dữ liệu của bảng admin
SELECT * FROM admin;

-- Hiển thị dữ liệu của bảng gv
SELECT * FROM gv;

-- Hiển thị dữ liệu của bảng truongkhoa
SELECT * FROM truongkhoa;

-- Hiển thị dữ liệu của bảng nguoidung
SELECT * FROM nguoidung;

-- Hiển thị dữ liệu của bảng khoa
SELECT * FROM khoa;

-- Hiển thị dữ liệu của bảng lop
SELECT * FROM lop;

-- Hiển thị dữ liệu của bảng chinhsach
SELECT * FROM chinhsach;

-- Hiển thị dữ liệu của bảng sinhvien
SELECT * FROM sinhvien;

-- Hiển thị dữ liệu của bảng giaovien
SELECT * FROM giaovien;

-- Hiển thị dữ liệu của bảng monhoc
SELECT * FROM monhoc;

-- Hiển thị dữ liệu của bảng diem
SELECT * FROM diem;





