using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using DataTransferObject.DTO;
using FlightBookingSytem_BLL.Service;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Wpf.Charts.Base;
using CartesianChart = LiveCharts.WinForms.CartesianChart;
using PieChart = LiveCharts.WinForms.PieChart;

namespace FlightBookingSystem_GUI
{
    public partial class BaoCaoThongKe : Form
    {
        private ThongKeDoanhThuService thongKeDoanhThuService;
        public BaoCaoThongKe()
        {
            InitializeComponent();
            thongKeDoanhThuService = new ThongKeDoanhThuService();
        }

        //Tao bieu do cot
        public CartesianChart taoBieuDoCot()
        {
            CartesianChart chart = new CartesianChart();
            chart.Width = 900;
            chart.Height = 350;
            Dock = DockStyle.Fill;
            chart.Background = System.Windows.Media.Brushes.White;
            return chart;
        }

        //Tao bieu do tron
        public PieChart taoBieuDoTron()
        {
            PieChart chart = new PieChart();
            chart.Width = 300;
            chart.Height = 300;
            chart.Location = new Point(300, 20);
            return chart;
        }


        //Tao thong ke cua bieu do cot 
        public void bieuDoThongKeDangCot(List<DoanhSoDTO> list, string thoiGian, CartesianChart chart)
        {
            chart.Series = new SeriesCollection
            {
                new ColumnSeries // Bieu do cot 
                {
                    Title = "Doanh thu", // Chú thích của các cột
                    Values = new ChartValues<float>(list.Select(ds => ds.SoTien))
                }
            };

            chart.AxisX.Add(new Axis
            {
                Title = thoiGian,
                Labels = new List<string>(list.Select(ds => ds.ThoiGian.ToString()))
            });

            chart.AxisY.Add(new Axis
            {
                Title = "Doanh thu (triệu đồng)",
                LabelFormatter = value => value.ToString("N0")
            });
        }

        //Tao thong ke bieu do tron
        public void bieuDoThongKeDangTron(List<DoanhSoDTO> doanhSoDTOs, string thoiGian, PieChart chart)
        {
            foreach (var doanhSoDTO in doanhSoDTOs)
            {
                chart.Series.Add(new PieSeries
                {
                    Title = thoiGian + " " + doanhSoDTO.ThoiGian.ToString() + ":",
                    Values = new ChartValues<float> { doanhSoDTO.SoTien },
                    DataLabels = true, // Hien thi du lieu tren bieu do
                    LabelPoint = chartPoint => $"{chartPoint.Y:N0} VND"
                });
            }
        }

        //Tao thong ke bieu do duong
        public void bieuDoThongKeDangDuong(List<DoanhSoDTO> doanhSoDTOs, string thoiGian, CartesianChart chart)
        {
            chart.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Doanh thu",
                    Values = new ChartValues<float>(doanhSoDTOs.Select(ds => ds.SoTien)),
                    PointGeometry = DefaultGeometries.Circle, // Hình dạng điểm
                    PointGeometrySize = 10, // Kích thước điểm
                    LineSmoothness = 0.5 // Độ cong của đường (0 = đường thẳng, 1 = cong) 
                }
            };

            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = thoiGian,
                Labels = new List<string>(doanhSoDTOs.Select(ds => ds.ThoiGian.ToString()))
            });

            chart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Doanh thu (triệu đồng)",
                LabelFormatter = value => value.ToString("N0")
            });
        }

        private void BaoCaoThongKe_Load(object sender, EventArgs e)
        {
            panelChart.Controls.Clear();
            CartesianChart chart = taoBieuDoCot();
            panelChart.Controls.Add(chart);
            List<DoanhSoDTO> doanhSoTheoThangDTOs = thongKeDoanhThuService.doanhSoTheoThangService();
            bieuDoThongKeDangCot(doanhSoTheoThangDTOs, "Tháng", chart);
        }

        public void mocThoiGian(List<DoanhSoDTO> doanhSoDTOs, string s)
        {
            panelChart.Controls.Clear();
            if (rdCot.Checked == true)
            {
                CartesianChart chart = taoBieuDoCot();
                panelChart.Controls.Add(chart);
                bieuDoThongKeDangCot(doanhSoDTOs, s, chart);
            }
            else if (rdTron.Checked == true)
            {
                PieChart chart = taoBieuDoTron();
                panelChart.Controls.Add(chart);
                bieuDoThongKeDangTron(doanhSoDTOs, s, chart);
            }
            else
            {
                CartesianChart chart = taoBieuDoCot();
                panelChart.Controls.Add(chart);
                bieuDoThongKeDangDuong(doanhSoDTOs, s, chart);
            }
        }

        private void rdThang_CheckedChanged(object sender, EventArgs e)
        {
            List<DoanhSoDTO> doanhSoTheoThang = thongKeDoanhThuService.doanhSoTheoThangService();
            mocThoiGian(doanhSoTheoThang, "Tháng");
        }

        private void rdQuy_CheckedChanged(object sender, EventArgs e)
        {
            List<DoanhSoDTO> doanhSoTheoQuy = thongKeDoanhThuService.doanhSoTheoQuyService();
            mocThoiGian(doanhSoTheoQuy, "Quý");
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            List<DoanhSoDTO> doanhSoTheoNam = thongKeDoanhThuService.doanhSoTheoNamService();
            mocThoiGian(doanhSoTheoNam, "Quý");
        }

        private void rdCot_CheckedChanged(object sender, EventArgs e)
        {
            panelChart.Controls.Clear();
            CartesianChart chart = taoBieuDoCot();
            panelChart.Controls.Add(chart);
            if (rdThang.Checked == true)
            {
                List<DoanhSoDTO> doanhSoDTOs = thongKeDoanhThuService.doanhSoTheoThangService();
                bieuDoThongKeDangCot(doanhSoDTOs, "Tháng", chart);
            }
            else if (rdQuy.Checked == true)
            {
                List<DoanhSoDTO> doanhSoDTOs = thongKeDoanhThuService.doanhSoTheoQuyService();
                bieuDoThongKeDangCot(doanhSoDTOs, "Quý", chart);
            }
            else
            {
                List<DoanhSoDTO> doanhSoDTOs = thongKeDoanhThuService.doanhSoTheoNamService();
                bieuDoThongKeDangCot(doanhSoDTOs, "Năm", chart);
            }
        }

        private void rdTron_CheckedChanged(object sender, EventArgs e)
        {
            panelChart.Controls.Clear();
            PieChart chart = taoBieuDoTron();
            panelChart.Controls.Add(chart);
            if (rdThang.Checked == true)
            {
                List<DoanhSoDTO> doanhSoDTOs = thongKeDoanhThuService.doanhSoTheoThangService();
                bieuDoThongKeDangTron(doanhSoDTOs, "Tháng", chart);
            }
            else if (rdQuy.Checked == true)
            {
                List<DoanhSoDTO> doanhSoDTOs = thongKeDoanhThuService.doanhSoTheoQuyService();
                bieuDoThongKeDangTron(doanhSoDTOs, "Quý", chart);
            }
            else
            {
                List<DoanhSoDTO> doanhSoDTOs = thongKeDoanhThuService.doanhSoTheoNamService();
                bieuDoThongKeDangTron(doanhSoDTOs, "Năm", chart);
            }


        }

        private void rbDuong_CheckedChanged(object sender, EventArgs e)
        {
            panelChart.Controls.Clear();
            CartesianChart chart = taoBieuDoCot();
            panelChart.Controls.Add(chart);
            if (rdThang.Checked == true)
            {
                List<DoanhSoDTO> doanhSoDTOs = thongKeDoanhThuService.doanhSoTheoThangService();
                bieuDoThongKeDangDuong(doanhSoDTOs, "Tháng", chart);
            }
            else if (rdQuy.Checked == true)
            {
                List<DoanhSoDTO> doanhSoDTOs = thongKeDoanhThuService.doanhSoTheoQuyService();
                bieuDoThongKeDangDuong(doanhSoDTOs, "Quý", chart);
            }
            else
            {
                List<DoanhSoDTO> doanhSoDTOs = thongKeDoanhThuService.doanhSoTheoNamService();
                bieuDoThongKeDangDuong(doanhSoDTOs, "Năm", chart);
            }
        }
    }
}
