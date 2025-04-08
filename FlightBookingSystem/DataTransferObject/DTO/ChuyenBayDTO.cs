using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTO
{
    public class ChuyenBayDTO
    {
        public string hangHangKhong { get; set; }
        public DateTime thoiGianDi { get; set; }
        public DateTime thoiGianDen { get; set; }
        public int soDiemDungChan { get; set; }
        public float giaVe { get; set; }
        public string maChuyenBay { get; set; }
    }
}
