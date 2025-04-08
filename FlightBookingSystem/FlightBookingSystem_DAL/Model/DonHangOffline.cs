using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class DonHangOffline
    {
        public string MaDHOffline {  get; set; }
        public int MaNV { get; set; }
        public NhanVien NhanVien { get; set; }
        public DonHang DonHang { get; set; }
    }
}
