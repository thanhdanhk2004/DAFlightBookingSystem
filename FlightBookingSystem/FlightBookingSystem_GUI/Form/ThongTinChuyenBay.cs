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
    public partial class ThongTinChuyenBay : Form
    {
        private DatVeService datVeService;
        public ThongTinChuyenBay()
        {
            InitializeComponent();
            datVeService = new DatVeService();
        }
        private void picChatBox_Click(object sender, EventArgs e)
        {
            groupBoxChat.Visible = true;
            groupBoxChat.BringToFront();
        }

        private void picDong_Click(object sender, EventArgs e)
        {
            groupBoxChat.Visible = false;
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            btTru.Enabled = true;
            int soLuongVe = int.Parse(lbSoLuongVe.Text[0].ToString());
            soLuongVe++;
            lbSoLuongVe.Text = soLuongVe.ToString() + " Vé";
            if (soLuongVe >= 5)
            {
                btCong.Enabled = false;
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            btCong.Enabled = true;
            int soLuongVe = int.Parse(lbSoLuongVe.Text[0].ToString());
            soLuongVe--;
            lbSoLuongVe.Text = soLuongVe.ToString() + " Vé";
            if (soLuongVe <= 1)
            {
                btTru.Enabled = false;
            }
        }

        private void picSwap_Click(object sender, EventArgs e)
        {
            string temp = cbNoiDi.Text;
            cbNoiDi.Text = cbNoiDen.Text;
            cbNoiDen.Text = temp;
        }

        private void cbLoaiVe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLoaiVe.Text == "Khứ hồi")
            {
                ngayVe.Enabled = true;
                checkBoxKhuHoi.Checked = true;
                ngayVe.MinDate = ngayDi.Value;
            }
            else
            {
                ngayVe.Enabled = false;
                checkBoxKhuHoi.Checked = false;
                ngayVe.MinDate = ngayDi.Value;
            }
        }

        private void checkBoxKhuHoi_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKhuHoi.Checked == true)
            {
                ngayVe.Enabled = true;
                cbLoaiVe.Text = "Khứ hồi";
                ngayVe.MinDate = ngayDi.Value;
            }
            else
            {
                ngayVe.Enabled = false;
                cbLoaiVe.Text = "Một chiều";
                ngayVe.MinDate = ngayDi.Value;
            }
        }

        private void btTImKiem_Click(object sender, EventArgs e)
        {
            if (cbNoiDi.Text == "")
                MessageBox.Show("Vui lòng chọn nơi đi!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cbNoiDen.Text == "")
                MessageBox.Show("Vui lòng chọn nơi đến!", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cbNoiDi.Text == cbNoiDen.Text)
                MessageBox.Show("Vui lòng chọn nơi đi khác nơi đến", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ThongTinChuyenBaySession.loaiVe = cbLoaiVe.Text;
                ThongTinChuyenBaySession.hangVe = cbHangVe.Text;
                ThongTinChuyenBaySession.soLuongVe = int.Parse(lbSoLuongVe.Text[0].ToString());
                ThongTinChuyenBaySession.noiDi = cbNoiDi.Text;
                ThongTinChuyenBaySession.noiDen = cbNoiDen.Text;
                ThongTinChuyenBaySession.ngayDi = ngayDi.Value;
                if (cbLoaiVe.Text == "Khứ hồi" || checkBoxKhuHoi.Checked == true)
                    ThongTinChuyenBaySession.ngayVe = ngayVe.Value;
                TrangChuNguoiDung trangChuNguoiDung = (TrangChuNguoiDung)this.ParentForm;
                NguoiDungChonChuyen nguoiDungChonChuyen = new NguoiDungChonChuyen();
                if(trangChuNguoiDung !=  null)
                    trangChuNguoiDung.showForm(nguoiDungChonChuyen);
            }
        }

        private void ngayDi_ValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiVe.Text == "Khứ hồi" || checkBoxKhuHoi.Checked == true)
                ngayVe.MinDate = ngayDi.Value;
        }

        private void ThongTinChuyenBay_Load(object sender, EventArgs e)
        {
            List<string> diaDiemSanBay = datVeService.diaDiemDiVaDen();
            foreach (string i in diaDiemSanBay)
            {
                cbNoiDi.Items.Add(i);
                cbNoiDen.Items.Add(i);
            }
            btTru.Enabled = false;
            ngayVe.Enabled = false;
            ngayDi.MinDate = DateTime.Now;
            ngayVe.MinDate = DateTime.Now;
        }
    }
}
