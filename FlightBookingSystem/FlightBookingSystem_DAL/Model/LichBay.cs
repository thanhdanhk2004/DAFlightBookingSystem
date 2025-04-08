using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class LichBay
    {
        public string MaLich {  get; set; }
        public DateTime NgayLapLich { get; set; }
        public string MaChuyenBay {  get; set; }
        public int MaNV { get; set; }
        public ChuyenBay ChuyenBay { get; set; }
        public NhanVien NhanVien { get; set; }
    }
}
