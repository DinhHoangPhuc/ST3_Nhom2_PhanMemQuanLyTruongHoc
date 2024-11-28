
namespace GUI
{
    partial class FormDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cartesianChartXepHangThiDua = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.cartesianChartThamNienCongtac = new LiveCharts.WinForms.CartesianChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cartesianChartXepHangThiDua, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cartesianChartXepHangThiDua
            // 
            this.cartesianChartXepHangThiDua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChartXepHangThiDua.Location = new System.Drawing.Point(3, 3);
            this.cartesianChartXepHangThiDua.Name = "cartesianChartXepHangThiDua";
            this.cartesianChartXepHangThiDua.Size = new System.Drawing.Size(1061, 271);
            this.cartesianChartXepHangThiDua.TabIndex = 0;
            this.cartesianChartXepHangThiDua.Text = "cartesianChart1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.pieChart1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cartesianChartThamNienCongtac, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 280);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1061, 271);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(3, 3);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(524, 265);
            this.pieChart1.TabIndex = 4;
            this.pieChart1.Text = "pieChart1";
            // 
            // cartesianChartThamNienCongtac
            // 
            this.cartesianChartThamNienCongtac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChartThamNienCongtac.Location = new System.Drawing.Point(533, 3);
            this.cartesianChartThamNienCongtac.Name = "cartesianChartThamNienCongtac";
            this.cartesianChartThamNienCongtac.Size = new System.Drawing.Size(525, 265);
            this.cartesianChartThamNienCongtac.TabIndex = 5;
            this.cartesianChartThamNienCongtac.Text = "cartesianChart1";
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashBoard";
            this.Text = "FormDashBoard";
            this.Load += new System.EventHandler(this.FormDashBoard_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private LiveCharts.WinForms.CartesianChart cartesianChartXepHangThiDua;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private LiveCharts.WinForms.PieChart pieChart1;
        private LiveCharts.WinForms.CartesianChart cartesianChartThamNienCongtac;
    }
}