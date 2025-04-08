using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class DonHangKhuyenMaiRepo
    {
        private Context.DatabaseContext _context;
        public DonHangKhuyenMaiRepo()
        {
            this._context = new Context.DatabaseContext();
        }
        public void themDonHangKhuyenMai(DonHangKhuyenMai donHangKhuyenMai)
        {
            _context.DonHangKhuyenMais.Add(donHangKhuyenMai);
            _context.SaveChanges();
        }
    }
}
