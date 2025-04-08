using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class ChuyenBay
    {
        public string MaChuyenBay { get; set; }
        public DateTime ThoiGianDi {  get; set; }
        public DateTime ThoiGianDen { get; set; }
        public string SoHieuMB { get; set; }
        public string MaTuyenBay { get; set; }
        public MayBay MayBay { get; set; }
        public TuyenBay TuyenBay { get; set; }
        public List<SanBayTrungGian> SanBayTrungGians { get; set; }
        public LichBay LichBay { get; set; }
        public List<ChiTietVe> ChiTietVes { get; set; }
        public List<GiaVeChuyenBay> GiaVeChuyenBays { get; set; }
    }
}
