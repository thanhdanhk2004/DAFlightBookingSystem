using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class SanBayTrungGian
    {
        public string MaSanBayTrungGian {  get; set; }
        public string MaTuyenBay { get; set; }
        public string MaChuyenBay { get; set; }
        public DateTime ThoiGianDungChan {  get; set; }
        public DateTime ThoiGianTiepTuc {  get; set; }
        public string GhiChu {  get; set; }
        public ChuyenBay ChuyenBay { get; set; }
        public string MaSanBay {  get; set; }   
        public SanBay SanBay { get; set; }
    }
}
