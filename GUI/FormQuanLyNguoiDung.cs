using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormQuanLyNguoiDung : Form
    {
        private BUS.QuanLyNguoiDung quanLyNguoiDung;
        private ProgressBar progressBar;

        public FormQuanLyNguoiDung()
        {
            quanLyNguoiDung = new BUS.QuanLyNguoiDung();

            InitializeComponent();
            SetUpControls();
            InitializeDataGridView();
            LoadData();
        }

        private void SetUpControls()
        {
            // Initialize ProgressBar
            progressBar = new ProgressBar
            {
                Location = new Point(20, Height - 40),
                Width = Width - 40,
                Height = 20,
                Minimum = 0,
                Maximum = 100,
                Step = 1,
                Visible = false
            };

            // Add ProgressBar to the form
            Controls.Add(progressBar);
            progressBar.BringToFront();
        }

        private void InitializeDataGridView()
        {
            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguoiDung.AllowUserToAddRows = true;

            DataGridViewCheckBoxColumn hoatDongColumn = new DataGridViewCheckBoxColumn
            {
                Name = "HoatDong",
                HeaderText = "Hoạt Động",
                DataPropertyName = "HoatDong",
                TrueValue = true,
                FalseValue = false,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewColumn tenDangNhapColumn = new DataGridViewTextBoxColumn
            {
                Name = "TenDangNhap",
                HeaderText = "Tên Đăng Nhập",
                DataPropertyName = "TenDangNhap",
                ReadOnly = true,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            DataGridViewColumn matKhauColumn = new DataGridViewTextBoxColumn
            {
                Name = "MatKhau",
                HeaderText = "Mật Khẩu",
                DataPropertyName = "MatKhau",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            };

            dgvNguoiDung.Columns.Add(tenDangNhapColumn);
            dgvNguoiDung.Columns.Add(matKhauColumn);
            dgvNguoiDung.Columns.Add(hoatDongColumn);

            dgvNguoiDung.CellValueChanged += DgvNguoiDung_CellValueChanged;
            dgvNguoiDung.UserAddedRow += DgvNguoiDung_UserAddedRow;
        }

        private void LoadData()
        {
            List<BUS.NGUOIDUNG> listNguoiDung = quanLyNguoiDung.GetListNguoiDung();
            dgvNguoiDung.DataSource = listNguoiDung;
        }

        private void DgvNguoiDung_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvNguoiDung.Rows[e.RowIndex];
                var nguoiDung = row.DataBoundItem as BUS.NGUOIDUNG;
                if (nguoiDung != null)
                {
                    quanLyNguoiDung.UpdateNguoiDung(nguoiDung);
                }
            }
        }

        private void DgvNguoiDung_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            var row = e.Row;
            var nguoiDung = row.DataBoundItem as BUS.NGUOIDUNG;
            if (nguoiDung != null)
            {
                quanLyNguoiDung.AddNguoiDung(nguoiDung);
            }
        }

        private async void btnLuu_Click(object sender, EventArgs e)
        {
            // Show ProgressBar
            progressBar.Visible = true;
            progressBar.Value = 0;
            progressBar.Location = new Point(0, this.ClientSize.Height - progressBar.Height);

            // Get the total number of rows to save
            int totalRows = dgvNguoiDung.Rows.Count;
            if (totalRows == 0)
            {
                progressBar.Visible = false;
                return;
            }

            // Save all changes to the database
            for (int i = 0; i < totalRows; i++)
            {
                DataGridViewRow row = dgvNguoiDung.Rows[i];
                if (row.DataBoundItem is BUS.NGUOIDUNG nguoiDung)
                {
                    quanLyNguoiDung.UpdateNguoiDung(nguoiDung);
                }

                // Update ProgressBar
                progressBar.Value = (i + 1) * 100 / totalRows;
                await Task.Delay(50); // Simulate some delay for demonstration purposes
            }

            // Hide ProgressBar
            progressBar.Visible = false;


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<BUS.NGUOIDUNG> listNguoiDung = quanLyNguoiDung.GetListNguoiDungByUsername(txtTimTheoUsername.Text);
            if (listNguoiDung.Count > 0)
                dgvNguoiDung.DataSource = listNguoiDung;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormThemMoiNguoiDung formThemMoiNguoiDung = new FormThemMoiNguoiDung();
            formThemMoiNguoiDung.ShowDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvNguoiDung.DataSource = quanLyNguoiDung.GetListNguoiDung();
        }
    }
}
