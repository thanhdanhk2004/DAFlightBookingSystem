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
    }
}
