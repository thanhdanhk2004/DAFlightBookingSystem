using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataTransferObject.DTO;
using FlightBookingSytem_BLL.Service;
using LiveCharts;
using LiveCharts.WinForms;

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

        public CartesianChart taoBieuDoCot()
        {
            CartesianChart chart = new CartesianChart();
            chart.Width = 900;
            chart.Height = 350;
            Dock = DockStyle.Fill;
            chart.Background = System.Windows.Media.Brushes.White;
            return chart;   
        }

        public PieChart taoBieuDoTron()
        {
            PieChart chart = new PieChart();
            chart.Width = 300;
            chart.Height = 300;
            return chart;
        }
        public void bieuDoThongKeDangCot(List<DoanhSoDTO> list, string thoiGian, CartesianChart chart)
        {
            chart.Series = new SeriesCollection
            {
                new LiveCharts.Wpf.ColumnSeries // Bieu do cot
                {
                    Title = "Doanh thu",
                    Values = new ChartValues<float>(list.Select(ds => ds.SoTien))
                }
            };

            chart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = thoiGian,
                Labels = new List<string>(list.Select(ds => ds.ThoiGian.ToString()))
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

        
    }
}
