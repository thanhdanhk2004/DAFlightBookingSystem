using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class SanBay
    {
        public string MaSanBay {  get; set; }
        public string DiaDiem { get; set; }
        public string MaKhuVuc { get; set; }
        public KhuVuc KhuVuc { get; set; }
        public List<TuyenBay> TuyenBayDis { get; set; }
        public List<TuyenBay> TuyenBayDens { get; set; }
        public SanBayTrungGian SanBayTrungGian { get; set; }
    }
}
