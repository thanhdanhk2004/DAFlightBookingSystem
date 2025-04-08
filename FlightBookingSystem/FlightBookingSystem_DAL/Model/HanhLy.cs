using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class HanhLy
    {
        public string MaHL { get; set; }
        public string MoTaHL { get; set; }
        public string TrongLuong {  get; set; }
        public float ChiPhi {  get; set; }
        public ChiTietVe ChiTietVe { get; set; }
    }
}
