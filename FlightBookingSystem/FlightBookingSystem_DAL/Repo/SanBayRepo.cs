using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class SanBayRepo
    {
        private Context.DatabaseContext _context;
        public SanBayRepo() 
        { 
            _context = new Context.DatabaseContext();
        }

        public List<String> loadSanBay()
        {
            return _context.SanBays.Select(a => a.DiaDiem).ToList();
        }

        public string loadMaSanBay(string diaDiem)
        {
            return _context.SanBays.Where(sb => sb.DiaDiem == diaDiem)
                    .Select(sb => sb.MaSanBay)
                    .FirstOrDefault().ToString();
        }
    }
}
