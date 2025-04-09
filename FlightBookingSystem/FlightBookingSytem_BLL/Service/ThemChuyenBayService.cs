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
    public class ThemChuyenBayService
    {
        private ChuyenBayRepo chuyenBayRepo;
        private SanBayTrungGianRepo sanBayTrungGianRepo;
        private TuyenBayRepo tuyenBayRepo;
        private LichBayRepo lichBayRepo;
        public ThemChuyenBayService()
        {
            chuyenBayRepo = new ChuyenBayRepo();
            sanBayTrungGianRepo = new SanBayTrungGianRepo();
            tuyenBayRepo = new TuyenBayRepo();
            lichBayRepo = new LichBayRepo();
        }
        public void themChuyenBayService(string maSanBayDi, string maSanBayDen, string soHieuMB, DateTime thoiGianKhoiHanh, DateTime thoiGianDen, float soTien)
        {
            string maTuyenBay = tuyenBayRepo.loadMaTuyenBay(maSanBayDi, maSanBayDen);
            

            ChuyenBay chuyenBay = new ChuyenBay
            {
                MaChuyenBay = "CB" + DateTime.Now,
                ThoiGianDi = thoiGianKhoiHanh,
                ThoiGianDen = thoiGianDen,
                SoHieuMB = soHieuMB,
                MaTuyenBay = maTuyenBay,
            };

            LichBay lichBay = new LichBay
            {
                MaLich = "LB" + DateTime.Now,
                NgayLapLich = DateTime.Now,
                MaChuyenBay = chuyenBay.MaChuyenBay,
                MaNV = UserSession.IdNguoiDung
            };


        }
    }
}
