using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class Ghe
    {
        public int MaGhe {  get; set; }
        public string HangGhe {  get; set; }
        public string SoHieuMB {  get; set; }
        public string TrangThaiGhe { get; set; }
        public MayBay MayBay { get; set; }
        public ChiTietVe ChiTietVe { get; set; }
    }
}
