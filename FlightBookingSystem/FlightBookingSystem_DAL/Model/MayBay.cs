using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class MayBay
    {
        public string SoHieuMB {  get; set; }
        public string SoHieuHang { get; set; }
        public HangMayBay HangMayBay { get; set; }
        public List<Ghe> Ghes { get; set; }
        public List<ChuyenBay> ChuyenBays { get; set; }
    }
}
