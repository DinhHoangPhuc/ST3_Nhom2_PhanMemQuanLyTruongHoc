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
    public partial class FormPhanQuyen : Form
    {
        private BUS.PhanQuyenNguoiDung phanQuyenNguoiDung;

        public FormPhanQuyen()
        {
            InitializeComponent();

            phanQuyenNguoiDung = new BUS.PhanQuyenNguoiDung();

            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvManHinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadComboNhomNguoiDung();
            LoadDanhSachNguoiDung();
            LoadNguoiDung_NhomNguoiDung();
            LoadManHinh();

        }

        private void LoadComboNhomNguoiDung()
        {
            cbNhomNguoiDung.DataSource = phanQuyenNguoiDung.GetNHOMNGUOIDUNGs();
            cbNhomNguoiDung.DisplayMember = "TENNHOM";
            cbNhomNguoiDung.ValueMember = "MANHOM";
        }

        private void LoadDanhSachNguoiDung()
        {
            dgvNguoiDung.DataSource = phanQuyenNguoiDung.GetAllNguoiDung();
        }

        private void LoadNguoiDung_NhomNguoiDung()
        {
            if (cbNhomNguoiDung.SelectedValue != null)
            {
                string maNhom = cbNhomNguoiDung.SelectedValue.ToString();
                dgvND_NND.DataSource = phanQuyenNguoiDung.GetNGUOIDUNG_NHOMNGUOIDUNGsByMANHOM(maNhom);
            }
        }

        private void InitDgvPhanQuyen()
        {
            DataGridViewColumn maNhomND = new DataGridViewTextBoxColumn
            {
                Name = "MANHOMNGUOIDUNG",
                HeaderText = "Mã nhóm người dùng",
                DataPropertyName = "MANHOMNGUOIDUNG",
                ReadOnly = true
            };

            DataGridViewColumn maManHinh = new DataGridViewTextBoxColumn
            {
                Name = "MAMANHINH",
                HeaderText = "Mã màn hình",
                DataPropertyName = "MAMANHINH",
                ReadOnly = true
            };

            DataGridViewColumn coQuyen = new DataGridViewCheckBoxColumn
            {
                Name = "COQUYEN",
                HeaderText = "Có quyền",
                DataPropertyName = "COQUYEN",
                TrueValue = true,
                FalseValue = false,
                ReadOnly = false
            };

            dgvPhanQuyen.Columns.Clear();

            dgvPhanQuyen.Columns.Add(maNhomND);
            dgvPhanQuyen.Columns.Add(maManHinh);
            dgvPhanQuyen.Columns.Add(coQuyen);
        }

        private void LoadManHinh()
        {
            dgvManHinh.DataSource = phanQuyenNguoiDung.GetAllManHinh();
        }

        private void cbNhomNguoiDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNhom = cbNhomNguoiDung.SelectedValue.ToString();
            dgvND_NND.DataSource = phanQuyenNguoiDung.GetNGUOIDUNG_NHOMNGUOIDUNGsByMANHOM(maNhom);
            InitDgvPhanQuyen();

            LoadPhanQuyen(maNhom);
        }

        private void btnChuyenND_Click(object sender, EventArgs e)
        {
            string maNguoiDung = dgvNguoiDung.CurrentRow.Cells["TENDANGNHAP"].Value.ToString();
            string maNhom = cbNhomNguoiDung.SelectedValue.ToString();

            if (phanQuyenNguoiDung.AddNguoiDung_NhomNguoiDung(maNguoiDung, maNhom))
            {
                MessageBox.Show("Phân quyền người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNguoiDung_NhomNguoiDung();
            }
            else
            {
                MessageBox.Show("Phân quyền người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUndoND_Click(object sender, EventArgs e)
        {
            string maNguoiDung = dgvND_NND.CurrentRow.Cells["TENDANGNHAP"].Value.ToString();
            string maNhom = dgvND_NND.CurrentRow.Cells["MANHOM"].Value.ToString();

            if (phanQuyenNguoiDung.DeleteNguoiDung_NhomNguoiDung(maNguoiDung, maNhom))
            {
                MessageBox.Show("Hủy phân quyền người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNguoiDung_NhomNguoiDung();
            }
            else
            {
                MessageBox.Show("Hủy phân quyền người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPhanQuyen(string maNhom)
        {
            dgvPhanQuyen.DataSource = phanQuyenNguoiDung.GetPHANQUYENsByMANHOM(maNhom);
        }

        private void btnChuyenPhanQuyen_Click(object sender, EventArgs e)
        {
            string maManHinh = dgvManHinh.CurrentRow.Cells["MAMANHINH"].Value.ToString();
            string maNhom = cbNhomNguoiDung.SelectedValue.ToString();

            if (phanQuyenNguoiDung.InsertPhanQuyen(maNhom, maManHinh, true))
            {
                MessageBox.Show("Cập nhật phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhanQuyen(maNhom);
            }
            else
            {
                MessageBox.Show("Cập nhật phân quyền thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuuND_Click(object sender, EventArgs e)
        {
            int count = dgvND_NND.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                DataGridViewRow row = dgvND_NND.Rows[i];
                if (row.DataBoundItem is BUS.NGUOIDUNG_NHOMNGUOIDUNG nguoiDung)
                {
                    string maNhom = row.Cells["MANHOM"].Value.ToString();
                    string maNguoiDung = row.Cells["TENDANGNHAP"].Value.ToString();
                    string ghiChu = row.Cells["GHICHU"].Value.ToString();

                    bool updateResult = phanQuyenNguoiDung.UpdateNguoiDung_NhomNguoiDung(maNguoiDung, maNhom, ghiChu);

                    if (!phanQuyenNguoiDung.UpdateNguoiDung_NhomNguoiDung(maNguoiDung, maNhom, ghiChu))
                    {
                        MessageBox.Show("Cập nhật người dùng - nhóm người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            MessageBox.Show("Cập nhật người dùng - nhóm người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLuuPhanQuyen_Click(object sender, EventArgs e)
        {
            int count = dgvPhanQuyen.Rows.Count;

            for (int i = 0; i < count; i++)
            {
                DataGridViewRow row = dgvPhanQuyen.Rows[i];
                if (row.DataBoundItem is BUS.PHANQUYEN phanQuyen)
                {
                    string maNhom = row.Cells["MANHOMNGUOIDUNG"].Value.ToString();
                    string maManHinh = row.Cells["MAMANHINH"].Value.ToString();
                    bool coQuyen = (bool)row.Cells["COQUYEN"].Value;

                    bool updateResult = phanQuyenNguoiDung.UpdatePhanQuyen(maNhom, maManHinh, coQuyen);

                    if (!updateResult)
                    {
                        MessageBox.Show("Cập nhật phân quyền thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            MessageBox.Show("Cập nhật phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUndoPhanQuyen_Click(object sender, EventArgs e)
        {
            string maNhom = dgvPhanQuyen.CurrentRow.Cells["MANHOMNGUOIDUNG"].Value.ToString();
            string maManHinh = dgvPhanQuyen.CurrentRow.Cells["MAMANHINH"].Value.ToString();

            if (phanQuyenNguoiDung.DeletePhanQuyen(maNhom, maManHinh))
            {
                MessageBox.Show("Hủy phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhanQuyen(maNhom);
            }
            else
            {
                MessageBox.Show("Hủy phân quyền thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
