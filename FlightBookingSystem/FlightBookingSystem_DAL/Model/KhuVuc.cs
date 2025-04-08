using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class KhuVuc
    {
        public string MaKhuVuc {  get; set; }
        public string TenKhuVuc { get; set; }
        public List<SanBay> SanBays { get; set; }
    }
}
