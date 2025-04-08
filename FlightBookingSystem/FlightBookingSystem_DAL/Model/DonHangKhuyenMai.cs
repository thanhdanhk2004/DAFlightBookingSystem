using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class DonHangKhuyenMai
    {

        public string MaDHKM { get; set; }
        public string MaKM { get; set; }
        public KhuyenMai KhuyenMai { get; set; }
        public DonHang DonHang { get; set; }
    }
}
