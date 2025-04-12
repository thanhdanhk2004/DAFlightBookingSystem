using DataTransferObject.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class ThongKeDoanhThuRepo
    {
        private Context.DatabaseContext _context;
        public ThongKeDoanhThuRepo()
        {
            _context = new Context.DatabaseContext();
        }

        public List<DoanhSoDTO> doanhSoTheoThang()
        {
            return _context.ThanhToans
                .GroupBy(tt => tt.NgayThanhToan.Month)
                .Select(g => new DoanhSoDTO 
                {
                    ThoiGian = g.Key,
                    SoTien = g.Sum(tt => tt.SoTien),
                }).ToList();
        }

        public List<DoanhSoDTO> doanhSoTheoQuy()
        {
            return _context.ThanhToans
                .GroupBy(tt => (tt.NgayThanhToan.Month-1)/3+1)
                .Select(g => new DoanhSoDTO
                {
                    ThoiGian = g.Key,
                    SoTien = g.Sum(tt => tt.SoTien)
                }).ToList();
        }

        public List<DoanhSoDTO> doanhSoTheoNam()
        {
            return _context.ThanhToans
                .GroupBy(tt => tt.NgayThanhToan.Year)
                .Select(g => new DoanhSoDTO
                {
                    ThoiGian = g.Key,
                    SoTien = g.Sum(tt => tt.SoTien)
                }).ToList();
        }
    }
}
