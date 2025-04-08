using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class HangMayBay
    {
        public string SoHieuHang {  get; set; }
        public string TenHang {  get; set; }
        public List<MayBay> MayBays { get; set; }
    }
}
