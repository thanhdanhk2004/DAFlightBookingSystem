using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class TaiKhoan
    {
        public int idTaiKhoan {  get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau {  get; set; }
        public bool TrangThai { get; set; }
        public string VaiTro { get; set; } 
        public int IdNguoiDung { get; set; }
        public NguoiDung NguoiDung { get; set; }

    }
}
