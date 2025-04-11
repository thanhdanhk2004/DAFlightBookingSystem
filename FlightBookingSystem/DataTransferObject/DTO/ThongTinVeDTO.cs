using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject.DTO
{
    public class ThongTinVeDTO
    {
        public string MaChiTietVe {  get; set; }
        public string HoTen {  get; set; }
        public string SoCCCD {  get; set; }
        public string NoiDi {  get; set; }
        public string NoiDen { get; set; }
        public DateTime NgayDi { get; set; }
        public float GiaVe { get; set; }
        public string TrangThaiVe {  get; set; }

    }
}
