using DataTransferObject.DTO;
using FlightBookingSystem_GUI;
using FlightBookingSystem_GUI.GUI;
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
    public partial class BanVe : Form
    {
        private BanVeService banVeService;
        private bool flag = false;
        public BanVe()
        {
            InitializeComponent();
            this.banVeService = new BanVeService();
        }

        private void BanVe_Load(object sender, EventArgs e)
        {
            //Cho cac cot ra giua
            dgvChuyenBay.ColumnHeadersDefaultCellStyle.Alignment
                = DataGridViewContentAlignment.MiddleCenter;

            //Khong cho tu dong tao cot
            dgvChuyenBay.AutoGenerateColumns = false;

            List<string> diaDiemSanBay = banVeService.diaDiemDiVaDen();
            foreach (string i in diaDiemSanBay)
            {
                cbNoiDi.Items.Add(i);
                cbNoiDen.Items.Add(i);
            }
            ngayVe.Enabled = false;
            ngayDi.MinDate = DateTime.Now;
            ngayVe.MinDate = DateTime.Now;

            btChonChuyen.Enabled = false;
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

        //Gan thuoc tinh vao cot
        public void ganThuocTinh()
        {
            dgvChuyenBay.Columns["MaCB"].DataPropertyName = "maChuyenBay";
            dgvChuyenBay.Columns["HangHangKhong"].DataPropertyName = "hangHangKhong";
            dgvChuyenBay.Columns["ThoiGianDi"].DataPropertyName = "thoiGianDi";
            dgvChuyenBay.Columns["ThoiGianDen"].DataPropertyName = "thoiGianDen";
            dgvChuyenBay.Columns["SoTien"].DataPropertyName = "giaVe";
            dgvChuyenBay.Columns["SoDiemDung"].DataPropertyName = "soDiemDungChan";

            //Format du lieu
            dgvChuyenBay.Columns["ThoiGianDi"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvChuyenBay.Columns["ThoiGianDen"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvChuyenBay.Columns["SoTien"].DefaultCellStyle.Format = "N0";

            //Can giua du lieu
            foreach (DataGridViewColumn col in dgvChuyenBay.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
                ThongTinChuyenBaySession.soLuongVe = int.Parse(cbSoLuongve.Text);
                ThongTinChuyenBaySession.noiDi = cbNoiDi.Text;
                ThongTinChuyenBaySession.noiDen = cbNoiDen.Text;
                ThongTinChuyenBaySession.ngayDi = ngayDi.Value;
                if (cbLoaiVe.Text == "Khứ hồi" || checkBoxKhuHoi.Checked == true)
                    ThongTinChuyenBaySession.ngayVe = ngayVe.Value;
            }

            this.ganThuocTinh();
            List<ChuyenBayDTO> chuyenBayDTOs = this.banVeService.loadChuyenBayBLL(cbNoiDi.Text, cbNoiDen.Text, cbHangVe.Text == "Phổ thông" ? "PHOTHONG" : "THUONGGIA", ngayDi.Value);
            dgvChuyenBay.DataSource = chuyenBayDTOs;
            foreach (DataGridViewRow row in dgvChuyenBay.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells["NoiDi"].Value = ThongTinChuyenBaySession.noiDi;
                    row.Cells["NoiDen"].Value = ThongTinChuyenBaySession.noiDen;
                }
            }
            if (cbLoaiVe.Text == "Khứ hồi")
                MessageBox.Show("Mời bạn chọn chuyến lượt đi!");
            btChonChuyen.Enabled = true;
        }

        private void btChonChuyen_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Xác nhận chọn", "Xác nhận lựa chọn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                DataGridViewRow selectedRow = dgvChuyenBay.CurrentRow;
                if (selectedRow == null)
                    MessageBox.Show("Vui lòng chọn chuyến đi!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (selectedRow != null && flag == false)
                {
                    ThongTinChuyenBayLuotDiSession.maChuyenBay = selectedRow.Cells["MaCB"].Value?.ToString();
                    ThongTinChuyenBayLuotDiSession.soTien = float.Parse(selectedRow.Cells["SoTien"].Value?.ToString());
                }
                else
                {
                    ThongTinChuyenBayLuotVeSesstion.maChuyenBay = selectedRow.Cells["MaCB"].Value?.ToString();
                    ThongTinChuyenBayLuotVeSesstion.soTien = float.Parse(selectedRow.Cells["SoTien"].Value?.ToString());
                }
                if (cbLoaiVe.Text == "Khứ hồi" && this.flag == false)
                {
                    List<ChuyenBayDTO> chuyenBayDTOs = this.banVeService.loadChuyenBayBLL(cbNoiDen.Text, cbNoiDi.Text, cbHangVe.Text == "Phổ thông" ? "PHOTHONG" : "THUONGGIA", ngayVe.Value);
                    dgvChuyenBay.DataSource = chuyenBayDTOs;
                    foreach (DataGridViewRow row in dgvChuyenBay.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            row.Cells["NoiDi"].Value = ThongTinChuyenBaySession.noiDen;
                            row.Cells["NoiDen"].Value = ThongTinChuyenBaySession.noiDi;
                        }
                    }
                    MessageBox.Show("Mời bạn chọn chuyến lượt về!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    DienThongTinVe dienThongTinVe = new DienThongTinVe();
                    TrangChuNhanVien trangChuNhanVien = (TrangChuNhanVien)this.ParentForm;
                    if (trangChuNhanVien != null)
                        trangChuNhanVien.formShow(dienThongTinVe);
                }
            }
            this.flag = true;
        }

        private void ngayDi_ValueChanged(object sender, EventArgs e)
        {
            if (cbLoaiVe.Text == "Khứ hồi" || checkBoxKhuHoi.Checked == true)
                ngayVe.MinDate = ngayDi.Value;
        }
    }
}
