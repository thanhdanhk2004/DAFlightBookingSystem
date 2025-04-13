using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class NhanVienRepo
    {
        private Context.DatabaseContext _context;
        public NhanVienRepo()
        {
            _context = new Context.DatabaseContext();
        }
        public void themNhanVien(NhanVien nhanVien)
        {
            _context.NhanViens.Add(nhanVien);
            _context.SaveChanges();
        }
    }
}
