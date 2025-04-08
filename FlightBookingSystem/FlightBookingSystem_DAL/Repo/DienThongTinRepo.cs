using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class DienThongTinRepo
    {
        private Context.DatabaseContext _context;
        public DienThongTinRepo()
        {
            _context = new Context.DatabaseContext();
        }

        public float giaGhe(string maChuyenBay, string hangve)
        {
            return _context.ChuyenBays
                    .Join(_context.GiaVeChuyenBays,
                    cb => cb.MaChuyenBay,
                    gvcb => gvcb.MaCB,
                    (cb, gvcb) => new { cb, gvcb})
                    .Where(x => x.cb.MaChuyenBay == maChuyenBay && x.gvcb.LoaiGhe ==  hangve)
                    .Select(x => x.gvcb.GiaVe)
                    .FirstOrDefault();
        }
    }
}
