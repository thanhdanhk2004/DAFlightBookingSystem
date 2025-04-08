using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class NhanVien 
    {
        public int MaNV { get; set; }
        public float Luong {  get; set; }
        public DateTime NgayVaoLam { get; set; }
        public string GhiChu { get; set; }
        public List<DonHangOffline> DonHangOfflines { get; set; }
        public List<LichBay> LichBays { get; set; }
        public NguoiDung NguoiDung { get; set; }
    }
}
