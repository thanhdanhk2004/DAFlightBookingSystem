using FlightBookingSystem_GUI.GUI;
using FlightBookingSytem_BLL.Service;
using FlightBookingSytem_BLL.Session;
using PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBookingSystem_GUI
{
    public partial class TrangChuNguoiDung : Form
    {
        private DatVeService datVeService;
        public TrangChuNguoiDung()
        {
            InitializeComponent();
            datVeService = new DatVeService();
        }

        private void TrangChuNguoiDung_Load(object sender, EventArgs e)
        {
            Avatar avatar = new Avatar();
            avatar.loadAvatar(picAvata, txtHello);
            ThongTinChuyenBay thongTinChuyenBay = new ThongTinChuyenBay();
            this.showForm(thongTinChuyenBay);
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            UserSession.ten = "";
            UserSession.gioiTinh = "";
            this.Close();
        }

        public void showForm(Form form)
        {
            form.TopLevel = false ;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();    
        }     
    }
}
