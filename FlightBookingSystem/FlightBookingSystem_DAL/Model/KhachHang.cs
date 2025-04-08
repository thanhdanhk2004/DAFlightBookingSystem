using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class KhachHang
    {
        public int MaKhachHang {  get; set; }
        public string HangThanhVien { get; set;}
        public List<DonHang> DonHangs { get; set; }
        public NguoiDung NguoiDung { get; set; }
    }
}
