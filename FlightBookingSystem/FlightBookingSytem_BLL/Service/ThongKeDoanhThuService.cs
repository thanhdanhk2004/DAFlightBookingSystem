using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSytem_BLL.Service
{
    public class ThongKeDoanhThuService
    {
        private ThongKeDoanhThuRepo thongKeDoanhThuRepo;
        public ThongKeDoanhThuService()
        {
            thongKeDoanhThuRepo = new ThongKeDoanhThuRepo();
        }

        public List<DoanhSoDTO> doanhSoTheoThangService()
        {
            return thongKeDoanhThuRepo.doanhSoTheoThang();
        }

        public List<DoanhSoDTO> doanhSoTheoQuyService()
        {
            return thongKeDoanhThuRepo.doanhSoTheoQuy();
        }

        public List<DoanhSoDTO> doanhSoTheoNamService()
        {
            return thongKeDoanhThuRepo.doanhSoTheoNam();
        }
    }
}
