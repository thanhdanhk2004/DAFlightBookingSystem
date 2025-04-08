using DataTransferObject.DTO;
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
    public partial class NguoiDungChonChuyenLuotVe : Form
    {
        private List<ChuyenBayDTO> chuyenBayDTOs;
        private ChonChuyenService chonChuyenService;
        public NguoiDungChonChuyenLuotVe()
        {
            InitializeComponent();
            this.chuyenBayDTOs = new List<ChuyenBayDTO>();
            this.chonChuyenService = new ChonChuyenService();
        }

        private Label thongTin(string text, int w, int x, int y, int size, string name, int index)
        {
            Label label = new Label();
            lbNoiDi.Name = name + index.ToString();
            label.Location = new Point(x, y);
            label.Text = text;
            label.Width = w;
            label.Font = new Font("Arial", size);
            return label;
        }
        private PictureBox anhMuiTen()
        {
            PictureBox pic = new PictureBox();
            pic.Image = Image.FromFile("C:\\Users\\add\\Pictures\\BTLLTCSDL\\FlightBookingSystem\\bin\\Picture\\arrow-right.png");
            pic.Location = new Point(270, 30);
            pic.Width = 60;
            pic.Height = 30;
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            return pic;
        }

        // Nut button de chon chuyen di
        private Button chonChuyenBay(string name, int index)
        {
            Button btn = new Button();
            btn.Click += BtChon_Click;
            btn.Name = name + index.ToString();
            btn.Location = new Point(560, 60);
            btn.Text = "Chọn";
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Width = 70;
            btn.Height = 45;
            btn.BackColor = Color.Lime;
            return btn;
        }

        private void cacThongTinChuyenDi(Panel panel, int i, ChuyenBayDTO cb)
        {
            Label lbHangHangKhong = thongTin(cb.hangHangKhong, 100, 10, 5, 13, "lbHangHangKhong", i);
            Label lbNoiDi = thongTin(ThongTinChuyenBaySession.noiDen, 140, 120, 35, 13, "lbNoiDi", i);
            PictureBox pic = anhMuiTen();
            Label lbNoiDen = thongTin(ThongTinChuyenBaySession.noiDi, 140, 370, 35, 13, "lbNoiDen", i);
            Label lbThoiGianDiVaDen = thongTin(cb.thoiGianDi.ToString("HH:mm") + " - " + cb.thoiGianDen.ToString("HH:mm"), 120, 255, 10, 10, "lbThoiGianDiDen", i);
            string diemDungChan = cb.soDiemDungChan == 0 ? "Bay trực tiếp" : (cb.soDiemDungChan.ToString() + " điểm dừng");
            Label lbSoDiemDung = thongTin(diemDungChan, 120, 255, 65, 10, "lbSoDiemDung", i);
            Label lbSoTien = thongTin(cb.giaVe.ToString("N0") + " VND", 180, 10, 90, 13, "lbSoTien", i);
            lbSoTien.ForeColor = Color.Red;
            Button btn = chonChuyenBay("btnChonChuyen", i);
            btn.Tag = cb.maChuyenBay;
            panel.Controls.Add(lbHangHangKhong);
            panel.Controls.Add(lbNoiDi);
            panel.Controls.Add(pic);
            panel.Controls.Add(lbNoiDen);
            panel.Controls.Add(lbThoiGianDiVaDen);
            panel.Controls.Add(lbSoDiemDung);
            panel.Controls.Add(lbSoTien);
            panel.Controls.Add(btn);
        }
        private Panel taoPanel(int i, int y, ChuyenBayDTO cb)
        {
            Panel panel = new Panel();
            panel.Name = "chuyenDi" + i.ToString();
            panel.Width = 640;
            panel.Height = 115;
            panel.BackColor = Color.White;
            panel.Location = new Point(16, y);
            cacThongTinChuyenDi(panel, i, cb);
            return panel;
        }
        private void NguoiDungChonChuyenLuotVe_Load(object sender, EventArgs e)
        {

            //Load thong tin chuyen bay
            lbNoiDi.Text = ThongTinChuyenBaySession.noiDen;
            lbNoiDen.Text = ThongTinChuyenBaySession.noiDi;
            lbThongTinChuyenBay.Text = ThongTinChuyenBaySession.soLuongVe.ToString() + " người" + "| "
                                 + ThongTinChuyenBaySession.ngayVe.ToString("dd/MM/yyyy") + "| "
            + ThongTinChuyenBaySession.hangVe;

            string hangVe = ThongTinChuyenBaySession.hangVe == "Phổ thông" ? "PHOTHONG" : "THUONGGIA";
            this.chuyenBayDTOs = chonChuyenService.chonChuyenBay(ThongTinChuyenBaySession.noiDen,
                                                                ThongTinChuyenBaySession.noiDi,
                                                                hangVe, ThongTinChuyenBaySession.ngayVe);
            int i = 0;
            foreach (ChuyenBayDTO cb in chuyenBayDTOs)
            {
                Panel panel = taoPanel(i, 20 + (135 * i), cb);
                cacChuyenDiLuotVe.Controls.Add(panel);
                i++;
            }
        }

        public void locChuyenBay(string hangBay, string thoiGianBay, string soDiemDung)
        {
            cacChuyenDiLuotVe.Controls.Clear();
            List<ChuyenBayDTO> chuyenBayDTODaLocs = chonChuyenService.chonChuyenBay(hangBay, thoiGianBay, soDiemDung, this.chuyenBayDTOs);
            int i = 0;
            foreach (ChuyenBayDTO cb in chuyenBayDTODaLocs)
            {
                Panel panel = this.taoPanel(i, 20 + (135 * i), cb);
                cacChuyenDiLuotVe.Controls.Add(panel);
                i++;
            }
        }


        private void BtChon_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            ThongTinChuyenBayLuotVeSesstion.maChuyenBay = btn.Tag.ToString();
            ThongTinVe thongTinVe = new ThongTinVe();
            TrangChuNguoiDung trangChuNguoiDung = (TrangChuNguoiDung)this.ParentForm;
            if(trangChuNguoiDung !=  null)
                trangChuNguoiDung.showForm(thongTinVe);
        }
        private void lbLuotDi_Click(object sender, EventArgs e)
        {

        }

        private void cbHangBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.locChuyenBay(cbHangBay.Text, cbThoiGianBay.Text, cbSoDiemDung.Text);
        }

        private void cbThoiGianBay_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.locChuyenBay(cbHangBay.Text, cbThoiGianBay.Text, cbSoDiemDung.Text);
        }

        private void cbSoDiemDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.locChuyenBay(cbHangBay.Text, cbThoiGianBay.Text, cbSoDiemDung.Text);
        }
    }
}
