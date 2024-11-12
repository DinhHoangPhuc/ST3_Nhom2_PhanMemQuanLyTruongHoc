using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using LiveCharts;
using LiveCharts.WinForms;
using BUS;

namespace GUI
{
    public partial class FormDiemThiDua : Form
    {
        private DiemThiDua diemThiDua;
        private ViPham viPham;
        private string username;
        public FormDiemThiDua()
        {
            diemThiDua = new DiemThiDua();
            viPham = new ViPham();
            username = Session.Username;

            InitializeComponent();
            InitializeBarChart();
            LoadViPhamDatagridview(username, DateTime.Now);
        }

        private void InitializeBarChart()
        {
            //List<double> monthlyScores = new List<double> { 75, 88, 92, 68, 85, 94, 79, 88, 90, 84, 76, 91 };
            List<double> monthlyScores = diemThiDua.GetListDiemThiDuaByGiangVien(username, DateTime.Now.Year);
            List<string> monthLabels = new List<string>
        {
            "Jan", "Feb", "Mar", "Apr", "May", "Jun",
            "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

            var barSeries = new LiveCharts.Wpf.ColumnSeries
            {
                Title = "Điểm thi đua",
                Values = new ChartValues<double>(monthlyScores),
                DataLabels = true, 
                LabelPoint = point => point.Y.ToString() 
            };

            cartesianChart.Series = new SeriesCollection { barSeries };

            cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Tháng",
                Labels = monthLabels
            });

            cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Điểm thi đua",
                MinValue = 0, 
                MaxValue = 10 
            });

            cartesianChart.LegendLocation = LegendLocation.Right;
        }

        private void LoadViPhamDatagridview(string maGV, DateTime ngay)
        {
            dgvViPham.DataSource = viPham.GetViPhamByMonth(maGV, ngay);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadViPhamDatagridview(username, dateTimePicker.Value);
        }
    }
}
