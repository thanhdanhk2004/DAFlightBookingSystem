using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightBookingSystem_DAL.Migrations
{
    /// <inheritdoc />
    public partial class flight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HangHangKhong",
                columns: table => new
                {
                    SoHieuHang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenHang = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangHangKhong", x => x.SoHieuHang);
                });

            migrationBuilder.CreateTable(
                name: "HanhLy",
                columns: table => new
                {
                    MaHL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MoTaHL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrongLuong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChiPhi = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HanhLy", x => x.MaHL);
                });

            migrationBuilder.CreateTable(
                name: "KhuVuc",
                columns: table => new
                {
                    MaKhuVuc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenKhuVuc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuVuc", x => x.MaKhuVuc);
                });

            migrationBuilder.CreateTable(
                name: "KhuyenMai",
                columns: table => new
                {
                    MaKM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TyLeGiam = table.Column<float>(type: "real", nullable: false),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuyenMai", x => x.MaKM);
                });

            migrationBuilder.CreateTable(
                name: "NguoiDung",
                columns: table => new
                {
                    IdNguoiDung = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ho = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SoDienThoai = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 22, 28, 4, 640, DateTimeKind.Local).AddTicks(630)),
                    SoCCCD = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NguoiDung", x => x.IdNguoiDung);
                });

            migrationBuilder.CreateTable(
                name: "MayBay",
                columns: table => new
                {
                    SoHieuMB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoHieuHang = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MayBay", x => x.SoHieuMB);
                    table.ForeignKey(
                        name: "FK_MayBay_HangHangKhong_SoHieuHang",
                        column: x => x.SoHieuHang,
                        principalTable: "HangHangKhong",
                        principalColumn: "SoHieuHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanBay",
                columns: table => new
                {
                    MaSanBay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DiaDiem = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaKhuVuc = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanBay", x => x.MaSanBay);
                    table.ForeignKey(
                        name: "FK_SanBay_KhuVuc_MaKhuVuc",
                        column: x => x.MaKhuVuc,
                        principalTable: "KhuVuc",
                        principalColumn: "MaKhuVuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    MaAdmin = table.Column<int>(type: "int", nullable: false),
                    KinhNghiem = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.MaAdmin);
                    table.ForeignKey(
                        name: "FK_Admin_NguoiDung_MaAdmin",
                        column: x => x.MaAdmin,
                        principalTable: "NguoiDung",
                        principalColumn: "IdNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    HangThanhVien = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Đồng")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKhachHang);
                    table.ForeignKey(
                        name: "FK_KhachHang_NguoiDung_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "NguoiDung",
                        principalColumn: "IdNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<int>(type: "int", nullable: false),
                    Luong = table.Column<float>(type: "real", nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 22, 28, 4, 667, DateTimeKind.Local).AddTicks(5162)),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK_NhanVien_NguoiDung_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NguoiDung",
                        principalColumn: "IdNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    idTaiKhoan = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    VaiTro = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "User"),
                    IdNguoiDung = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.idTaiKhoan);
                    table.ForeignKey(
                        name: "FK_TaiKhoan_NguoiDung_IdNguoiDung",
                        column: x => x.IdNguoiDung,
                        principalTable: "NguoiDung",
                        principalColumn: "IdNguoiDung",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ghe",
                columns: table => new
                {
                    MaGhe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HangGhe = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "PHOTHONG"),
                    SoHieuMB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThaiGhe = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "Còn trống")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ghe", x => x.MaGhe);
                    table.ForeignKey(
                        name: "FK_Ghe_MayBay_SoHieuMB",
                        column: x => x.SoHieuMB,
                        principalTable: "MayBay",
                        principalColumn: "SoHieuMB",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuyenBay",
                columns: table => new
                {
                    MaTuyenBay = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    MaSanBayDen = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaSanBayDi = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuyenBay", x => x.MaTuyenBay);
                    table.ForeignKey(
                        name: "FK_TuyenBay_SanBay_MaSanBayDen",
                        column: x => x.MaSanBayDen,
                        principalTable: "SanBay",
                        principalColumn: "MaSanBay");
                    table.ForeignKey(
                        name: "FK_TuyenBay_SanBay_MaSanBayDi",
                        column: x => x.MaSanBayDi,
                        principalTable: "SanBay",
                        principalColumn: "MaSanBay");
                });

            migrationBuilder.CreateTable(
                name: "DonHang",
                columns: table => new
                {
                    MaDH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayDatHang = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 22, 28, 4, 675, DateTimeKind.Local).AddTicks(4282)),
                    TongGiaTriDonHang = table.Column<float>(type: "real", nullable: false),
                    MaKH = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHang", x => x.MaDH);
                    table.ForeignKey(
                        name: "FK_DonHang_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChuyenBay",
                columns: table => new
                {
                    MaChuyenBay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianDi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianDen = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoHieuMB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaTuyenBay = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChuyenBay", x => x.MaChuyenBay);
                    table.ForeignKey(
                        name: "FK_ChuyenBay_MayBay_SoHieuMB",
                        column: x => x.SoHieuMB,
                        principalTable: "MayBay",
                        principalColumn: "SoHieuMB",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChuyenBay_TuyenBay_MaTuyenBay",
                        column: x => x.MaTuyenBay,
                        principalTable: "TuyenBay",
                        principalColumn: "MaTuyenBay",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHangKhuyenMai",
                columns: table => new
                {
                    MaDHKM = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaKM = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangKhuyenMai", x => x.MaDHKM);
                    table.ForeignKey(
                        name: "FK_DonHangKhuyenMai_DonHang_MaDHKM",
                        column: x => x.MaDHKM,
                        principalTable: "DonHang",
                        principalColumn: "MaDH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHangKhuyenMai_KhuyenMai_MaKM",
                        column: x => x.MaKM,
                        principalTable: "KhuyenMai",
                        principalColumn: "MaKM",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonHangOffline",
                columns: table => new
                {
                    MaDHOffline = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaNV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonHangOffline", x => x.MaDHOffline);
                    table.ForeignKey(
                        name: "FK_DonHangOffline_DonHang_MaDHOffline",
                        column: x => x.MaDHOffline,
                        principalTable: "DonHang",
                        principalColumn: "MaDH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonHangOffline_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV");
                });

            migrationBuilder.CreateTable(
                name: "ThanhToan",
                columns: table => new
                {
                    MaThanhToan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoTien = table.Column<float>(type: "real", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 22, 28, 4, 693, DateTimeKind.Local).AddTicks(6411)),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaDH = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanhToan", x => x.MaThanhToan);
                    table.ForeignKey(
                        name: "FK_ThanhToan_DonHang_MaDH",
                        column: x => x.MaDH,
                        principalTable: "DonHang",
                        principalColumn: "MaDH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ve",
                columns: table => new
                {
                    MaVe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoaiVe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayXuatVe = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 22, 28, 4, 724, DateTimeKind.Local).AddTicks(1737)),
                    MaDH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaNguoiSoHuu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ve", x => x.MaVe);
                    table.ForeignKey(
                        name: "FK_Ve_DonHang_MaDH",
                        column: x => x.MaDH,
                        principalTable: "DonHang",
                        principalColumn: "MaDH");
                    table.ForeignKey(
                        name: "FK_Ve_NguoiDung_MaNguoiSoHuu",
                        column: x => x.MaNguoiSoHuu,
                        principalTable: "NguoiDung",
                        principalColumn: "IdNguoiDung");
                });

            migrationBuilder.CreateTable(
                name: "GiaVeChuyenBay",
                columns: table => new
                {
                    MaHangGhe = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaVe = table.Column<float>(type: "real", nullable: false),
                    LoaiGhe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaCB = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaVeChuyenBay", x => x.MaHangGhe);
                    table.ForeignKey(
                        name: "FK_GiaVeChuyenBay_ChuyenBay_MaCB",
                        column: x => x.MaCB,
                        principalTable: "ChuyenBay",
                        principalColumn: "MaChuyenBay");
                });

            migrationBuilder.CreateTable(
                name: "LichBay",
                columns: table => new
                {
                    MaLich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayLapLich = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2025, 4, 11, 22, 28, 4, 717, DateTimeKind.Local).AddTicks(5981)),
                    MaChuyenBay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaNV = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichBay", x => x.MaLich);
                    table.ForeignKey(
                        name: "FK_LichBay_ChuyenBay_MaChuyenBay",
                        column: x => x.MaChuyenBay,
                        principalTable: "ChuyenBay",
                        principalColumn: "MaChuyenBay",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichBay_NhanVien_MaNV",
                        column: x => x.MaNV,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SanBayTrungGian",
                columns: table => new
                {
                    MaSanBayTrungGian = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaTuyenBay = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaChuyenBay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ThoiGianDungChan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianTiepTuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSanBay = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanBayTrungGian", x => x.MaSanBayTrungGian);
                    table.ForeignKey(
                        name: "FK_SanBayTrungGian_ChuyenBay_MaChuyenBay",
                        column: x => x.MaChuyenBay,
                        principalTable: "ChuyenBay",
                        principalColumn: "MaChuyenBay",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanBayTrungGian_SanBay_MaSanBay",
                        column: x => x.MaSanBay,
                        principalTable: "SanBay",
                        principalColumn: "MaSanBay");
                });

            migrationBuilder.CreateTable(
                name: "ChiTietVe",
                columns: table => new
                {
                    MaChiTietVe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaChuyenBay = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaVe = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaHL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaGhe = table.Column<int>(type: "int", nullable: false),
                    GiaVe = table.Column<float>(type: "real", nullable: false),
                    TrangThaiVe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietVe", x => x.MaChiTietVe);
                    table.ForeignKey(
                        name: "FK_ChiTietVe_ChuyenBay_MaChuyenBay",
                        column: x => x.MaChuyenBay,
                        principalTable: "ChuyenBay",
                        principalColumn: "MaChuyenBay");
                    table.ForeignKey(
                        name: "FK_ChiTietVe_Ghe_MaGhe",
                        column: x => x.MaGhe,
                        principalTable: "Ghe",
                        principalColumn: "MaGhe",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietVe_HanhLy_MaHL",
                        column: x => x.MaHL,
                        principalTable: "HanhLy",
                        principalColumn: "MaHL",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietVe_Ve_MaVe",
                        column: x => x.MaVe,
                        principalTable: "Ve",
                        principalColumn: "MaVe");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietVe_MaChuyenBay",
                table: "ChiTietVe",
                column: "MaChuyenBay");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietVe_MaGhe",
                table: "ChiTietVe",
                column: "MaGhe",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietVe_MaHL",
                table: "ChiTietVe",
                column: "MaHL",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietVe_MaVe",
                table: "ChiTietVe",
                column: "MaVe");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_MaTuyenBay",
                table: "ChuyenBay",
                column: "MaTuyenBay");

            migrationBuilder.CreateIndex(
                name: "IX_ChuyenBay_SoHieuMB",
                table: "ChuyenBay",
                column: "SoHieuMB");

            migrationBuilder.CreateIndex(
                name: "IX_DonHang_MaKH",
                table: "DonHang",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangKhuyenMai_MaKM",
                table: "DonHangKhuyenMai",
                column: "MaKM");

            migrationBuilder.CreateIndex(
                name: "IX_DonHangOffline_MaNV",
                table: "DonHangOffline",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_Ghe_SoHieuMB",
                table: "Ghe",
                column: "SoHieuMB");

            migrationBuilder.CreateIndex(
                name: "IX_GiaVeChuyenBay_MaCB",
                table: "GiaVeChuyenBay",
                column: "MaCB");

            migrationBuilder.CreateIndex(
                name: "IX_LichBay_MaChuyenBay",
                table: "LichBay",
                column: "MaChuyenBay",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LichBay_MaNV",
                table: "LichBay",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_MayBay_SoHieuHang",
                table: "MayBay",
                column: "SoHieuHang");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_SoCCCD",
                table: "NguoiDung",
                column: "SoCCCD",
                unique: true,
                filter: "[SoCCCD] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_NguoiDung_SoDienThoai",
                table: "NguoiDung",
                column: "SoDienThoai",
                unique: true,
                filter: "[SoDienThoai] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SanBay_MaKhuVuc",
                table: "SanBay",
                column: "MaKhuVuc");

            migrationBuilder.CreateIndex(
                name: "IX_SanBayTrungGian_MaChuyenBay",
                table: "SanBayTrungGian",
                column: "MaChuyenBay");

            migrationBuilder.CreateIndex(
                name: "IX_SanBayTrungGian_MaSanBay",
                table: "SanBayTrungGian",
                column: "MaSanBay",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_IdNguoiDung",
                table: "TaiKhoan",
                column: "IdNguoiDung",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TaiKhoan_TenDangNhap",
                table: "TaiKhoan",
                column: "TenDangNhap",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ThanhToan_MaDH",
                table: "ThanhToan",
                column: "MaDH",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TuyenBay_MaSanBayDen",
                table: "TuyenBay",
                column: "MaSanBayDen");

            migrationBuilder.CreateIndex(
                name: "IX_TuyenBay_MaSanBayDi",
                table: "TuyenBay",
                column: "MaSanBayDi");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_MaDH",
                table: "Ve",
                column: "MaDH");

            migrationBuilder.CreateIndex(
                name: "IX_Ve_MaNguoiSoHuu",
                table: "Ve",
                column: "MaNguoiSoHuu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "ChiTietVe");

            migrationBuilder.DropTable(
                name: "DonHangKhuyenMai");

            migrationBuilder.DropTable(
                name: "DonHangOffline");

            migrationBuilder.DropTable(
                name: "GiaVeChuyenBay");

            migrationBuilder.DropTable(
                name: "LichBay");

            migrationBuilder.DropTable(
                name: "SanBayTrungGian");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "ThanhToan");

            migrationBuilder.DropTable(
                name: "Ghe");

            migrationBuilder.DropTable(
                name: "HanhLy");

            migrationBuilder.DropTable(
                name: "Ve");

            migrationBuilder.DropTable(
                name: "KhuyenMai");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChuyenBay");

            migrationBuilder.DropTable(
                name: "DonHang");

            migrationBuilder.DropTable(
                name: "MayBay");

            migrationBuilder.DropTable(
                name: "TuyenBay");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "HangHangKhong");

            migrationBuilder.DropTable(
                name: "SanBay");

            migrationBuilder.DropTable(
                name: "NguoiDung");

            migrationBuilder.DropTable(
                name: "KhuVuc");
        }
    }
}
