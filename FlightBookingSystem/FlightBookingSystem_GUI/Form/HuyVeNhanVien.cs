using DataTransferObject.DTO;
using FlightBookingSytem_BLL.Service;
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
    public partial class HuyVeNhanVien : Form
    {
        private NhanVienHuyVeService nhanVienHuyVeService;
        public HuyVeNhanVien()
        {
            InitializeComponent();
            nhanVienHuyVeService = new NhanVienHuyVeService();
        }


        private void HuyVeNhanVien_Load(object sender, EventArgs e)
        {
            dvgThongTinVe.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dvgThongTinVe.AutoGenerateColumns = false;

        }

        public void ganThuocTinhDGV()
        {
            dvgThongTinVe.Columns["MaCTV"].DataPropertyName = "MaChiTietVe";
            dvgThongTinVe.Columns["HoTen"].DataPropertyName = "HoTen";
            dvgThongTinVe.Columns["SoCCCD"].DataPropertyName = "SoCCCD";
            dvgThongTinVe.Columns["NoiDi"].DataPropertyName = "NoiDi";
            dvgThongTinVe.Columns["NoiDen"].DataPropertyName = "NoiDen";
            dvgThongTinVe.Columns["NgayDi"].DataPropertyName = "NgayDi";
            dvgThongTinVe.Columns["GiaVe"].DataPropertyName = "GiaVe";
            dvgThongTinVe.Columns["TrangThaiVe"].DataPropertyName = "TrangThaiVe";

            dvgThongTinVe.Columns["NgayDi"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dvgThongTinVe.Columns["GiaVe"].DefaultCellStyle.Format = "N0";

            foreach (DataGridViewColumn col in dvgThongTinVe.Columns)
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void timKiem_Click(object sender, EventArgs e)
        {
            if (txtMa.Text == "")
                MessageBox.Show("Vui lòng điền thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ganThuocTinhDGV();
                List<ThongTinVeDTO> thongTinVeDTOs = nhanVienHuyVeService.loadThongTinVeService(txtMa.Text);
                dvgThongTinVe.DataSource = thongTinVeDTOs;
            }
            btHuy.Enabled = true;
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy vé?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                DataGridViewRow rowSelected = dvgThongTinVe.CurrentRow;
                if(rowSelected != null)
                {
                    if (rowSelected.Cells["TrangThaiVe"].Value?.ToString() == "Chưa bay")
                    {
                        nhanVienHuyVeService.capNhatTrangThaiVeService(rowSelected.Cells["MaCTV"].Value?.ToString());
                        MessageBox.Show("Hủy vé thành công");
                        ganThuocTinhDGV();
                        List<ThongTinVeDTO> thongTinVeDTOs = nhanVienHuyVeService.loadThongTinVeService(txtMa.Text);
                        dvgThongTinVe.DataSource = thongTinVeDTOs;
                    }
                    else
                    {
                        MessageBox.Show("Vé đã bay hoặc đã hủy");
                    }
                }
            }
        }
    }
}
