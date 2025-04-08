using FlightBookingSytem_BLL.Service;
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
    public partial class MoDau : Form
    {
        //TaiKhoanService taiKhoanService;
        public MoDau()
        {
            InitializeComponent();
            //this.taiKhoanService = new TaiKhoanService();
        }

        private async void MoDau_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                thanhTrangThai.Value = i;
                if (i < 60)
                    await Task.Delay(30);
                else if (i < 80)
                    await Task.Delay(70);
                else
                    await Task.Delay(120);
            }
            //this.taiKhoanService.taoTaiKhoanNhanVien();
            this.Hide();
            TrangChu trangChu = new TrangChu();
            trangChu.ShowDialog();
            this.Close();
        }
    }
}
