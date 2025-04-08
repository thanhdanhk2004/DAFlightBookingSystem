using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class GheRepo
    {
        private Context.DatabaseContext _context;
        public GheRepo()
        {
            this._context = new Context.DatabaseContext();
        }

        public int loadMaGhe(string maChuyenBay, string hangGhe)
        {
            var result = _context.ChuyenBays
                        .Join(_context.MayBays,
                               cb => cb.SoHieuMB,
                               mb => mb.SoHieuMB,
                               (cb, mb) => new {cb, mb})
                        .Join(_context.Ghes,
                        cbmb => cbmb.mb.SoHieuMB,
                        g => g.SoHieuMB, 
                        (cbmb, g) => new {g.MaGhe, g.HangGhe, g.TrangThaiGhe})
                        .Where(x => x.HangGhe == hangGhe && x.TrangThaiGhe == "Còn trống")
                        .Select(x => x.MaGhe)
                        .FirstOrDefault();
             return result;          
        }

        public void capNhatTrangThaiGhe(int maGhe)
        {
            var result = _context.Ghes.FirstOrDefault(g => g.MaGhe == maGhe);
            result.TrangThaiGhe = "Đã đặt";
            _context.SaveChanges();
        }
    }
}
