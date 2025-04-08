using FlightBookingSystem_DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBookingSytem_BLL.Session;

namespace FlightBookingSytem_BLL.Service
{
    public class ThongTinVeService
    {
        private DienThongTinRepo dienThongTinRepo;
        public ThongTinVeService()
        {
            this.dienThongTinRepo = new DienThongTinRepo();
        }

        public float giaVeService(string maChuyenBay, string hangVe)
        {
            return dienThongTinRepo.giaGhe(maChuyenBay, hangVe);
        }
    }
}
