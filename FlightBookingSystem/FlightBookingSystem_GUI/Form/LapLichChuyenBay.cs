using DataTransferObject.DTO;
using FlightBookingSytem_BLL.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LapLichChuyenBay : Form
    {
        private LapLichService lapLichService;
        private bool flagSBTG1 = false;
        private bool flagSBTG2 = false;
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
            comboBox.Name = "sanBayTrungGian" + index.ToString();
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.Width = 150;
            List<string> sanBays = lapLichService.loadDiaDiemSanBayService();
            foreach(string s in sanBays)
                comboBox.Items.Add(s);
            tableSanBayTrungGian.Controls.Add(comboBox, 1, index);
            return comboBox;
        }

        //Tao date time picker ngay dung
        private DateTimePicker ngayVaGioDungTaiSanBayTrungGian(int index, string name, int col)
        {
            DateTimePicker ngay = new DateTimePicker();
            ngay.Name = name + index.ToString();
            tableSanBayTrungGian.Controls.Add(ngay, col, index);
            if (index == 1)
                ngay.ValueChanged += (sender, e) => ngayDung_ValueChanged(index);
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
            ghiChu.Name = "ghiChu" + index.ToString();
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
                cbTuyenBay.Items.Add("Từ " + t.diaDiemDi + " (" + t.maDiaDiemDi + ")" + " đến " + t.diaDiemDen + " (" + t.maDiaDiemDen + ")");
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


        private void ngayKhoiHanh_ValueChanged(object sender, EventArgs e)
        {
            thoiGianKhoiHanh.Value = ngayKhoiHanh.Value.Date;
            ngayDen.MinDate = ngayKhoiHanh.Value;
            if (ngayDen.Value == ngayKhoiHanh.Value)
                thoiGianDen.MinDate = thoiGianKhoiHanh.Value.AddHours(2);

            DateTimePicker dungChan1 = this.Controls.Find("ngayDung1", true).FirstOrDefault() as DateTimePicker;
            if (dungChan1 != null)
            {
                dungChan1.MinDate = DateTimePicker.MinimumDateTime;
                dungChan1.MaxDate = DateTimePicker.MaximumDateTime;
                dungChan1.MinDate = ngayKhoiHanh.Value;
                dungChan1.MaxDate = ngayDen.Value;
            }
            DateTimePicker dungChan2 = this.Controls.Find("ngayDung2", true).FirstOrDefault() as DateTimePicker;
            if (dungChan2 != null)
            {
                MessageBox.Show("hi");
                dungChan2.MinDate = DateTimePicker.MinimumDateTime;
                dungChan2.MaxDate = DateTimePicker.MaximumDateTime;
                dungChan2.MinDate = dungChan1.Value;
                dungChan2.MaxDate = ngayDen.Value;
            }
        }

        private void ngayDen_ValueChanged(object sender, EventArgs e)
        {
            if (ngayKhoiHanh.Value != ngayDen.Value)
                thoiGianDen.MinDate = DateTimePicker.MinimumDateTime;
            else
                thoiGianDen.MinDate = thoiGianKhoiHanh.Value.AddHours(2);


            DateTimePicker dungChan1 = this.Controls.Find("ngayDung1", true).FirstOrDefault() as DateTimePicker;
            if (dungChan1 != null)
            {
                dungChan1.MaxDate = ngayDen.Value;
            }
            DateTimePicker dungChan2 = this.Controls.Find("ngayDung2", true).FirstOrDefault() as DateTimePicker;
            if (dungChan2 != null)
            {
                dungChan2.MaxDate = ngayDen.Value;
            }
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


        public void rangBuocDungChan(DateTimePicker dateTimeNgayDung, DateTimePicker dateTimeGioDung, DateTimePicker dateTimeGioTiepTuc, int index)
        {
            dateTimeNgayDung.MinDate = ngayKhoiHanh.Value;
            dateTimeNgayDung.MaxDate = ngayDen.Value;
            if (index == 1)
            {
                dateTimeGioDung.Value = thoiGianKhoiHanh.Value.AddMinutes(30);
                dateTimeGioTiepTuc.Value = dateTimeGioDung.Value.AddMinutes(15);
            }
            else
            {
                dateTimeGioDung.Value = thoiGianKhoiHanh.Value.AddMinutes(60);
                dateTimeGioTiepTuc.Value = dateTimeGioDung.Value.AddMinutes(15);
            }
        }


        private void btThemChuyenBayTrungGian_Click(object sender, EventArgs e)
        {
            soSanBayTrungGian += 1;
            if (soSanBayTrungGian == 1)
            {
                tableSanBayTrungGian.Visible = true;
                btThemChuyenBayTrungGian.Enabled = true;
                flagSBTG1 = true;
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
                rangBuocDungChan(ngayDung1, gioDung1, gioTiepTuc1, 1);
                TextBox ghiChu1 = ghiChuSanBayTrungGian(1);
            }
            else
            {
                flagSBTG2 = true;
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
                rangBuocDungChan(ngayDung2, gioDung2, gioTiepTuc2, 2);
                gioTiepTuc2.Enabled = false;
                TextBox ghiChu1 = ghiChuSanBayTrungGian(2);
                btThemChuyenBayTrungGian.Enabled = false;
                btThemChuyenBayTrungGian.BackColor = Color.Gray;
            }

        }


        private void btThem_Click(object sender, EventArgs e)
        {
            if (cbTuyenBay.Text == "") MessageBox.Show("Vui lòng chọn tuyến bay!", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (cbMayBay.Text == "") MessageBox.Show("Vui lòng chọn máy bay", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // Lay ma san bay di va ma san bay den
                string mau = @"\((.*?)\)";
                List<string> maSanBay = new List<string>();
                MatchCollection matches = Regex.Matches(cbTuyenBay.Text, mau);
                foreach (Match match in matches)
                {
                    maSanBay.Add(match.Groups[1].Value);
                }

                string soHieuMB = cbMayBay.Text;
                //
                DateTime TGDi = ngayKhoiHanh.Value.Date.Add(thoiGianKhoiHanh.Value.TimeOfDay);
                DateTime TGDen = ngayDen.Value.Date.Add(thoiGianDen.Value.TimeOfDay);
                float soTien = float.Parse(cbSoTienTrieu.Text) * 1000000 + float.Parse(cbSoTienTram.Text) * 100000 + float.Parse(cbSoTienChuc.Text) * 10000;
                MessageBox.Show(maSanBay[0]);
                MessageBox.Show(maSanBay[1]);
                if(flagSBTG1 == true)
                {
                    ComboBox cbSanBayTrungGian1 = this.Controls.Find("sanBayTrungGian1", true).FirstOrDefault() as ComboBox;
                    DateTimePicker ngayDungChan1 = this.Controls.Find("ngayDung1", true).FirstOrDefault() as DateTimePicker;
                    DateTimePicker gioDungChan1 = this.Controls.Find("gioDung1", true).FirstOrDefault() as DateTimePicker;
                    DateTimePicker gioTiepTuc1 = this.Controls.Find("gioTiepTuc1", true).FirstOrDefault() as DateTimePicker;
                    DateTime thoiGianDungChan1 = ngayDungChan1.Value.Date.Add(gioDungChan1.Value.TimeOfDay);
                    DateTime thoiGianTiepTuc1 = ngayDungChan1.Value.Date.Add(gioTiepTuc1.Value.TimeOfDay);
                    TextBox ghiChu1 = this.Controls.Find("ghiChu1", true).FirstOrDefault() as TextBox;
                    

                    if (flagSBTG2 == true)
                    {
                        ComboBox cbSanBayTrungGian2 = this.Controls.Find("sanBayTrungGian2", true).FirstOrDefault() as ComboBox;
                        DateTimePicker ngayDungChan2 = this.Controls.Find("ngayDung2", true).FirstOrDefault() as DateTimePicker;
                        DateTimePicker gioDungChan2 = this.Controls.Find("gioDung2", true).FirstOrDefault() as DateTimePicker;
                        DateTimePicker gioTiepTuc2 = this.Controls.Find("gioTiepTuc2", true).FirstOrDefault() as DateTimePicker;
                        DateTime thoiGianDungChan2 = ngayDungChan2.Value.Date.Add(gioDungChan2.Value.TimeOfDay);
                        DateTime thoiGianTiepTuc2 = ngayDungChan2.Value.Date.Add(gioTiepTuc2.Value.TimeOfDay);
                        TextBox ghiChu2 = this.Controls.Find("ghiChu2", true).FirstOrDefault() as TextBox;
                        if (cbSanBayTrungGian2.Text == cbSanBayTrungGian1.Text)
                        {
                            MessageBox.Show("Hai sân bay trung gian không được trùng", "Cảnh bảo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else
                            lapLichService.themChuyenBayService(maSanBay[0], maSanBay[1], soHieuMB, TGDi, TGDen,
                                soTien, cbSanBayTrungGian1.Text, thoiGianDungChan1, thoiGianTiepTuc1, ghiChu1.Text,
                                cbSanBayTrungGian2.Text, thoiGianDungChan2, thoiGianTiepTuc2, ghiChu2.Text);
                            
                    }
                    else
                        lapLichService.themChuyenBayService(maSanBay[0], maSanBay[1], soHieuMB, TGDi, TGDen,
                                soTien, cbSanBayTrungGian1.Text, thoiGianDungChan1, thoiGianTiepTuc1, ghiChu1.Text);
                }
                else
                    lapLichService.themChuyenBayService(maSanBay[0], maSanBay[1], soHieuMB, TGDi, TGDen, soTien);
                flagSBTG1 = flagSBTG2 = false;
                
                MessageBox.Show("Thêm chuyến bay thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void thoiGianDung_ValueChanged(int index)
        {
            DateTimePicker gioDung = this.Controls.Find("gioDung" + index, true).FirstOrDefault() as DateTimePicker;
            DateTimePicker gioTiepTuc = this.Controls.Find("gioTiepTuc" + index, true).FirstOrDefault() as DateTimePicker;
            if (gioDung != null && gioTiepTuc != null)
                gioTiepTuc.Value = gioDung.Value.AddMinutes(15);
        }

        private void ngayDung_ValueChanged(int index)
        {
            DateTimePicker ngayDung1 = this.Controls.Find("ngayDung1", true).FirstOrDefault() as DateTimePicker;
            DateTimePicker ngayDung2 = this.Controls.Find("ngayDung2", true).FirstOrDefault() as DateTimePicker;
            if (ngayDung2 != null && ngayDung1 != null)
            {
                ngayDung2.MinDate = DateTimePicker.MinimumDateTime;
                ngayDung2.MaxDate = DateTimePicker.MaximumDateTime;
                ngayDung2.MinDate = ngayDung1.Value;
                ngayDung2.MaxDate = ngayDen.Value;
            }
        }

        private void cbSoTienTrieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSoTien.Text = (float.Parse(cbSoTienTrieu.Text) * 1000000 + float.Parse(cbSoTienTram.Text) * 100000 + float.Parse(cbSoTienChuc.Text) * 10000).ToString("N0") + " VND";
        }

        private void cbSoTienTram_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSoTien.Text = (float.Parse(cbSoTienTrieu.Text) * 1000000 + float.Parse(cbSoTienTram.Text) * 100000 + float.Parse(cbSoTienChuc.Text) * 10000).ToString("N0") + " VND";
        }

        private void cbSoTienChuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbSoTien.Text = (float.Parse(cbSoTienTrieu.Text) * 1000000 + float.Parse(cbSoTienTram.Text) * 100000 + float.Parse(cbSoTienChuc.Text) * 10000).ToString("N0") + " VND";
        }
    }
}
