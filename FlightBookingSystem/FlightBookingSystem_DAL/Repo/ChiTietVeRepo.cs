using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class ChiTietVeRepo
    {
        private Context.DatabaseContext _context;
        public ChiTietVeRepo()
        {
            _context = new Context.DatabaseContext();
        }
        public void themChiTietVe(ChiTietVe chiTietVe)
        {
            _context.ChiTietVes.Add(chiTietVe);
            _context.SaveChanges();
        }

        public List<ThongTinVeDTO> thongTinVeVes(string s)
        {
            var result = from nd in _context.NguoiDungs
                         join ve in _context.Ves
                         on nd.IdNguoiDung equals ve.MaNguoiSoHuu
                         join ctv in _context.ChiTietVes
                         on ve.MaVe equals ctv.MaVe
                         join cb in _context.ChuyenBays
                         on ctv.MaChuyenBay equals cb.MaChuyenBay
                         join tb in _context.TuyenBays
                         on cb.MaTuyenBay equals tb.MaTuyenBay
                         join sbdi in _context.SanBays
                         on tb.MaSanBayDi equals sbdi.MaSanBay
                         join sbden in _context.SanBays
                         on tb.MaSanBayDen equals sbden.MaSanBay
                         where (nd.SoCCCD == s || ctv.MaChiTietVe == s)
                         select new ThongTinVeDTO
                         {
                             MaChiTietVe = ctv.MaChiTietVe,
                             HoTen = nd.Ho +" "+ nd.Ten,
                             SoCCCD = nd.SoCCCD,
                             NoiDi = sbdi.DiaDiem,
                             NoiDen = sbden.DiaDiem,
                             GiaVe = ctv.GiaVe,
                             TrangThaiVe = ctv.TrangThaiVe,
                             NgayDi = cb.ThoiGianDi
                         };
            return result.ToList();
        }

        public void capNhatTrangThaiVe(string maCTV)
        {
            var chiTietVe = _context.ChiTietVes.FirstOrDefault(ctv => ctv.MaChiTietVe == maCTV);
            if (chiTietVe != null)
            {
                chiTietVe.TrangThaiVe = "Đã hủy";
                _context.SaveChanges();
            }
        }
    }
}
