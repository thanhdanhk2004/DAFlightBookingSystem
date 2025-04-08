using FlightBookingSystem_GUI.GUI;
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
    public partial class TrangChuNhanVien : Form
    {
        private Avatar Avatar;
        public TrangChuNhanVien()
        {
            InitializeComponent();
            this.Avatar = new Avatar();
        }

        private void TrangChuNhanVien_Load(object sender, EventArgs e)
        {
            this.Avatar.loadAvatar(picAvatar, lbHello);
            BanVe banVe = new BanVe();
            banVe.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(banVe);
            banVe.Dock = DockStyle.Fill;
            banVe.FormBorderStyle = FormBorderStyle.None;
            banVe.Show();
        }

        public void formShow(Form form)
        {
            form.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void btLapLich_Click(object sender, EventArgs e)
        {
            LapLichChuyenBay lapLichChuyenBay = new LapLichChuyenBay();
            this.formShow(lapLichChuyenBay);
        }
    }
}
