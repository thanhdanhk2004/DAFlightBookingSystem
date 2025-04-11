using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Model;
using FlightBookingSystem_DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSytem_BLL.Service
{
    public class NhanVienHuyVeService
    {
        private ChiTietVeRepo chiTietVeRepo;

        public NhanVienHuyVeService()
        {
            chiTietVeRepo = new ChiTietVeRepo();
        }

        public List<ThongTinVeDTO> loadThongTinVeService(string s)
        {
            return chiTietVeRepo.thongTinVeVes(s);
        }

        public void capNhatTrangThaiVeService(string maCTV)
        {
            chiTietVeRepo.capNhatTrangThaiVe(maCTV);
        }
    }
}
