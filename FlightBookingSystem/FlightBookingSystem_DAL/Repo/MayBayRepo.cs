using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class MayBayRepo
    {
        private Context.DatabaseContext _context;
        public MayBayRepo()
        {
            _context = new Context.DatabaseContext();
        }

        public List<string> loadMayBay()
        {
            return _context.MayBays
                .Select(mb => mb.SoHieuMB).ToList();
        }                                        
    }
}
