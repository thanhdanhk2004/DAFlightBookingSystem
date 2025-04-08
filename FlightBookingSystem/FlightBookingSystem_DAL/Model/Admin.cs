using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Model
{
    public class Admin
    {
        public int MaAdmin {  get; set; }
        public string KinhNghiem {  get; set; }
        public NguoiDung NguoiDung { get; set; }
    }
}
