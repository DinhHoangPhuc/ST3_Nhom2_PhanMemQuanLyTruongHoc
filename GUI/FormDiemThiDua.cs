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
            InitializeDataGridView();
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

        private void InitializeDataGridView()
        {
            dgvViPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            DataGridViewColumn maViPhamColumn = new DataGridViewTextBoxColumn
            {
                Name = "MaViPham",
                HeaderText = "Mã Vi Phạm",
                DataPropertyName = "MaViPham",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewColumn tenViPhamColumn = new DataGridViewTextBoxColumn
            {
                Name = "TenViPham",
                HeaderText = "Tên Vi Phạm",
                DataPropertyName = "TenViPham",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewColumn ghiChuColumn = new DataGridViewTextBoxColumn
            {
                Name = "GhiChu",
                HeaderText = "Ghi chú",
                DataPropertyName = "GhiChu",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewColumn diemTruColumn = new DataGridViewTextBoxColumn
            {
                Name = "DiemTru",
                HeaderText = "Điểm Trừ",
                DataPropertyName = "DiemTru",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewColumn thangViPhamColumn = new DataGridViewTextBoxColumn
            {
                Name = "ThangViPham",
                HeaderText = "Tháng Vi Phạm",
                DataPropertyName = "ThangViPham",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewColumn maGVColumn = new DataGridViewTextBoxColumn
            {
                Name = "MaGiangVien",
                HeaderText = "Mã Giảng Viên",
                DataPropertyName = "MaGiangVien",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewColumn giangVienColumn = new DataGridViewTextBoxColumn
            {
                Name = "GiangVien",
                HeaderText = "Giảng Viên",
                DataPropertyName = "GIANGVIEN.TENGIANGVIEN",
                Visible = false
            };

            dgvViPham.Columns.Add(maViPhamColumn);
            dgvViPham.Columns.Add(tenViPhamColumn);
            dgvViPham.Columns.Add(ghiChuColumn);
            dgvViPham.Columns.Add(diemTruColumn);
            dgvViPham.Columns.Add(thangViPhamColumn);
            dgvViPham.Columns.Add(maGVColumn);
            dgvViPham.Columns.Add(giangVienColumn);
        }

        private void LoadViPhamDatagridview(string maGV, DateTime ngay)
        {
            dgvViPham.DataSource = viPham.GetViPhamByMonth(maGV, ngay);
        }

    }
}
