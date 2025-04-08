using FlightBookingSytem_BLL.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DangKy : Form
    {
        private TaiKhoanService taiKhoanService;

        public DangKy()
        {
            InitializeComponent();
            taiKhoanService = new TaiKhoanService();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            string ho = txtHo.Text.Trim();
            string ten = txtTen.Text.Trim();
            string tenDangNhap = txtTenDangNhap.Text;
            string soDienThoai = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string xacNhanMatKhau = txtXacNhanMatKhau.Text.Trim();
            string gioiTinh = rbNam.Checked == true ? "Nam" : "Nữ";
            string maOTP = txtOTP.Text.Trim();
            string chuoiThongBao = taiKhoanService.dangKy(ho, ten, tenDangNhap, soDienThoai, email, matKhau, xacNhanMatKhau, gioiTinh, maOTP);
            if (chuoiThongBao == "")
            {
                MessageBox.Show("Đăng ký thành công");
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show(chuoiThongBao);
            }
        }

        private void lbDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }
    }
}
