using DataTransferObject.DTO;
using FlightBookingSystem_GUI;
using FlightBookingSytem_BLL;
using FlightBookingSytem_BLL.Service;
using FlightBookingSytem_BLL.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DienThongTinVe : Form
    {
        private BanVeService banVeService;
        private KhuyenMaiService khuyenMaiService;
        private LuuVeService luuVeService;
        private float tyLeKhuyenMai = 0;
        private float soTien = 0;
        private float soTienLuotDi = 0, soTienLuotVe = 0;
        public DienThongTinVe()
        {
            InitializeComponent();
            this.banVeService = new BanVeService();
            this.khuyenMaiService = new KhuyenMaiService();
            this.luuVeService = new LuuVeService();
        }
        //Tao cac text thong tin
        private Label thongTin(string text, int x, int y, int w, int h, int size)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.Width = w;
            label.Height = h;
            label.Font = new Font("Arial", size);
            return label;
        }

        //Tao textbox dien thong tin
        private TextBox textDienThongTin(int x, int y, int w, int h, string name, int index)
        {
            TextBox textBox = new TextBox();
            textBox.Name = name + index.ToString();
            textBox.Location = new Point(x, y);
            textBox.Width = w;
            textBox.Height = h;
            return textBox;
        }

        // Tao radio box lua chon khoi luong hanh ly
        private RadioButton rbtnkhoiLuongHanhLy(int x, int y, string name, string text, int index, float soTien)
        {
            RadioButton radioButton = new RadioButton();
            radioButton.Name = name + index.ToString();
            radioButton.Location = new Point(x, y);
            radioButton.Text = text;
            radioButton.Width = 80;
            radioButton.CheckedChanged += (sender, e) => CapNhatSoTien(index, soTien);
            return radioButton;
        }

        private DateTimePicker ngaySinh(int index)
        {
            DateTimePicker dtp = new DateTimePicker();
            dtp.Name = "ngaySinhHanhKhach" + index.ToString();
            dtp.Location = new Point(350, 75);
            dtp.Height = 20;
            dtp.Width = 140;
            dtp.MaxDate = DateTime.Now;
            return dtp;
        }

        // Tao Panel thong tin mot ve
        private Panel thongTinMotVe(int index)
        {
            Panel panel = new Panel();
            // Tao lable hanh khach
            Label hanhKhach = thongTin("Hanh khach 1", 300, 10, 140, 25, 12);
            hanhKhach.ForeColor = Color.Red;

            // Tao lable nhap ho, ten, soCCCD va so tien
            Label hoHanhKhach = thongTin("Ho", 20, 40, 50, 20, 11);
            hoHanhKhach.ForeColor = Color.Blue;
            Label tenHanhKhach = thongTin("Ten", 120, 40, 50, 20, 11);
            tenHanhKhach.ForeColor = Color.Blue;
            Label soCCCD = thongTin("SoCCCD", 220, 40, 90, 20, 11);
            soCCCD.ForeColor = Color.Blue;
            Label ngaySinhHanhKhach = thongTin("Ngay sinh", 350, 40, 100, 25, 11);
            ngaySinhHanhKhach.ForeColor = Color.Blue;
            Label khoiLuongHanhLy = thongTin("Khoi luong HL", 520, 40, 140, 25, 11);
            khoiLuongHanhLy.ForeColor = Color.Blue;
            

            string hangVe = ThongTinChuyenBaySession.hangVe == "Phổ thông" ? "PHOTHONG" : "THUONGGIA";
            soTienLuotDi = banVeService.giaVeService(ThongTinChuyenBayLuotDiSession.maChuyenBay, hangVe);
            if (ThongTinChuyenBaySession.loaiVe == "Khứ hồi")
                soTienLuotVe = banVeService.giaVeService(ThongTinChuyenBayLuotVeSesstion.maChuyenBay, hangVe);
            this.soTien += (soTienLuotDi + soTienLuotVe);
            Label soTien = thongTin("Số tiền: "+(soTienLuotDi + soTienLuotVe).ToString("N0")+" VND", 250, 120, 250, 20, 11);
            soTien.ForeColor = Color.Red;

            //Them cac text box nhap ho, ten, soCCCD
            TextBox txtHoHanhKhach = textDienThongTin(20, 75, 65, 20, "txtHoKhachHang", index);
            txtHoHanhKhach.Validating += txtHoTen_Validating;
            TextBox txtTenHanhKhach = textDienThongTin(120, 75, 65, 20, "txtTenKhachHang", index);
            txtTenHanhKhach.Validating += txtHoTen_Validating;
            TextBox txtSoCCCDHanhKhach = textDienThongTin(220, 75, 110, 20, "txtSoCCCDKhachHang", index);
            txtSoCCCDHanhKhach.Validating += txtSoCCCD_Validating;

            //Them datetimepicker de chon ngay sinh
            DateTimePicker dtpNgaySinh = ngaySinh(index);

            //Them radio button
            RadioButton rbntKhoiLuongHanhLyBeHon15kg = rbtnkhoiLuongHanhLy(520, 75, "beHon15kg", "<= 15 kg", index, soTienLuotDi+soTienLuotVe);
            rbntKhoiLuongHanhLyBeHon15kg.Checked = true;
            RadioButton rbntKhoiLuongHanhLyLonHon15kg = rbtnkhoiLuongHanhLy(610, 75, "lonHon15kg", ">15 kg", index, soTienLuotDi+soTienLuotVe);

            //Them cac controls
            panel.Controls.Add(hanhKhach);
            panel.Controls.Add(hoHanhKhach);
            panel.Controls.Add(tenHanhKhach);
            panel.Controls.Add(soCCCD);
            panel.Controls.Add(ngaySinhHanhKhach);
            panel.Controls.Add(khoiLuongHanhLy);
            panel.Controls.Add(soTien);
            panel.Controls.Add(txtHoHanhKhach);
            panel.Controls.Add(txtTenHanhKhach);
            panel.Controls.Add(txtSoCCCDHanhKhach);
            panel.Controls.Add(dtpNgaySinh);
            panel.Controls.Add(rbntKhoiLuongHanhLyBeHon15kg);
            panel.Controls.Add(rbntKhoiLuongHanhLyLonHon15kg);
            lbTongTienThanhToan.Text = this.soTien.ToString("N0") +" VND";
            return panel;
        }

        private void DienThongTinVe_Load(object sender, EventArgs e)
        {

            for (int i = 0; i <ThongTinChuyenBaySession.soLuongVe; i++)
            {
                Panel panel = thongTinMotVe(i);
                panel.Name = "thongTinVeThu" + i.ToString();
                panel.Location = new Point(16, 45 + (170 * i));
                panel.Width = 680;
                panel.Height = 150;
                panel.BackColor = Color.White;
                thongTinHanhKhach.Controls.Add(panel);
            }

            this.tyLeKhuyenMai = khuyenMaiService.loadGiaTriKhuyenMaiBLL();
            lbTongTienSauKhuyenMai.Text = (this.soTien / 100 * (100 - this.tyLeKhuyenMai)).ToString("N0") +" VND";
        }

        private void txtHoTen_Validating(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!Regex.IsMatch(txt.Text, @"^[a-zA-ZÀ-Ỹà-ỹ\s]+$"))
            {
                txt.BackColor = Color.LightCoral;
            }
            else
                txt.BackColor = Color.White;
        }

        private void txtSoCCCD_Validating(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!Regex.IsMatch(txt.Text, @"^0\d{11}$"))
            {
                txt.BackColor = Color.LightCoral;
            }
            else
                txt.BackColor = Color.White;
        }

        private void CapNhatSoTien(int index, float giaTien)
        {
            Panel panel = thongTinHanhKhach.Controls
                            .Find("thongTinVeThu" + index, true)
                            .FirstOrDefault() as Panel;

            if (panel != null)
            {
                RadioButton rbLonHon15 = panel.Controls.Find("lonHon15kg" + index, true).FirstOrDefault() as RadioButton;
                if (rbLonHon15 != null && rbLonHon15.Checked)
                {
                    giaTien += 100000;
                }

                Label lblSoTien = panel.Controls.OfType<Label>()
                                        .FirstOrDefault(l => l.Text.StartsWith("Số tiền:"));
                if (lblSoTien != null)
                    lblSoTien.Text = "Số tiền: " + giaTien.ToString("N0") + " VND";

                //Cập nhật lại số tiền cần thanh toán
                float tienCacChuyen = 0;
                for (int i = 0; i < ThongTinChuyenBaySession.soLuongVe; i++)
                {
                    Label lbSoTienTungChuyen = (thongTinHanhKhach.Controls
                            .Find("thongTinVeThu" + i, true)
                            .FirstOrDefault()).Controls.OfType<Label>().FirstOrDefault(l => l.Text.StartsWith("Số tiền:"));
                    tienCacChuyen += float.Parse(lbSoTienTungChuyen.Text.Replace("Số tiền: ", "").Replace(" VND", ""));
                }
                this.soTien = tienCacChuyen;
                lbTongTienThanhToan.Text = this.soTien.ToString("N0") + " VND";
                lbTongTienSauKhuyenMai.Text = (this.soTien / 100 * (100 - this.tyLeKhuyenMai)).ToString("N0") + " VND";
            }
        }

        private void btXacNhan_Click(object sender, EventArgs e)
        {
            List<NguoiDungDTO> nguoiDungDTOs = new List<NguoiDungDTO>();
            for (int i = 0; i < ThongTinChuyenBaySession.soLuongVe; i++)
            {
                NguoiDungDTO nguoiDungDTO = new NguoiDungDTO();
                Panel p = (Panel)thongTinHanhKhach.Controls.Find("thongTinVeThu" + i, true).FirstOrDefault();
                TextBox lbHo = (TextBox)p.Controls.Find("txtHoKhachHang" + i, true).FirstOrDefault();
                TextBox lbTen = (TextBox)p.Controls.Find("txtTenKhachHang" + i, true).FirstOrDefault();
                TextBox lbSoCCCD = (TextBox)p.Controls.Find("txtSoCCCDKhachHang" + i, true).FirstOrDefault();
                DateTimePicker ngaySinh = (DateTimePicker)p.Controls.Find("ngaySinhHanhKhach" + i, true).FirstOrDefault();
                RadioButton btnHanhLy = (RadioButton)p.Controls.Find("lonHon15kg" + i, true).FirstOrDefault();
                if (lbHo.Text == "" || lbTen.Text == "" || lbSoCCCD.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                nguoiDungDTO.ho = lbHo.Text;
                nguoiDungDTO.ten = lbTen.Text;
                nguoiDungDTO.soCCCD = lbSoCCCD.Text;
                nguoiDungDTO.ngaySinh = ngaySinh.Value;
                nguoiDungDTO.giaTienChuyenBayLuotDi = this.soTienLuotDi;
                nguoiDungDTO.giaTienChuyenBayLuotVe = this.soTienLuotVe;
                nguoiDungDTO.giaTienHanhLy = btnHanhLy.Checked == true ? 100000 : 0;
                nguoiDungDTOs.Add(nguoiDungDTO);
            }
            TienDonHangDTO tienDonHangDTO = new TienDonHangDTO
            {
                tongTienDonHang = float.Parse(lbTongTienThanhToan.Text.Replace(" VND", "")),
                tongTienThanhToan = float.Parse(lbTongTienSauKhuyenMai.Text.Replace(" VND", ""))
            };
            this.banVeService.luuVeKhiBan(nguoiDungDTOs, tienDonHangDTO, cbPhuongThucThanhToan.Text);
            MessageBox.Show("Luu thanh cong");
            
        }
    }
}
