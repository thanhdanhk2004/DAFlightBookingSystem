using FlightBookingSystem_DAL.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Media;
using FlightBookingSytem_BLL.Service;
using System.Runtime.Intrinsics.Arm;

namespace FlightBookingSystem_GUI
{
    public partial class TaiKhoanNhanVien : Form
    {
        private TaiKhoanService taiKhoanService;
        public TaiKhoanNhanVien()
        {
            InitializeComponent();
            taiKhoanService = new TaiKhoanService();
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtHo.Text == "") MessageBox.Show("Họ không được để trống!");
            else if (txtTen.Text == "") MessageBox.Show("Tên không được để trống!");
            else if (txtTenDangNhap.Text == "") MessageBox.Show("Tên đăng nhập không được để trống!");
            else if (txtSoDienThoai.Text == "") MessageBox.Show("Số điện thoại không được để trống!");
            else if (txtEmail.Text == "") MessageBox.Show("Email không được để trống");
            else if (txtMatKhau.Text == "") MessageBox.Show("Mật khẩu không được để trống!");
            else if (kiemTraSDT(txtSoDienThoai.Text) == false) MessageBox.Show("Số điện thoại không phù hợp");
            else if (kiemTraEmail(txtEmail.Text) == false) MessageBox.Show("Email không hợp lệ!");
            else
            {
                string gioiTinh = rbNam.Checked == true ? "Nam" : "Nữ";
                taiKhoanService.taoTaiKhoanNhanVien(txtHo.Text, txtTen.Text, txtEmail.Text, txtSoDienThoai.Text, gioiTinh, txtGhiChu.Text, txtTenDangNhap.Text, txtMatKhau.Text);
                MessageBox.Show("Them tai khoan thanh cong");
            }
        }
    }
}
