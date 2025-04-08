using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class ChiTietVe
    {
        public string MaChiTietVe {  get; set; }
        public string MaChuyenBay {  get; set; }
        public string MaVe {  get; set; }
        public string MaHL { get; set; }
        public int MaGhe {  get; set; }
        public float GiaVe { get; set; } // Gia cua mot chuyen di hoac ve
        public ChuyenBay ChuyenBay { get; set; }
        public Ve Ve { get; set; }
        public HanhLy HanhLy { get; set; }
        public Ghe Ghe { get; set; }
    }
}
