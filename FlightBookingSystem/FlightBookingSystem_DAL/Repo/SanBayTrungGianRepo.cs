using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class SanBayTrungGianRepo
    {
        private Context.DatabaseContext _context;
        public SanBayTrungGianRepo()
        {
            _context = new Context.DatabaseContext();
        }
        public void themSanBayTrungGian(SanBayTrungGian sanBayTrungGian)
        {
            _context.SanBayTrungGians.Add(sanBayTrungGian);
            _context.SaveChanges();
        }
    }
}
