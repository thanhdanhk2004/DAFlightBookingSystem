using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class DonHangRepo
    {
        private Context.DatabaseContext _context;
        public DonHangRepo()
        {
            this._context = new Context.DatabaseContext();
        }
        public void themDonHang(DonHang donHang)
        {
            _context.DonHangs.Add(donHang);
            _context.SaveChanges();
        }
    }
}
