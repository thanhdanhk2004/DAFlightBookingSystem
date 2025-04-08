using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class NguoiDung
    {
        public int IdNguoiDung { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string DiaChi {  get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoCCCD { get; set; }
        public string GioiTinh {  get; set; }
        public List<Ve> Ves { get; set; }
        public TaiKhoan TaiKhoan { get; set; }
        public KhachHang KhachHang { get; set; }
        public NhanVien NhanVien { get; set; }
        public Admin Admin { get; set; }
    }
}
