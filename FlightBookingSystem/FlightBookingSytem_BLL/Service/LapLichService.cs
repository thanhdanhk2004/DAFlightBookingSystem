using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Model;
using FlightBookingSystem_DAL.Repo;
using FlightBookingSytem_BLL.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSytem_BLL.Service
{
    public class LapLichService
    {
        private TuyenBayRepo tuyenBayRepo;
        private MayBayRepo mayBayRepo;
        private ChuyenBayRepo chuyenBayRepo;
        private SanBayTrungGianRepo sanBayTrungGianRepo;
        private LichBayRepo lichBayRepo;
        private GiaVeChuyenBayRepo giaVeChuyenBayRepo;
        private SanBayRepo sanBayRepo;

        public LapLichService()
        {
            tuyenBayRepo = new TuyenBayRepo();
            mayBayRepo = new MayBayRepo();
            chuyenBayRepo = new ChuyenBayRepo();
            sanBayTrungGianRepo = new SanBayTrungGianRepo();
            lichBayRepo = new LichBayRepo();
            giaVeChuyenBayRepo = new GiaVeChuyenBayRepo();
            sanBayRepo = new SanBayRepo();
        }
        public List<TuyenBayDTO> loadTuyenBayService()
        {
            return tuyenBayRepo.loadTuyenBay();
        }
        public List<string> loadMayBay()
        {
            return mayBayRepo.loadMayBay(); 
        }

        
        public void themChuyenBayService(string maSanBayDi, string maSanBayDen, string soHieuMB, DateTime thoiGianKhoiHanh, DateTime thoiGianDen, float soTien)
        {
            string maTuyenBay = tuyenBayRepo.loadMaTuyenBay(maSanBayDi, maSanBayDen);
            Console.WriteLine(maTuyenBay);
            ChuyenBay chuyenBay = new ChuyenBay
            {
                MaChuyenBay = "CB" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                ThoiGianDi = thoiGianKhoiHanh,
                ThoiGianDen = thoiGianDen,
                SoHieuMB = soHieuMB,
                MaTuyenBay = maTuyenBay,
            };
            chuyenBayRepo.themChuyenBay(chuyenBay);

            LichBay lichBay = new LichBay
            {
                MaLich = "LB" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                NgayLapLich = DateTime.Now,
                MaChuyenBay = chuyenBay.MaChuyenBay,
                MaNV = UserSession.IdNguoiDung
            };
            lichBayRepo.themLichBay(lichBay);

            //Tao gia ve pho thong va thuong gia
            GiaVeChuyenBay giaVeChuyenBayPhoThong = new GiaVeChuyenBay
            {
                GiaVe = soTien,
                LoaiGhe = "PHOTHONG",
                MaCB = chuyenBay.MaChuyenBay
            };
            GiaVeChuyenBay giaVeChuyenBayThuongGia = new GiaVeChuyenBay
            {
                GiaVe = soTien + 200000,
                LoaiGhe = "THUONGGIA",
                MaCB = chuyenBay.MaChuyenBay
            };
            giaVeChuyenBayRepo.themGiaVeChuyenBay(giaVeChuyenBayThuongGia);
            giaVeChuyenBayRepo.themGiaVeChuyenBay(giaVeChuyenBayPhoThong);


        }

        public void themChuyenBayService(string maSanBayDi, string maSanBayDen, string soHieuMB, DateTime thoiGianKhoiHanh, DateTime thoiGianDen, float soTien, string diaDiem1, DateTime thoiGianDungChan1,DateTime thoiGianTiepTuc1, string ghiChu1)
        {
            string maTuyenBay = tuyenBayRepo.loadMaTuyenBay(maSanBayDi, maSanBayDen);

            ChuyenBay chuyenBay = new ChuyenBay
            {
                MaChuyenBay = "CB" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                ThoiGianDi = thoiGianKhoiHanh,
                ThoiGianDen = thoiGianDen,
                SoHieuMB = soHieuMB,
                MaTuyenBay = maTuyenBay,
            };
            chuyenBayRepo.themChuyenBay(chuyenBay);

            LichBay lichBay = new LichBay
            {
                MaLich = "LB" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                NgayLapLich = DateTime.Now,
                MaChuyenBay = chuyenBay.MaChuyenBay,
                MaNV = UserSession.IdNguoiDung
            };
            lichBayRepo.themLichBay(lichBay);

            //Tao gia ve pho thong va thuong gia
            GiaVeChuyenBay giaVeChuyenBayPhoThong = new GiaVeChuyenBay
            {
                GiaVe = soTien,
                LoaiGhe = "PHOTHONG",
                MaCB = chuyenBay.MaChuyenBay
            };
            GiaVeChuyenBay giaVeChuyenBayThuongGia = new GiaVeChuyenBay
            {
                GiaVe = soTien + 200000,
                LoaiGhe = "THUONGGIA",
                MaCB = chuyenBay.MaChuyenBay
            };
            giaVeChuyenBayRepo.themGiaVeChuyenBay(giaVeChuyenBayThuongGia);
            giaVeChuyenBayRepo.themGiaVeChuyenBay(giaVeChuyenBayPhoThong);

            SanBayTrungGian sanBayTrungGian1 = new SanBayTrungGian
            {
                MaSanBayTrungGian = "SBTG1" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                MaTuyenBay = maTuyenBay,
                MaChuyenBay = chuyenBay.MaChuyenBay,
                MaSanBay = sanBayRepo.loadMaSanBay(diaDiem1),
                ThoiGianDungChan = thoiGianDungChan1,
                ThoiGianTiepTuc = thoiGianTiepTuc1,
                GhiChu = ghiChu1,
            };
            sanBayTrungGianRepo.themSanBayTrungGian(sanBayTrungGian1);
        }

        public void themChuyenBayService(string maSanBayDi, string maSanBayDen, string soHieuMB, DateTime thoiGianKhoiHanh, DateTime thoiGianDen, float soTien, string diaDiem1, DateTime thoiGianDungChan1, DateTime thoiGianTiepTuc1, string ghiChu1, string diaDiem2, DateTime thoiGianDungChan2, DateTime thoiGianTiepTuc2, string ghiChu2)
        {
            string maTuyenBay = tuyenBayRepo.loadMaTuyenBay(maSanBayDi, maSanBayDen);

            ChuyenBay chuyenBay = new ChuyenBay
            {
                MaChuyenBay = "CB" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                ThoiGianDi = thoiGianKhoiHanh,
                ThoiGianDen = thoiGianDen,
                SoHieuMB = soHieuMB,
                MaTuyenBay = maTuyenBay,
            };
            chuyenBayRepo.themChuyenBay(chuyenBay);

            LichBay lichBay = new LichBay
            {
                MaLich = "LB" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                NgayLapLich = DateTime.Now,
                MaChuyenBay = chuyenBay.MaChuyenBay,
                MaNV = UserSession.IdNguoiDung
            };
            lichBayRepo.themLichBay(lichBay);

            //Tao gia ve pho thong va thuong gia
            GiaVeChuyenBay giaVeChuyenBayPhoThong = new GiaVeChuyenBay
            {
                GiaVe = soTien,
                LoaiGhe = "PHOTHONG",
                MaCB = chuyenBay.MaChuyenBay
            };
            GiaVeChuyenBay giaVeChuyenBayThuongGia = new GiaVeChuyenBay
            {
                GiaVe = soTien + 200000,
                LoaiGhe = "THUONGGIA",
                MaCB = chuyenBay.MaChuyenBay
            };
            giaVeChuyenBayRepo.themGiaVeChuyenBay(giaVeChuyenBayThuongGia);
            giaVeChuyenBayRepo.themGiaVeChuyenBay(giaVeChuyenBayPhoThong);

            SanBayTrungGian sanBayTrungGian1 = new SanBayTrungGian
            {
                MaSanBayTrungGian = "SBTG1" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                MaTuyenBay = maTuyenBay,
                MaChuyenBay = chuyenBay.MaChuyenBay,
                MaSanBay = sanBayRepo.loadMaSanBay(diaDiem1),
                ThoiGianDungChan = thoiGianDungChan1,
                ThoiGianTiepTuc = thoiGianTiepTuc1,
                GhiChu = ghiChu1,
            };
            SanBayTrungGian sanBayTrungGian2 = new SanBayTrungGian
            {
                MaSanBayTrungGian = "SBTG2" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                MaTuyenBay = maTuyenBay,
                MaChuyenBay = chuyenBay.MaChuyenBay,
                MaSanBay = sanBayRepo.loadMaSanBay(diaDiem2),
                ThoiGianDungChan = thoiGianDungChan2,
                ThoiGianTiepTuc = thoiGianTiepTuc2,
                GhiChu = ghiChu2,
            };
            sanBayTrungGianRepo.themSanBayTrungGian(sanBayTrungGian1);
            sanBayTrungGianRepo.themSanBayTrungGian(sanBayTrungGian2);
        }

        public List<string> loadDiaDiemSanBayService()
        {
            return sanBayRepo.loadSanBay();
        }


    }
}
