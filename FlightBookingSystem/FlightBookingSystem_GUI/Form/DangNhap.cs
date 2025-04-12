using FlightBookingSystem_GUI;
using FlightBookingSytem_BLL.Service;
using FlightBookingSytem_BLL.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DangNhap : Form
    {
        private TaiKhoanService taiKhoanService;
        public DangNhap()
        {
            InitializeComponent();
            taiKhoanService = new TaiKhoanService();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string chuoiThongBao = taiKhoanService.dangNhap(tenDangNhap, matKhau);
            if (chuoiThongBao[0].Equals('#'))
            {
                this.Hide();
                if (UserSession.vaiTro == "User")
                {
                    TrangChuNguoiDung trangChuNguoiDung = new TrangChuNguoiDung();
                    trangChuNguoiDung.ShowDialog();
                }
                else if(UserSession.vaiTro == "Employee")
                {
                    TrangChuNhanVien trangChuNhanVien = new TrangChuNhanVien();
                    trangChuNhanVien.ShowDialog();
                }
                else
                {
                    TrangChuAdmin trangChuAdmin = new TrangChuAdmin();
                    trangChuAdmin.ShowDialog();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show(chuoiThongBao);
            }
        }

        private void lbDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
            this.Close();
        }
    }
}
