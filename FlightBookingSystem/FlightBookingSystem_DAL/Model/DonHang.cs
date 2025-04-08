using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class DonHang
    {
        public string MaDH {  get; set; }
        public DateTime NgayDatHang { get; set; }
        public float TongGiaTriDonHang {  get; set; }
        public int MaKH {  get; set; }
        public KhachHang KhachHang { get; set; }
        public List<Ve> Ves {  get; set; }     
        public ThanhToan ThanhToan { get; set; }
        public DonHangKhuyenMai DonHangKhuyenMai { get; set; }
        public DonHangOffline DonHangOffline { get; set; }
    }
}
