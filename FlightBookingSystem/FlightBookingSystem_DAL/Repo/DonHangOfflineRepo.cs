using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class DonHangOfflineRepo
    {
        private Context.DatabaseContext _context;
        public DonHangOfflineRepo()
        {
            _context = new Context.DatabaseContext();
        }
        public void themDonHangOffline(DonHangOffline donHangOffline)
        {
            _context.DonHangOfflines.Add(donHangOffline);
            _context.SaveChanges();
        }
    }
}
