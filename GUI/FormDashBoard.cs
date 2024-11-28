using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
using LiveCharts;
using LiveCharts.Wpf;

namespace GUI
{
    public partial class FormDashBoard : Form
    {
        private DiemThiDua diemThiDua;

        public FormDashBoard()
        {
            diemThiDua = new DiemThiDua();
            InitializeComponent();
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            LoadDataToRaceChart();
            LoadDataToPieChart();
            LoadThamNienCOngTacBarChart();
        }

        private void LoadDataToRaceChart()
        {
            var dIEMTHIDUATHEOTHANGs = diemThiDua.GetAllDiemThiDuaByThangAndNam(DateTime.Now.Month, DateTime.Now.Year);

            var data = dIEMTHIDUATHEOTHANGs
                .Select(d => new
                {
                    GiangVien = d.GIANGVIEN.TENGIANGVIEN,
                    Diem = d.DIEMTHIDUA.HasValue ? Math.Max(0, Math.Min(10, d.DIEMTHIDUA.Value)) : 0
                })
                .ToList();

            var seriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Điểm thi đua",
                    Values = new ChartValues<double>(data.Select(d => (double)d.Diem))
                }
            };

            cartesianChartXepHangThiDua.Series = seriesCollection;
            cartesianChartXepHangThiDua.AxisX.Add(new Axis
            {
                Title = "Giảng Viên",
                Labels = data.Select(d => d.GiangVien).ToArray()
            });
            cartesianChartXepHangThiDua.AxisY.Add(new Axis
            {
                Title = "Điểm thi đua",
                MinValue = 0,
                MaxValue = 10
            });
        }

        private void LoadDataToPieChart()
        {
            var giangViens = diemThiDua.GetAllGiangVien();
            var data = giangViens
                .GroupBy(gv => gv.CHUCVU1.TENCHUCVU)
                .Select(g => new
                {
                    TenChucVu = g.Key,
                    Count = g.Count()
                })
                .ToList();

            var seriesCollection = new SeriesCollection();

            foreach (var item in data)
            {
                seriesCollection.Add(new PieSeries
                {
                    Title = item.TenChucVu,
                    Values = new ChartValues<int> { item.Count },
                    DataLabels = true,
                    LabelPoint = point => $"{point.Y} người"
                });
            }

            pieChart1.Series = seriesCollection;
            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        private void LoadThamNienCOngTacBarChart()
        {
            var giangViens = diemThiDua.GetAllGiangVien();
            var data = giangViens.Select(gv => new
            {
                TenGiangVien = gv.TENGIANGVIEN,
                ThamNien = gv.THAMNIENCONGTAC.HasValue ? gv.THAMNIENCONGTAC.Value : 0
            }).ToList();

            var seriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Thâm niên công tác",
                    Values = new ChartValues<double>(data.Select(d => (double)d.ThamNien))
                }
            };

            cartesianChartThamNienCongtac.Series = seriesCollection;
            cartesianChartThamNienCongtac.AxisX.Add(new Axis
            {
                Title = "Giảng Viên",
                Labels = data.Select(d => d.TenGiangVien).ToArray()
            });
            cartesianChartThamNienCongtac.AxisY.Add(new Axis
            {
                Title = "Thâm niên công tác",
                MinValue = 0
            });
        }
    }
}
