using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class Ve
    {
        public string MaVe {  get; set; }
        public string LoaiVe {  get; set; } // Ve 1 chieu hay khu hoi
        public DateTime NgayXuatVe {  get; set; }
        public string MaDH {  get; set; }
        public int MaNguoiSoHuu { get; set; }
        public DonHang DonHang { get; set; }
        public NguoiDung NguoiDung { get; set; }
        public List<ChiTietVe> ChiTietVes { get; set; }
    }
}
