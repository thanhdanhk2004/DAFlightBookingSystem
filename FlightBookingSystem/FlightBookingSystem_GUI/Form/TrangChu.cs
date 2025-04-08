using FlightBookingSystem_DAL.Model;
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
    public partial class TrangChu : Form
    {

        public TrangChu()
        {
            InitializeComponent();
        }




        private void TrangChu_Load(object sender, EventArgs e)
        {
            if (UserSession.gioiTinh == "Nam")
                picAvata.Image = Image.FromFile(@"C:\Users\add\Pictures\DoAnLTCSDL\FlightBookingSystem\bin\Picture\profile.png");
            else if (UserSession.gioiTinh == "Nữ")
                picAvata.Image = Image.FromFile(@"C:\Users\add\Pictures\DoAnLTCSDL\FlightBookingSystem\bin\Picture\woman.png");
            else
                picAvata.Image = Image.FromFile(@"C:\Users\add\Pictures\DoAnLTCSDL\FlightBookingSystem\bin\Picture\user.png");
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
            this.Close();
        }

        private void btTImKiem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng đăng nhập!");
        }
    }
}
