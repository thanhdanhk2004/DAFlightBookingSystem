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
    public partial class TrangChuAdmin : Form
    {
        public TrangChuAdmin()
        {
            InitializeComponent();
        }

        public void formShow(Form form)
        {
            form.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            BaoCaoThongKe baoCaoThongKe = new BaoCaoThongKe();
            formShow(baoCaoThongKe);
        }

        private void TrangChuAdmin_Load(object sender, EventArgs e)
        {
            BaoCaoThongKe baoCaoThongKe = new BaoCaoThongKe();
            formShow(baoCaoThongKe);
        }
    }
}
