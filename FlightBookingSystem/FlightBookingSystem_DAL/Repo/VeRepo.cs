using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightBookingSystem_DAL.Model;

namespace FlightBookingSystem_DAL.Repo
{
    public class VeRepo
    {
        private Context.DatabaseContext _context;
        public VeRepo()
        {
            this._context = new Context.DatabaseContext();
        }
        public void themVe(Ve ve)
        {
            _context.Ves.Add(ve);
            _context.SaveChanges();
        }
    }
}
