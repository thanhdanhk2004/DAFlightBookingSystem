using FlightBookingSystem_DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBookingSystem_DAL.Repo
{
    public class TaiKhoanRepo
    {
        private Context.DatabaseContext _context;
        public TaiKhoanRepo()
        {
            _context = new Context.DatabaseContext();
        }

        //Kiem tra user name da ton tai hay chua
        public bool kiemTraTonTaiTenDangNhap(string tenDangNhap)
        {
            return _context.TaiKhoans.Any(u => u.TenDangNhap == tenDangNhap);
        }
        public void themTaiKhoan(TaiKhoan tk)
        { 
            _context.TaiKhoans.Add(tk);
            _context.SaveChanges();
        }

        //Lay tai khoan de dang nhap
        public TaiKhoan layTaiKhoan(string tenDangNhap)
        {
            return _context.TaiKhoans.FirstOrDefault(a => a.TenDangNhap == tenDangNhap);
        } 
    }
}
