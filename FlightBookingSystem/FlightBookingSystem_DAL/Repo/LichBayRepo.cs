using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class LichBayRepo
    {
        private Context.DatabaseContext _context;
        public LichBayRepo()
        {
            _context = new Context.DatabaseContext();
        }
        public void themLichBay(LichBay lichBay)
        {
            _context.LichBays.Add(lichBay);
            _context.SaveChanges();
        }
    }
}
