using BUS;
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
    public partial class FormViPham : Form
    {
        QLTLDataContext qlth = new QLTLDataContext();
        private readonly GiangVien giangvien;
        private QL_ViPham vipham = new QL_ViPham();

        public FormViPham()
        {
            InitializeComponent();
            LoadViPham();
            LoadGV_cbb();
        }

        private void FormViPham_Load(object sender, EventArgs e)
        {

        }
        public void LoadViPham()
        {

            dtgvViPham.DataSource = vipham.GetViPham();
            HideColumns();
        }
        private void HideColumns()
        {
            for (int i = 6; i < dtgvViPham.Columns.Count; i++)
            {
                dtgvViPham.Columns[i].Visible = false;
            }
        }

        public void LoadGV_cbb()
        {

            var giangVienList = vipham.GetGiangVien();

            Cbb_GiangVien.DataSource = giangVienList;
            Cbb_GiangVien.DisplayMember = "TENGIANGVIEN";
            Cbb_GiangVien.ValueMember = "MAGIANGVIEN";
            Cbb_GiangVien.Refresh();
        }

        private void dtgvViPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgvViPham.Rows[e.RowIndex];
                txt_MaViPham.Text = row.Cells[0].Value.ToString();
                txt_TenViPham.Text = row.Cells[1].Value.ToString();
                txt_GhiChu.Text = row.Cells[2].Value.ToString();
                numeric_DiemTru.Value = Convert.ToDecimal(row.Cells[3].Value);
                datetimpicker_NgayVP.Value = Convert.ToDateTime(row.Cells[4].Value);
                Cbb_GiangVien.SelectedValue = row.Cells[5].Value.ToString();
                Cbb_GiangVien.Refresh();
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenViPham = txt_TenViPham.Text;
            string ghiChu = txt_GhiChu.Text;
            int diemTru = (int)numeric_DiemTru.Value;
            DateTime thangViPham = datetimpicker_NgayVP.Value;
            string maGiangVien = Cbb_GiangVien.SelectedValue?.ToString();

            // Gọi phương thức AddViPham với callback để thông báo kết quả
            if (maGiangVien != null)
            {
                vipham.AddViPham(tenViPham, ghiChu, diemTru, thangViPham, maGiangVien, ShowMessage);
            }
            else
            {
                ShowMessage("Vui lòng chọn giảng viên.");
            }
            LoadViPham();
        }

        private void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string maViPham = txt_MaViPham.Text;
            string tenViPham = txt_TenViPham.Text;
            string ghiChu = txt_GhiChu.Text;
            int diemTru = (int)numeric_DiemTru.Value;
            DateTime thangViPham = datetimpicker_NgayVP.Value;
            string maGiangVien = Cbb_GiangVien.SelectedValue?.ToString();

            if (maGiangVien != null)
            {
                vipham.EditViPham(maViPham, tenViPham, ghiChu, diemTru, thangViPham, maGiangVien, ShowMessage);
            }
            else
            {
                ShowMessage("Vui lòng chọn giảng viên.");
            }
            LoadViPham();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string maViPham = txt_MaViPham.Text;

            vipham.DeleteViPham(maViPham, ShowMessage);
            LoadViPham();
        }
    }
}
