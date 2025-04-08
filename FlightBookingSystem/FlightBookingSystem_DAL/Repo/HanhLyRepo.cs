using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class HanhLyRepo
    {
        private Context.DatabaseContext _context;
        public HanhLyRepo()
        {
            _context = new Context.DatabaseContext();
        }
        public void themHanhLy(HanhLy hanhLy)
        {
            _context.HanhLys.Add(hanhLy);
            _context.SaveChanges();
        }
    }
}
