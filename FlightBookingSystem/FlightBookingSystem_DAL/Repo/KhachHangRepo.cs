using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class KhachHangRepo
    {
        private Context.DatabaseContext _context;
        public KhachHangRepo()
        {
            this._context = new Context.DatabaseContext();
        }
        public void themKhachHang(KhachHang khachHang)
        {
            _context.KhachHangs.Add(khachHang);
            _context.SaveChanges();
        }
    }
}
