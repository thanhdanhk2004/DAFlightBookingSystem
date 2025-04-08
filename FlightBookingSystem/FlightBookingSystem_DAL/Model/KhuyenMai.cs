using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class KhuyenMai
    {
        public string MaKM { get; set; }
        public string MoTa {  get; set; }
        public float TyLeGiam {  get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public List<DonHangKhuyenMai> DonHangKhuyenMais { get; set; }
    }
}
