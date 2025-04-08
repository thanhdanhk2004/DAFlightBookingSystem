using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class GiaVeChuyenBay
    {
        public int MaHangGhe {  get; set; }
        public float GiaVe {  get; set; }
        public string LoaiGhe { get; set; }
        public string MaCB { get; set; }
        public ChuyenBay ChuyenBay { get; set; }
    }
}
