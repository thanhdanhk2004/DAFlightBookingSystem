using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Model;
using FlightBookingSystem_DAL.Repo;
using FlightBookingSytem_BLL.Session;

namespace FlightBookingSytem_BLL.Service
{
    public class BanVeService
    {
        private ChuyenBayRepo chuyenBayRepo;
        private SanBayRepo sanBayRepo;
        public DienThongTinRepo dienThongTinRepo;
        public DonHangRepo donHangRepo;
        public ThanhToanRepo thanhToanRepo;
        public KhuyenMaiRepo khuyenMaiRepo;
        public DonHangKhuyenMaiRepo donHangKhuyenMaiRepo;
        public NguoiDungRepo nguoiDungRepo;
        public VeRepo veRepo;
        public HanhLyRepo hanhLyRepo;
        public GheRepo gheRepo;
        public ChiTietVeRepo chiTietVeRepo;
        public DonHangOfflineRepo donHangOfflineRepo;
        public KhachHangRepo khachHangRepo;

        public BanVeService() 
        { 
            chuyenBayRepo = new ChuyenBayRepo();
            sanBayRepo = new SanBayRepo();
            dienThongTinRepo = new DienThongTinRepo();
            donHangRepo = new DonHangRepo();
            thanhToanRepo = new ThanhToanRepo();
            khuyenMaiRepo = new KhuyenMaiRepo();
            donHangKhuyenMaiRepo = new DonHangKhuyenMaiRepo();
            nguoiDungRepo = new NguoiDungRepo();
            veRepo = new VeRepo();
            hanhLyRepo = new HanhLyRepo();
            gheRepo = new GheRepo();
            chiTietVeRepo = new ChiTietVeRepo();
            donHangOfflineRepo = new DonHangOfflineRepo();
            khachHangRepo = new KhachHangRepo();
        }

        public List<string> diaDiemDiVaDen()
        {
            return sanBayRepo.loadSanBay();
        }

        public List<ChuyenBayDTO> loadChuyenBayBLL(string noiDi, string noiDen, string hangVe, DateTime ngayDi)
        {
            return chuyenBayRepo.loadChuyenBay(noiDi, noiDen, hangVe, ngayDi);
        }

        public float giaVeService(string maChuyenBay, string hangVe)
        {
            return dienThongTinRepo.giaGhe(maChuyenBay, hangVe);
        }

        public void luuVeKhiBan(List<NguoiDungDTO> nguoiDungDTOs, TienDonHangDTO tienDonHangDTO, String phuongThucThanhToan)
        {
            NguoiDung u = new NguoiDung
            {
                Ho = nguoiDungDTOs[0].ho,
                Ten = nguoiDungDTOs[0].ten,
                NgaySinh = nguoiDungDTOs[0].ngaySinh,
                SoCCCD = nguoiDungDTOs[0].soCCCD,
            };
            nguoiDungRepo.themNguoiDuong(u);

            //Them khach hang
            KhachHang c = new KhachHang
            {
                MaKhachHang = u.IdNguoiDung,
                HangThanhVien = "Đồng"
            };
            khachHangRepo.themKhachHang(c);

            //Them Don Hang
            DonHang donHang = new DonHang
            {
                MaDH = "DH" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                NgayDatHang = DateTime.Now,
                TongGiaTriDonHang = tienDonHangDTO.tongTienDonHang,
                MaKH = c.MaKhachHang,
            };
            donHangRepo.themDonHang(donHang);

            //Them don hang offline
            DonHangOffline donHangOffline = new DonHangOffline
            {
                MaDHOffline = donHang.MaDH,
                MaNV = UserSession.IdNguoiDung,
            };
            donHangOfflineRepo.themDonHangOffline(donHangOffline);
            //Them Thanh Toan
            ThanhToan thanhToan = new ThanhToan
            {
                MaThanhToan = "TT" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                SoTien = tienDonHangDTO.tongTienThanhToan,
                NgayThanhToan = DateTime.Now,
                PhuongThucThanhToan = "Thanh toán Online",
                MaDH = donHang.MaDH,
            };
            thanhToanRepo.themThanhToan(thanhToan);

            //Them Don hang khuyen Mai neu co
            if (tienDonHangDTO.tongTienDonHang != tienDonHangDTO.tongTienThanhToan)
            {
                DonHangKhuyenMai donHangKhuyenMai = new DonHangKhuyenMai
                {
                    MaDHKM = donHang.MaDH,
                    MaKM = khuyenMaiRepo.loadMaKhuyenMai(ThongTinChuyenBaySession.ngayDi)
                };
                donHangKhuyenMaiRepo.themDonHangKhuyenMai(donHangKhuyenMai);
            }

            for (int i = 0; i < nguoiDungDTOs.Count; i++)
            {
                NguoiDung nguoiDung = new NguoiDung();
                //Them nguoi dung
                if (i > 0)
                {
                    nguoiDung = new NguoiDung
                    {
                        Ho = nguoiDungDTOs[i].ho,
                        Ten = nguoiDungDTOs[i].ten,
                        NgaySinh = nguoiDungDTOs[i].ngaySinh,
                        SoCCCD = nguoiDungDTOs[i].soCCCD,
                    };
                    nguoiDungRepo.themNguoiDuong(nguoiDung);
                }
                //Them ve
                Ve ve = new Ve
                {
                    MaVe = "Ve" + DateTime.Now.ToString("yyyyMMddHHmmss") + i.ToString(),
                    LoaiVe = ThongTinChuyenBaySession.loaiVe,
                    NgayXuatVe = DateTime.Now,
                    MaDH = donHang.MaDH,
                    MaNguoiSoHuu = i == 0?u.IdNguoiDung:nguoiDung.IdNguoiDung,
                };
                veRepo.themVe(ve);

                //Them hanh lyu
                HanhLy hanhLyDi = new HanhLy
                {
                    MaHL = "HLDI" + DateTime.Now.ToString("yyyyMMddHHmmss") + i.ToString(),
                    TrongLuong = nguoiDungDTOs[i].giaTienHanhLy == 0 ? "< 15 kg" : ">= 15kg",
                    ChiPhi = nguoiDungDTOs[i].giaTienHanhLy / 2
                };
                hanhLyRepo.themHanhLy(hanhLyDi);

                //Them chi tiet ve
                ChiTietVe chiTietVeLuotDi = new ChiTietVe
                {
                    MaChiTietVe = "CTVD" + DateTime.Now.ToString("yyyyMMddHHmmss") + i.ToString(),
                    MaChuyenBay = ThongTinChuyenBayLuotDiSession.maChuyenBay,
                    MaVe = ve.MaVe,
                    MaHL = hanhLyDi.MaHL,
                    TrangThaiVe = "Chưa bay",
                    GiaVe = nguoiDungDTOs[i].giaTienChuyenBayLuotDi,
                    MaGhe = gheRepo.loadMaGhe(ThongTinChuyenBayLuotDiSession.maChuyenBay, ThongTinChuyenBaySession.hangVe == "Phổ thông" ? "PHOTHONG" : "THUONGGIA")
                };
                chiTietVeRepo.themChiTietVe(chiTietVeLuotDi);
                gheRepo.capNhatTrangThaiGhe(chiTietVeLuotDi.MaGhe);


                //Them chi tiet ve luot ve neu co 
                if (ThongTinChuyenBaySession.loaiVe == "Khứ hồi")
                {
                    HanhLy hanhLyVe = new HanhLy
                    {
                        MaHL = "HLVE" + DateTime.Now.ToString("yyyyMMddHHmmss") + i.ToString(),
                        TrongLuong = nguoiDungDTOs[i].giaTienHanhLy == 0 ? "< 15 kg" : ">= 15kg",
                        ChiPhi = nguoiDungDTOs[i].giaTienHanhLy / 2
                    };
                    hanhLyRepo.themHanhLy(hanhLyVe);
                    ChiTietVe chiTietVeLuotVe = new ChiTietVe
                    {
                        MaChiTietVe = "CTVV" + DateTime.Now.ToString("yyyyMMddHHmmss") + i.ToString(),
                        MaChuyenBay = ThongTinChuyenBayLuotVeSesstion.maChuyenBay,
                        MaVe = ve.MaVe,
                        MaHL = hanhLyVe.MaHL,
                        TrangThaiVe = "Chưa bay",
                        GiaVe = nguoiDungDTOs[i].giaTienChuyenBayLuotVe,
                        MaGhe = gheRepo.loadMaGhe(ThongTinChuyenBayLuotVeSesstion.maChuyenBay, ThongTinChuyenBaySession.hangVe == "Phổ thông" ? "PHOTHONG" : "THUONGGIA")
                    };
                    chiTietVeRepo.themChiTietVe(chiTietVeLuotVe);
                    gheRepo.capNhatTrangThaiGhe(chiTietVeLuotVe.MaGhe);
                }
            }
        }
    }
}
