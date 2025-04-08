using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject.DTO;
using FlightBookingSystem_DAL.Model;

namespace FlightBookingSystem_DAL.Repo
{
    public class ChuyenBayRepo
    {
        private FlightBookingSystem_DAL.Context.DatabaseContext _context;
        public ChuyenBayRepo()
        {
            _context = new Context.DatabaseContext();
        }
        public List<ChuyenBayDTO> loadChuyenBay(string noiDi, string noiDen, string hangVe, DateTime ngayDi)
        {
            var result = from tb in _context.TuyenBays
                         join cb in _context.ChuyenBays
                         on tb.MaTuyenBay equals cb.MaTuyenBay
                         join gvcb in _context.GiaVeChuyenBays
                         on cb.MaChuyenBay equals gvcb.MaCB
                         join mb in _context.MayBays
                         on cb.SoHieuMB equals mb.SoHieuMB
                         join hmb in _context.HangMayBays
                         on mb.SoHieuHang equals hmb.SoHieuHang
                         join sbdi in _context.SanBays
                         on tb.MaSanBayDi equals sbdi.MaSanBay
                         join sbden in _context.SanBays
                         on tb.MaSanBayDen equals sbden.MaSanBay
                         join sbtg in _context.SanBayTrungGians
                         on cb.MaChuyenBay equals sbtg.MaChuyenBay into grouped
                         from sbtg in grouped.DefaultIfEmpty() //Left join
                         where sbdi.DiaDiem == noiDi && sbden.DiaDiem == noiDen
                                && gvcb.LoaiGhe == hangVe && cb.ThoiGianDi.Date == ngayDi.Date
                         group sbtg by new
                         {
                             hmb.TenHang,
                             cb.ThoiGianDi,
                             cb.ThoiGianDen,
                             cb.MaTuyenBay,
                             gvcb.GiaVe,
                             cb.MaChuyenBay
                         } into g
                         select new ChuyenBayDTO
                         {
                             thoiGianDi = g.Key.ThoiGianDi,
                             thoiGianDen = g.Key.ThoiGianDen,
                             hangHangKhong = g.Key.TenHang,
                             giaVe = g.Key.GiaVe,
                             soDiemDungChan = g.Count(x => x != null),
                             maChuyenBay = g.Key.MaChuyenBay,
                         };
            return result.ToList();
        }

        
        public List<ChuyenBayDTO> loadChuyenBay(int t, string thoiGianBay,string hangHangKhong, int soDiemDungChan, List<ChuyenBayDTO> chuyenBayDTOs)
        {

            var result = chuyenBayDTOs.Where(cb => (cb.hangHangKhong == hangHangKhong || hangHangKhong == "Hãng bay" || hangHangKhong == "Tất cả")
                                                    && (cb.soDiemDungChan == soDiemDungChan || soDiemDungChan == -1)
                                                    && ((thoiGianBay == "Buổi sáng" && int.Parse(cb.thoiGianDi.ToString("HH")) < t)
                                                        || (int.Parse(cb.thoiGianDi.ToString("HH")) < t) && t - int.Parse(cb.thoiGianDi.ToString("HH")) < 6
                                                        || t == -1));
            return result.ToList();
        }
    }
}
