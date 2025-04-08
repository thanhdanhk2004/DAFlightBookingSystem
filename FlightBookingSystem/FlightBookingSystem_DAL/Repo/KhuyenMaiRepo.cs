using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class KhuyenMaiRepo
    {
        private Context.DatabaseContext _context;

        public KhuyenMaiRepo()
        {
            _context = new Context.DatabaseContext();
        }

        public float loadGiaTriKhuyenMaiDAL(DateTime ngayDi)
        {
            return _context.KhuyenMais
                    .Where(km => km.NgayBatDau.Date == ngayDi.Date)
                    .Select(km => km.TyLeGiam)
                    .FirstOrDefault();
        }

        public string loadMaKhuyenMai(DateTime ngayDi)
        {
            return _context.KhuyenMais
                    .Where(km => km.NgayBatDau.Date == ngayDi.Date)
                    .Select(km => km.MaKM)
                    .FirstOrDefault();
        }

    }
}
