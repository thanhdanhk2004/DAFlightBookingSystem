using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Repo;
using FlightBookingSytem_BLL.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSytem_BLL.Service
{
    public class ChonChuyenService
    {
        private ChuyenBayRepo chuyenBayRepo;
        public ChonChuyenService()
        {
            chuyenBayRepo = new ChuyenBayRepo();
        }

        public List<ChuyenBayDTO> chonChuyenBay(string noiDi, string noiDen, string hangVe, DateTime ngayDi)
        {
            return chuyenBayRepo.loadChuyenBay(noiDi, noiDen, hangVe, ngayDi);
        }

        //Hàm lấy số điểm dừng
        public int laySoDiemDungChan(string soDiemDungChan)
        {
            if(soDiemDungChan == "Bay trực tiếp")
                return 0;
            else if(soDiemDungChan == "Một điểm dừng")
                return 1;
            else if(soDiemDungChan == "Hai điểm dừng")
                return 2;
            return -1;
        }

        //Hàm lấy thời gian bay
        public int layThoiGianBay(string thoiGianBay)
        {
            if (thoiGianBay == "Buổi sáng")
                return 12;
            else if (thoiGianBay == "Buổi chiều")
                return 18;
            else if (thoiGianBay == "Buổi tối")
                return 23;
            return -1;
        }
        public List<ChuyenBayDTO> chonChuyenBay(string hangHangKhong, string thoiGianbay, string soDiemDung, List<ChuyenBayDTO> chuyenBayDTOs)
        {
            int time = layThoiGianBay(thoiGianbay);
            int soDiemDungChan = laySoDiemDungChan(soDiemDung);
            return chuyenBayRepo.loadChuyenBay(time, thoiGianbay, hangHangKhong, soDiemDungChan, chuyenBayDTOs);
        }
    }
}
