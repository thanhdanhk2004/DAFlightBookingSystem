using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class ThanhToan
    {
        public string MaThanhToan { get; set; }
        public float SoTien { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public string MaDH {  get; set; }
        public DonHang DonHang { get; set; }
    }
}
