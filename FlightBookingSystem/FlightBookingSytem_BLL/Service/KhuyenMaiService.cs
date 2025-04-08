using FlightBookingSystem_DAL.Repo;
using FlightBookingSytem_BLL.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSytem_BLL.Service
{
    public class KhuyenMaiService
    {
        private KhuyenMaiRepo khuyenMaiRepo;
        public KhuyenMaiService()
        {
            this.khuyenMaiRepo = new KhuyenMaiRepo();
        }
        public float loadGiaTriKhuyenMaiBLL()
        {
            return khuyenMaiRepo.loadGiaTriKhuyenMaiDAL(ThongTinChuyenBaySession.ngayDi);
        }
    }
}
