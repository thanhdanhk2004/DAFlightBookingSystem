using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class GiaVeChuyenBayRepo
    {
        private Context.DatabaseContext _context;
        public GiaVeChuyenBayRepo()
        {
            _context = new Context.DatabaseContext();
        }
        public void themGiaVeChuyenBay(GiaVeChuyenBay giaVeChuyenBay)
        {
            _context.GiaVeChuyenBays.Add(giaVeChuyenBay);
            _context.SaveChanges();
        }
    }
}
