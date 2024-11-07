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

namespace GUI
{
    public partial class FormDiemThiDua : Form
    {
        public FormDiemThiDua()
        {
            InitializeComponent();
            InitializeBarChart();
        }

        private void InitializeBarChart()
        {
            // Example data for monthly scores
            List<double> monthlyScores = new List<double> { 75, 88, 92, 68, 85, 94, 79, 88, 90, 84, 76, 91 };
            List<string> monthLabels = new List<string>
        {
            "Jan", "Feb", "Mar", "Apr", "May", "Jun",
            "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
        };

            // Configure the bar series
            var barSeries = new LiveCharts.Wpf.ColumnSeries
            {
                Title = "Scores",
                Values = new ChartValues<double>(monthlyScores),
                DataLabels = true, // Show score values on top of each bar
                LabelPoint = point => point.Y.ToString() // Format data labels
            };

            // Add the series to the chart
            cartesianChart.Series = new SeriesCollection { barSeries };

            // Set the labels for the X-axis (months)
            cartesianChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = monthLabels
            });

            // Set the Y-axis properties
            cartesianChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Score",
                MinValue = 0, // Optional: Set the minimum value
                MaxValue = 100 // Optional: Set the maximum value, assuming scores are out of 100
            });

            // Additional chart properties (optional)
            cartesianChart.LegendLocation = LegendLocation.Right;
        }
    }
}
