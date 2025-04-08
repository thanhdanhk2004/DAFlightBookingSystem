using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class TuyenBay
    {
        public string MaTuyenBay {  get; set; }
        public string MaSanBayDen {  get; set; }
        public string MaSanBayDi {  get; set; }
        public SanBay SanBayDen { get; set; }
        public SanBay SanBayDi { get; set; }
        public List<ChuyenBay> ChuyenBays { get; set; }
    }
}
