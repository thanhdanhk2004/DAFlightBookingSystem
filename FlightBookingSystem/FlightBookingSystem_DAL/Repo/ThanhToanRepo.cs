using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class ThanhToanRepo
    {
        private Context.DatabaseContext _context;
        public ThanhToanRepo()
        {
            _context = new Context.DatabaseContext();
        }
        public void themThanhToan(ThanhToan thanhToan)
        {
            _context.ThanhToans.Add(thanhToan);
            _context.SaveChanges();
        }
    }
}
