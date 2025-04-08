using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class NguoiDungRepo
    {
        private Context.DatabaseContext _context;
        public NguoiDungRepo()
        {
            _context = new Context.DatabaseContext();
        }

        public bool kiemTraSoDienThoaiDaTonTai(string soDienThoai)
        {
            return _context.NguoiDungs.Any(u => u.SoDienThoai == soDienThoai);
        }
        public void themNguoiDuong(NguoiDung u)
        {
            _context.NguoiDungs.Add(u);
            _context.SaveChanges();
        }

        public NguoiDung loadNguoiDung(int id)
        {
            return _context.NguoiDungs.FirstOrDefault(u => u.IdNguoiDung == id);
        }
    }
}
