INSERT INTO NguoiDung (Ho, Ten, diaChi, email, soDienThoai, ngaySinh, soCCCD, GioiTinh) VALUES
(N'Lê', N'Dân', 'Hanoi', 'admin@example.com', '0987654321', '1985-01-01', '123456789012', 'Nam'),
('Tran', 'An', 'HCM', 'nv1@example.com', '0912345678', '1990-05-10', '123456789013', 'Nam'),
('Le', 'Duyen', 'Da Nang', 'nv2@example.com', '0923456789', '1992-07-20', '123456789014','Nam'),
('Pham', 'Nhan', 'Can Tho', 'nv3@example.com', '0934567890', '1995-09-30', '123456789015', N'Nữ'),
('Hoang', 'Hieu', 'Hue', 'user1@example.com', '0945678901', '2000-01-15', '123456789016', 'Nam'),
('Do', 'Nguyen', 'Hai Phong', 'user2@example.com', '0956789012', '1998-03-22', '123456789017', N'Nữ'),
('Vu', 'Minh', 'Quang Ninh', 'user3@example.com', '0967890123', '2001-06-18', '123456789018', 'Nam'),
('Dang', 'Anh', 'Nha Trang', 'user4@example.com', '0978901234', '1999-12-25', '123456789019', N'Nữ'),
('Bui', 'Tin', 'Binh Duong', 'user5@example.com', '0989012345', '1997-08-05', '123456789020', 'Nam'),
('Ngo', 'Hoang', 'Vinh', 'user6@example.com', '0990123456', '2002-04-11', '123456789021', N'Nữ'),
('Cao', 'Hau', 'Thanh Hoa', 'user7@example.com', '0901234567', '2003-02-17', '123456789022', 'Nam'),
('Trinh', 'Hien', 'Dong Nai', 'user8@example.com', '0912345670', '2004-09-29', '123456789023', N'Nữ'),
('Nguyen', 'Vy', 'Tay Ninh', 'user9@example.com', '0923456701', '1996-11-03', '123456789024', 'Nam'),
('Ly', 'Cong', 'Ben Tre', 'user10@example.com', '0934567012', '1995-07-14', '123456789025', N'Nữ');

INSERT INTO Admin (IdNguoiDung, kinhNghiem) VALUES
(1,  N'10 năm kinh nghiệm quản lý');


-- Chèn dữ liệu vào bảng NhanVien
INSERT INTO NhanVien (IdNguoiDung, luong, ngayVaoLam, ghiChu) VALUES
(2, 10000000, '2015-06-15', N'Nhân viên bán vé'),
(3, 12000000, '2017-08-20', N'Nhân viên kế toán'),
(4, 11000000, '2019-10-05', N'Nhân viên chăm sóc khách hàng');

INSERT INTO TaiKhoan (tenDangNhap, matKhau, trangThai, vaiTro, IdNguoiDung) VALUES
('admin', 'admin123', 1, 'Admin', 1),
('nv1', 'nv123', 1, 'NhanVien', 2),
('nv2', 'nv123', 1, 'NhanVien', 3),
('nv3', 'nv123', 1, 'NhanVien', 4),
('user1', 'user123', 1, 'KhachHang', 5),
('user2', 'user123', 1, 'KhachHang', 6),
('user3', 'user123', 1, 'KhachHang', 7),
('user4', 'user123', 1, 'KhachHang', 8),
('user5', 'user123', 1, 'KhachHang', 9),
('user6', 'user123', 1, 'KhachHang', 10),
('user7', 'user123', 1, 'KhachHang', 11),
('user8', 'user123', 1, 'KhachHang', 12),
('user9', 'user123', 1, 'KhachHang', 13),
('user10', 'user123', 1, 'KhachHang', 14);


INSERT INTO KhachHang (IdNguoiDung) VALUES
(5),
(6),
(7),
(8),
(9),
(10),
(11),
(12),
(13),
(14);

INSERT INTO KhuVuc (MaKhuVuc, TenKhuVuc) VALUES
('KV01', N'Miền Bắc'),
('KV02', N'Miền Trung'),
('KV03', N'Miền Nam');

INSERT INTO SanBay (MaSanBay, DiaDiem, MaKhuVuc) VALUES
('HAN', N'Hà Nội', 'KV01'),
('HPH', N'Hải Phòng', 'KV01'),
('DAD', N'Đà Nẵng', 'KV02'),
('CXR', N'Nha Trang', 'KV02'),
('SGN', N'TP Hồ Chí Minh', 'KV03'),
('VCA', N'Cần Thơ', 'KV03');



INSERT INTO TuyenBay (MaTuyenBay, MaSanBayDi, MaSanBayDen) VALUES
('TB07', 'HAN', 'VCA'),
('TB06', 'VCA', 'HAN'),
('TB01', 'HAN', 'SGN'),
('TB02', 'HAN', 'DAD'),
('TB03', 'DAD', 'SGN'),
('TB04', 'SGN', 'HPH'),
('TB05', 'CXR', 'VCA');

INSERT INTO dbo.HangHangKhong (SoHieuHang, TenHang)
VALUES 
('VN', 'Vietnam Airlines'),
('QH', 'Bamboo Airways'),
('VJ', 'VietJet Air');

INSERT INTO dbo.MayBay (SoHieuMB, SoHieuHang)
VALUES 
('VN001', 'VN'),
('VN003', 'VN'),
('VN004', 'VN'),
('VN005', 'VN'),
('VN006', 'VN'),
('VN007', 'VN'),
('VN008', 'VN'),
('VN009', 'VN'),
('VN0010', 'VN'),
('QH100', 'QH'),
('QH101', 'QH'),
('QH102', 'QH'),
('QH103', 'QH'),
('QH104', 'QH'),
('QH105', 'QH'),
('QH106', 'QH'),
('QH107', 'QH'),
('QH108', 'QH'),
('QH109', 'QH'),
('VJ202', 'VJ'),
('VJ203', 'VJ'),
('VJ204', 'VJ'),
('VJ205', 'VJ'),
('VJ206', 'VJ'),
('VJ207', 'VJ'),
('VJ208', 'VJ'),
('VJ209', 'VJ'),
('VJ200', 'VJ'),
('VJ201', 'VJ');

DECLARE @SoHieuMB NVARCHAR(450);
DECLARE @i INT;

DECLARE cursorMB CURSOR FOR 
SELECT SoHieuMB FROM dbo.MayBay;

OPEN cursorMB;
FETCH NEXT FROM cursorMB INTO @SoHieuMB;

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @i = 1;
    WHILE @i <= 128
    BEGIN
        -- Nếu ghế từ 1 đến 16 thì là Thương gia (Business)
        IF @i <= 32
        BEGIN
            INSERT INTO dbo.Ghe ( HangGhe, SoHieuMB)
            VALUES ('THUONGGIA', @SoHieuMB);
        END
        ELSE 
        BEGIN
            INSERT INTO dbo.Ghe (HangGhe, SoHieuMB)
            VALUES ('PHOTHONG', @SoHieuMB);
        END
        SET @i = @i + 1;
    END

    FETCH NEXT FROM cursorMB INTO @SoHieuMB;
END

CLOSE cursorMB;
DEALLOCATE cursorMB;


  -- Chèn dữ liệu mẫu cho bảng ChuyenBay
INSERT INTO dbo.ChuyenBay (MaChuyenBay, ThoiGianDi, ThoiGianDen, SoHieuMB, MaTuyenBay)
VALUES
('CB0021', '2025-07-15 08:00:00', '2025-07-15 10:30:00', 'VN001', 'TB07'),
('CB0022', '2025-07-15 10:00:00', '2025-07-15 12:30:00', 'VN007', 'TB07'),
('CB0023', '2025-07-15 14:00:00', '2025-07-15 16:30:00', 'VN003', 'TB07'),
('CB0024', '2025-07-15 07:00:00', '2025-07-15 09:45:00', 'QH100', 'TB07'),
('CB0025', '2025-07-15 09:00:00', '2025-07-15 11:15:00', 'QH101', 'TB07'),
('CB0026', '2025-07-15 15:00:00', '2025-07-15 17:15:00', 'VJ205', 'TB07'),
('CB0027', '2025-07-15 19:00:00', '2025-07-15 21:20:00', 'VJ206','TB07');

INSERT INTO dbo.ChuyenBay (MaChuyenBay, ThoiGianDi, ThoiGianDen, SoHieuMB, MaTuyenBay)
VALUES
('CB0014', '2025-07-15 08:00:00', '2025-07-15 10:30:00', 'VN001', 'TB06'),
('CB0015', '2025-07-15 10:00:00', '2025-07-15 12:30:00', 'VN007', 'TB06'),
('CB0016', '2025-07-15 14:00:00', '2025-07-15 16:30:00', 'VN003', 'TB06'),
('CB0017', '2025-07-15 07:00:00', '2025-07-15 09:45:00', 'QH100', 'TB06'),
('CB0018', '2025-07-15 09:00:00', '2025-07-15 11:15:00', 'QH101', 'TB06'),
('CB0019', '2025-07-15 15:00:00', '2025-07-15 17:15:00', 'VJ205', 'TB06'),
('CB0020', '2025-07-15 19:00:00', '2025-07-15 21:20:00', 'VJ206','TB06');

INSERT INTO dbo.ChuyenBay (MaChuyenBay, ThoiGianDi, ThoiGianDen, SoHieuMB, MaTuyenBay)
VALUES
('CB001', '2025-07-10 08:00:00', '2025-07-10 10:30:00', 'VN001', 'TB06'),
('CB002', '2025-07-10 10:00:00', '2025-07-10 12:30:00', 'VN007', 'TB06'),
('CB003', '2025-07-10 14:00:00', '2025-07-10 16:30:00', 'VN003', 'TB06'),
('CB004', '2025-07-10 15:00:00', '2025-07-10 17:30:00', 'VN004', 'TB06'),
('CB006', '2025-07-10 19:00:00', '2025-07-10 21:30:00', 'VN005', 'TB06'),
('CB007', '2025-07-10 23:00:00', '2025-07-11 01:30:00', 'VN006', 'TB06'),
('CB008', '2025-07-10 07:00:00', '2025-07-10 09:45:00', 'QH100', 'TB06'),
('CB009', '2025-07-10 09:00:00', '2025-07-10 11:15:00', 'QH101', 'TB06'),
('CB0010', '2025-07-10 18:00:00', '2025-07-10 20:20:00', 'QH102','TB06'),
('CB0011', '2025-07-10 07:00:00', '2025-07-10 09:45:00', 'VJ204', 'TB06'),
('CB0012', '2025-07-10 15:00:00', '2025-07-10 17:15:00', 'VJ205', 'TB06'),
('CB0013', '2025-07-10 19:00:00', '2025-07-10 21:20:00', 'VJ206','TB06');

-- Chèn dữ liệu mẫu cho bảng SanBayTrungGian
INSERT INTO dbo.SanBayTrungGian (MaSanBayTrungGian,MaSanBay, MaTuyenBay, MaChuyenBay, ThoiGianDungChan, ThoiGianTiepTuc, GhiChu)
VALUES
('SBTG19','SGN', 'T006', 'CB0021', '2025-07-15 09:00:00', '2025-07-15 09:15:00', 'Dừng ngắn tại Đà Nẵng'),
('SBTG20','DAD', 'T006', 'CB0021', '2025-07-15 09:45:00', '2025-07-15 10:00:00', 'Dừng kỹ thuật'),
('SBTG21','SGN', 'T006', 'CB0022', '2025-07-15 07:45:00', '2025-07-15 08:00:00', 'Dừng ngắn tại Đà Nẵng'),
('SBTG22','DAD', 'T006', 'CB0022', '2025-07-15 08:45:00', '2025-07-15 09:00:00', 'Dừng kỹ thuật'),
('SBTG23','SGN', 'T006', 'CB0023', '2025-07-15 15:00:00', '2025-07-15 15:15:00', 'Dừng kỹ thuật'),
('SBTG24','SGN', 'T006', 'CB0024', '2025-07-15 20:00:00', '2025-07-15 20:15:00', 'Dừng kỹ thuật'),
('SBTG25','SGN', 'T006', 'CB0025', '2025-07-15 10:00:00', '2025-07-15 10:15:00', 'Dừng kỹ thuật')

INSERT INTO dbo.SanBayTrungGian (MaSanBayTrungGian,MaSanBay, MaTuyenBay, MaChuyenBay, ThoiGianDungChan, ThoiGianTiepTuc, GhiChu)
VALUES
('SBTG1','SGN', 'T006', 'CB001', '2025-07-10 09:00:00', '2025-07-10 09:15:00', 'Dừng ngắn tại Đà Nẵng'),
('SBTG2','DAD', 'T006', 'CB001', '2025-07-10 09:45:00', '2025-07-10 10:00:00', 'Dừng kỹ thuật'),
('SBTG3','SGN', 'T006', 'CB008', '2025-07-10 07:45:00', '2025-07-10 08:00:00', 'Dừng ngắn tại Đà Nẵng'),
('SBTG5','DAD', 'T006', 'CB008', '2025-07-10 08:45:00', '2025-07-10 09:00:00', 'Dừng kỹ thuật'),
('SBTG6','SGN', 'T006', 'CB0011', '2025-07-10 07:45:00', '2025-07-10 08:00:00', 'Dừng ngắn tại Đà Nẵng'),
('SBTG7','DAD', 'T006', 'CB0011', '2025-07-10 08:45:00', '2025-07-10 09:00:00', 'Dừng kỹ thuật'),
('SBTG8','SGN', 'T006', 'CB003', '2025-07-10 15:00:00', '2025-07-10 15:15:00', 'Dừng kỹ thuật'),
('SBTG9','SGN', 'T006', 'CB006', '2025-07-10 20:00:00', '2025-07-10 20:15:00', 'Dừng kỹ thuật'),
('SBTG10','SGN', 'T006', 'CB009', '2025-07-10 10:00:00', '2025-07-10 10:15:00', 'Dừng kỹ thuật'),
('SBTG11','SGN', 'T006', 'CB0012', '2025-07-10 16:00:00', '2025-07-10 16:15:00', 'Dừng kỹ thuật');

Insert into GiaVeChuyenBay
values( 1500000,'PHOTHONG', 'CB001'),
	( 1700000,'THUONGGIA', 'CB001'),
	( 500000,'PHOTHONG', 'CB002'),
	( 700000,'THUONGGIA', 'CB002'),
	( 500000,'PHOTHONG', 'CB004'),
	( 700000,'THUONGGIA', 'CB004'),
	( 600000,'PHOTHONG', 'CB0010'),
	( 800000,'THUONGGIA', 'CB0010'),
	( 700000,'PHOTHONG', 'CB007'),
	( 900000,'THUONGGIA', 'CB007')

Insert into GiaVeChuyenBay
values( 1500000,'PHOTHONG', 'CB003'),
	( 1700000,'THUONGGIA', 'CB003'),
	( 1600000,'PHOTHONG', 'CB008'),
	( 1800000,'THUONGGIA', 'CB008'),
	( 1400000,'PHOTHONG', 'CB0011'),
	( 1700000,'THUONGGIA', 'CB0011'),
	( 1550000,'PHOTHONG', 'CB006'),
	( 1720000,'THUONGGIA', 'CB006'),
	( 1300000,'PHOTHONG', 'CB009'),
	( 1500000,'THUONGGIA', 'CB009'),
	( 14500000,'PHOTHONG', 'CB0012'),
	( 17200000,'THUONGGIA', 'CB0012')


Insert into GiaVeChuyenBay
values( 1500000,'PHOTHONG', 'CB0014'),
	( 1700000,'THUONGGIA', 'CB0014'),
	( 1600000,'PHOTHONG', 'CB0015'),
	( 1800000,'THUONGGIA', 'CB0015'),
	( 1400000,'PHOTHONG', 'CB0016'),
	( 1700000,'THUONGGIA', 'CB0016'),
	( 1550000,'PHOTHONG', 'CB0017'),
	( 1720000,'THUONGGIA', 'CB0017'),
	( 1300000,'PHOTHONG', 'CB0018'),
	( 1500000,'THUONGGIA', 'CB0018'),
	( 14500000,'PHOTHONG', 'CB0019'),
	( 17200000,'THUONGGIA', 'CB0019'),
	( 14500000,'PHOTHONG', 'CB0020'),
	( 17200000,'THUONGGIA', 'CB0020')

Insert into GiaVeChuyenBay
values( 1500000,'PHOTHONG', 'CB0021'),
	( 1700000,'THUONGGIA', 'CB0021'),
	( 1600000,'PHOTHONG', 'CB0022'),
	( 1800000,'THUONGGIA', 'CB0022'),
	( 1400000,'PHOTHONG', 'CB0023'),
	( 1700000,'THUONGGIA', 'CB0023'),
	( 1550000,'PHOTHONG', 'CB0024'),
	( 1720000,'THUONGGIA', 'CB0024'),
	( 1300000,'PHOTHONG', 'CB0025'),
	( 1500000,'THUONGGIA', 'CB0025'),
	( 14500000,'PHOTHONG', 'CB0026'),
	( 17200000,'THUONGGIA', 'CB0026'),
	( 14500000,'PHOTHONG', 'CB0027'),
	( 17200000,'THUONGGIA', 'CB0027')
DROP INDEX IX_SanBayTrungGian_MaSanBay ON dbo.SanBayTrungGian;


select * from NhanVien

set format date 'dd/MM/yyyy'

insert into NhanVien
values(13, 5000000,'2022-03-31 14:30:00', 'Hello')