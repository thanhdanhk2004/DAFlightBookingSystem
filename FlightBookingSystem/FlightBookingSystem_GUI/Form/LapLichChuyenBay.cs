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
using System.Web;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LapLichChuyenBay : Form
    {
        private LapLichService lapLichService;
        public LapLichChuyenBay()
        {
            InitializeComponent();
            lapLichService = new LapLichService();
        }

        private int soSanBayTrungGian;
        private Label thongTin(string text, int c, int r)
        {
            Label lblTin = new Label();
            lblTin.Text = text;
            lblTin.TextAlign = ContentAlignment.MiddleCenter;
            tableSanBayTrungGian.Controls.Add(lblTin, c, r);
            return lblTin;
        }

        //Tao combo box Chọn sân bay trung gian
        private ComboBox sanBay(int index)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Name = "SanBayTrungGian" + index.ToString();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Width = 150;
            tableSanBayTrungGian.Controls.Add(comboBox, 1, index);
            return comboBox;
        }

        //Tao date time picker ngay dung
        private DateTimePicker ngayVaGioDungTaiSanBayTrungGian(int index, string name, int col)
        {
            DateTimePicker ngay = new DateTimePicker();
            ngay.Name = name + index.ToString();
            tableSanBayTrungGian.Controls.Add(ngay, col, index);
            //ngay.ValueChanged += (sender, e) => ngayDung_ValueChanged(index);
            return ngay;
        }

        private DateTimePicker gioDungVaTiepTucTaiSanBayTrungGian(int index, string name, int col)
        {
            DateTimePicker ngay = new DateTimePicker();
            ngay.Name = name + index.ToString();
            tableSanBayTrungGian.Controls.Add(ngay, col, index);
            ngay.ValueChanged += (sender, e) => thoiGianDung_ValueChanged(index);
            return ngay;
        }

        //Tao maskedTextBox gio dung va gio bay

        //Tao Text box ghi chu
        private TextBox ghiChuSanBayTrungGian(int index)
        {
            TextBox ghiChu = new TextBox();
            ghiChu.Name = "GhiChu" + index.ToString();
            ghiChu.Width = 200;
            tableSanBayTrungGian.Controls.Add(ghiChu, 5, index);
            return ghiChu;
        }

        //Chinh gio phut giay
        public void chinhThoiGian(DateTimePicker dateTimePicker)
        {
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "HH:mm:ss";
            dateTimePicker.ShowUpDown = true;
        }
        private void LapLichChuyenBay_Load(object sender, EventArgs e)
        {
            soSanBayTrungGian = 0;
            //Load cac tuyen bay
            List<TuyenBayDTO> tuyenBayDTOs = lapLichService.loadTuyenBayService();
            foreach (TuyenBayDTO t in tuyenBayDTOs)
                cbTuyenBay.Items.Add(t.diaDiemDi + "(" + t.maDiaDiemDi + ")" + " -> " + t.diaDiemDen + "(" + t.maDiaDiemDen + ")");
            //Load may bay
            List<string> mayBays = lapLichService.loadMayBay();
            foreach (string s in mayBays)
                cbMayBay.Items.Add(s);

            ngayKhoiHanh.MinDate = DateTime.Now.AddDays(7);
            ngayDen.MinDate = ngayKhoiHanh.Value;
            thoiGianKhoiHanh.Value = ngayKhoiHanh.Value.Date; // Set ve 00:00:00
            thoiGianDen.MinDate = thoiGianKhoiHanh.Value.AddHours(2);
        }

        // Ap dieu kien thoi gian cho cac chuyen bay trung gian
        public void rangBuocDungChan(DateTimePicker dateTimeNgayDung, DateTimePicker dateTimeGioDung, DateTimePicker dateTimeGioTiepTuc)
        {
            dateTimeNgayDung.MinDate = ngayKhoiHanh.Value;
            dateTimeNgayDung.MaxDate = ngayDen.Value;
            dateTimeGioDung.Value = thoiGianKhoiHanh.Value.AddMinutes(30);
            dateTimeGioTiepTuc.Value = dateTimeGioDung.Value.AddMinutes(15);
        }
        
        private void btThemChuyenBayTrungGian_Click(object sender, EventArgs e)
        {
            soSanBayTrungGian += 1;
            if (soSanBayTrungGian == 1)
            {
                tableSanBayTrungGian.Visible = true;
                btThemChuyenBayTrungGian.Enabled = true;
                Label soThuTu = thongTin("STT", 0, 0);
                Label sanBayTrungGian = thongTin("Sân bay trung gian", 1, 0);
                Label ngayDung = thongTin("Ngày dừng", 2, 0);
                Label gioDung = thongTin("Giờ dừng", 3, 0);
                Label gioTiepTuc = thongTin("Giờ tiếp tục", 4, 0);
                Label ghiChu = thongTin("Ghi chú", 5, 0);
                Label sanBayTrungGian1 = thongTin("1", 0, 1);
                tableSanBayTrungGian.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
                ComboBox sanBay1 = sanBay(1);

                //Ngay dung so 1
                DateTimePicker ngayDung1 = ngayVaGioDungTaiSanBayTrungGian(1, "ngayDung", 2);
                ngayDung1.MinDate = ngayKhoiHanh.Value;

                //Gio dung va thoi gian tiep tuc
                DateTimePicker gioDung1 = gioDungVaTiepTucTaiSanBayTrungGian(1, "gioDung", 3);
                chinhThoiGian(gioDung1);
                DateTimePicker gioTiepTuc1 = gioDungVaTiepTucTaiSanBayTrungGian(1, "gioTiepTuc", 4);
                chinhThoiGian(gioTiepTuc1);
                gioTiepTuc1.Enabled = false;
                rangBuocDungChan(ngayDung1, gioDung1, gioTiepTuc1 );
                TextBox ghiChu1 = ghiChuSanBayTrungGian(1);
            }
            else
            {
                tableSanBayTrungGian.RowStyles.Add(new RowStyle(SizeType.Percent, 38F));
                Label sanBayTrungGian1 = thongTin("2", 0, 2);
                ComboBox sanBay1 = sanBay(2);
                DateTimePicker ngayDung2 = ngayVaGioDungTaiSanBayTrungGian(2, "NgayDung", 2);
                ngayDung2.MinDate = ngayKhoiHanh.Value;

                //Gio dung va thoi gian tiep tuc
                DateTimePicker gioDung2 = gioDungVaTiepTucTaiSanBayTrungGian(2, "gioDung", 3);
                chinhThoiGian(gioDung2);
                DateTimePicker gioTiepTuc2 = gioDungVaTiepTucTaiSanBayTrungGian(2, "gioTiepTuc", 4);
                chinhThoiGian(gioTiepTuc2);

                TextBox ghiChu1 = ghiChuSanBayTrungGian(2);
                btThemChuyenBayTrungGian.Enabled = false;
                btThemChuyenBayTrungGian.BackColor = Color.Gray;
            }

        }

        private void ngayKhoiHanh_ValueChanged(object sender, EventArgs e)
        {
            thoiGianKhoiHanh.Value = ngayKhoiHanh.Value.Date;
            ngayDen.MinDate = ngayKhoiHanh.Value;
            if (ngayDen.Value == ngayKhoiHanh.Value)
                thoiGianDen.MinDate = thoiGianKhoiHanh.Value.AddHours(2);

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbTuyenBay.Text == "") MessageBox.Show("Vui lòng chọn tuyến bay!", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cbMayBay.Text == "") MessageBox.Show("Vui lòng chọn máy bay", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void ngayDen_ValueChanged(object sender, EventArgs e)
        {
            if (ngayKhoiHanh.Value != ngayDen.Value)
                thoiGianDen.MinDate = DateTimePicker.MinimumDateTime;
            else
                thoiGianDen.MinDate = thoiGianKhoiHanh.Value.AddHours(2);

        }

        private void thoiGianKhoiHanh_ValueChanged(object sender, EventArgs e)
        {
            if (ngayDen.Value == ngayKhoiHanh.Value)
            {
                thoiGianDen.Value = thoiGianKhoiHanh.Value.AddHours(2);
                thoiGianDen.MinDate = thoiGianKhoiHanh.Value.AddHours(2);
            }
            else
                thoiGianDen.MinDate = DateTimePicker.MinimumDateTime;
        }

        private void thoiGianDung_ValueChanged(int index)
        {
            DateTimePicker gioDung = this.Controls.Find("gioDung"+index, true).FirstOrDefault() as DateTimePicker;
            DateTimePicker gioTiepTuc = this.Controls.Find("gioTiepTuc" + index, true).FirstOrDefault() as DateTimePicker;
            if(gioDung != null && gioTiepTuc != null)
                gioTiepTuc.Value = gioDung.Value.AddMinutes(15);
        }
    }
}
