using FlightBookingSystem_DAL.Model;
using FlightBookingSystem_DAL.Repo;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using FlightBookingSytem_BLL.Session;

namespace FlightBookingSytem_BLL.Service
{
    public class TaiKhoanService
    {
        private TaiKhoanRepo taiKhoanRepo;
        private NguoiDungRepo nguoiDungRepo;
        private KhachHangRepo khachHangRepo;
        public TaiKhoanService()
        {
            taiKhoanRepo = new TaiKhoanRepo();
            nguoiDungRepo = new NguoiDungRepo();
            khachHangRepo = new KhachHangRepo();
        }

        private bool kiemTraSDT(string sdt)
        {
            string mauKiemTra = @"^0\d{9}$";
            return Regex.IsMatch(sdt, mauKiemTra);
        }

        private bool kiemTraEmail(string email)
        {
            string mauKiemTra = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, mauKiemTra);
        }

        private string taoMaOTP()
        {
            Random rd = new Random();
            return rd.Next(10000, 99999).ToString();
        }

        public string dangKy(string ho, string ten, string tenDangNhap, string soDienThoai, string email, string matKhau, string xacNhanMatKhau, string gioiTinh, string OTP)
        {
            string maOTP = taoMaOTP();
            if (ho == "") return "Họ không được để trống!";
            else if (ten == "") return "Tên không được để trống!";
            else if (tenDangNhap == "") return "Tên đăng nhập không được để trống!";
            else if (soDienThoai == "") return "Số điện thoại không được để trống!";
            else if (email == "") return "Email không được để trống";
            else if (matKhau == "") return "Mật khẩu không được để trống!";
            else if (xacNhanMatKhau == "") return "Xác nhận mật khẩu không được để trống!";
            else if (OTP == "") return "Mã OTP không được để trống!";
            else if (matKhau.Equals(xacNhanMatKhau) == false) return "Mat khau khong trung khop!";
            else if (kiemTraSDT(soDienThoai) == false) return "Số điện thoại không phù hợp";
            else if (kiemTraEmail(email) == false) return "Email không hợp lệ!";
            else if (nguoiDungRepo.kiemTraSoDienThoaiDaTonTai(soDienThoai)) return "Số điện thoại đã tồn tại!";
            //else if (maOTP.Equals(OTP) == false) return "MaOTP khong hop le!";
            else if (taiKhoanRepo.kiemTraTonTaiTenDangNhap(tenDangNhap)) return "Tên đăng nhập đã tồn tạ!";
            else
            {
                NguoiDung u = new NguoiDung
                {
                    Ho = ho,
                    Ten = ten,
                    Email = email,
                    SoDienThoai = soDienThoai,
                    GioiTinh = gioiTinh,
                };
                nguoiDungRepo.themNguoiDuong(u);
               
                KhachHang khachHang = new KhachHang
                {
                    HangThanhVien = "Đồng",
                    MaKhachHang = u.IdNguoiDung,
                };
                khachHangRepo.themKhachHang(khachHang);

                string password = BCrypt.Net.BCrypt.HashPassword(matKhau);
                TaiKhoan a = new TaiKhoan
                {
                    TenDangNhap = tenDangNhap,
                    MatKhau = password,
                    IdNguoiDung = u.IdNguoiDung,
                    
                };
                taiKhoanRepo.themTaiKhoan(a);
                return "";
            }
        }

        public string dangNhap(string tenDangNhap, string matKhau)
        {
            if (tenDangNhap == "") return "Tên đăng nhập không được rỗng!";
            else if (matKhau == "") return "Mật khẩu không được rỗng!";
            else
            {
                TaiKhoan tk = taiKhoanRepo.layTaiKhoan(tenDangNhap);
                if (tk == null)
                    return "Tên đăng nhập không chính xác!";
                if(BCrypt.Net.BCrypt.Verify(matKhau, tk.MatKhau))
                {
                    NguoiDung u = nguoiDungRepo.loadNguoiDung(tk.IdNguoiDung);
                    UserSession.ten = u.Ten;
                    UserSession.gioiTinh = u.GioiTinh;
                    UserSession.IdNguoiDung = tk.IdNguoiDung;
                    UserSession.vaiTro = tk.VaiTro;
                    return "#" + tenDangNhap;
                }
                return "Mật khẩu không chính xác!";
            }
        }

        public void taoTaiKhoanNhanVien()
        {
            TaiKhoan tk = new TaiKhoan
            {
                TenDangNhap = "LeThanhDan",
                MatKhau = BCrypt.Net.BCrypt.HashPassword("1"),
                IdNguoiDung = 2,
                VaiTro = "Employee"
            };
            taiKhoanRepo.themTaiKhoan(tk);
        }
    }
}
