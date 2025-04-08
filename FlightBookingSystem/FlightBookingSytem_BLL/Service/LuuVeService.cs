using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Model;
using FlightBookingSystem_DAL.Repo;
using FlightBookingSytem_BLL.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSytem_BLL
{
    public class LuuVeService
    {
        private NguoiDungRepo nguoiDungRepo;
        private DonHangRepo donHangRepo;
        private ThanhToanRepo thanhToanRepo;
        private VeRepo veRepo;
        private ChiTietVeRepo chiTietVeRepo;
        private HanhLyRepo hanhLyRepo;
        private GheRepo gheRepo;
        private KhuyenMaiRepo khuyenMaiRepo;
        private DonHangKhuyenMaiRepo donHangKhuyenMaiRepo;
        public LuuVeService()
        {
            this.nguoiDungRepo = new NguoiDungRepo();
            this.donHangRepo = new DonHangRepo();
            this.thanhToanRepo = new ThanhToanRepo();
            this.veRepo = new VeRepo();
            this.chiTietVeRepo = new ChiTietVeRepo();
            this.hanhLyRepo = new HanhLyRepo();
            this.gheRepo = new GheRepo();   
            this.khuyenMaiRepo = new KhuyenMaiRepo();
            this.donHangKhuyenMaiRepo = new DonHangKhuyenMaiRepo();
        }

        public void themVe(List<NguoiDungDTO> nguoiDungDTOs, TienDonHangDTO tienDonHangDTO)
        {
            //Them Don Hang
            DonHang donHang = new DonHang
            {
                MaDH = "DH" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                NgayDatHang = DateTime.Now,
                TongGiaTriDonHang = tienDonHangDTO.tongTienDonHang,
                MaKH = UserSession.IdNguoiDung,
            };
            donHangRepo.themDonHang(donHang);

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
            if(tienDonHangDTO.tongTienDonHang != tienDonHangDTO.tongTienThanhToan)
            {
                DonHangKhuyenMai donHangKhuyenMai = new DonHangKhuyenMai
                {
                    MaDHKM = donHang.MaDH,
                    MaKM = khuyenMaiRepo.loadMaKhuyenMai(ThongTinChuyenBaySession.ngayDi)
                };
                donHangKhuyenMaiRepo.themDonHangKhuyenMai(donHangKhuyenMai);
            }

            for(int i = 0; i < nguoiDungDTOs.Count; i++)
            {
                //Them nguoi dung
                NguoiDung nguoiDung = new NguoiDung
                {
                    Ho = nguoiDungDTOs[i].ho,
                    Ten = nguoiDungDTOs[i].ten,
                    NgaySinh = nguoiDungDTOs[i].ngaySinh,
                    SoCCCD = nguoiDungDTOs[i].soCCCD,
                };
                nguoiDungRepo.themNguoiDuong(nguoiDung);

                //Them ve
                Ve ve = new Ve
                {
                    MaVe = "Ve" + DateTime.Now.ToString("yyyyMMddHHmmss") + i.ToString(),
                    LoaiVe = ThongTinChuyenBaySession.loaiVe,
                    NgayXuatVe = DateTime.Now,
                    TrangThaiVe = "Chưa bay",
                    MaDH = donHang.MaDH,
                    MaNguoiSoHuu = nguoiDung.IdNguoiDung,
                };
                veRepo.themVe(ve);

                //Them hanh lyu
                HanhLy hanhLyDi = new HanhLy
                {
                    MaHL = "HLDI" + DateTime.Now.ToString("yyyyMMddHHmmss") + i.ToString(),
                    TrongLuong = nguoiDungDTOs[i].giaTienHanhLy == 0 ? "< 15 kg" : ">= 15kg",
                    ChiPhi = nguoiDungDTOs[i].giaTienHanhLy/2
                };
                hanhLyRepo.themHanhLy(hanhLyDi);

                //Them chi tiet ve
                ChiTietVe chiTietVeLuotDi = new ChiTietVe
                {
                    MaChiTietVe = "CTVD" + DateTime.Now.ToString("yyyyMMddHHmmss") + i.ToString(),
                    MaChuyenBay = ThongTinChuyenBayLuotDiSession.maChuyenBay,
                    MaVe = ve.MaVe,
                    MaHL = hanhLyDi.MaHL,
                    GiaVe = nguoiDungDTOs[i].giaTienChuyenBayLuotDi,
                    MaGhe = gheRepo.loadMaGhe(ThongTinChuyenBayLuotDiSession.maChuyenBay, ThongTinChuyenBaySession.hangVe == "Phổ thông" ? "PHOTHONG" : "THUONGGIA")
                };
                chiTietVeRepo.themChiTietVe(chiTietVeLuotDi);
                gheRepo.capNhatTrangThaiGhe(chiTietVeLuotDi.MaGhe);


                //Them chi tiet ve luot ve neu co 
                if(ThongTinChuyenBaySession.loaiVe == "Khứ hồi")
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
