using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI
{
    public partial class FormXemTienLuong : Form
    {
        QLTLDataContext qltl = new QLTLDataContext();
        LayDuLieuLuong layDuLieuLuong = new LayDuLieuLuong();
        String username=String.Empty;
        public FormXemTienLuong()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
           
            dateTimeThang.Format = DateTimePickerFormat.Custom;
            dateTimeThang.CustomFormat = "yyyy-MM";

            LoadGiangVien();
        }

        private void LoadGiangVien()
        {

            //var giangViens = qltl.GIANGVIENs.ToList();

            //// Gán danh sách giảng viên vào combobox
            //cbbGV.DataSource = giangViens;
            //cbbGV.DisplayMember = "TENGIANGVIEN";
            //cbbGV.ValueMember = "MAGIANGVIEN";
            username = Session.Username;
            GIANGVIEN gv = qltl.GIANGVIENs.Where(t => t.MAGIANGVIEN == username).FirstOrDefault();
            txtTenGV.Text = gv.TENGIANGVIEN + " - " + gv.MAGIANGVIEN;

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
        }

        

        private void ClearAllFields()
        {
            txtTongTietDay.Text = "";
            txtTienLuong.Text = "";
            txtHeSoLuong.Text = "";
            txtHeSoChucVu.Text = "";
            txtPhuCapDungLop.Text = "";
            txtPhuCapThamNien.Text = "";
            txtLuongCung.Text = "";
            txtKinhPhiBHXH.Text = "";
            txtDiemThiDua.Text = "";
            txtTroCapThem.Text = "";
            txtSoTietVuotLT.Text = "";
            txtSoTietVuotTH.Text = "";
            txtTienTietVuot.Text = "";
            gridLuong.DataSource = null;
        }

        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_XuatExcel_Click_1(object sender, EventArgs e)
        {
            string fileName = "Phieuluong";
            string maGV = username;
            var luong = qltl.TIENLUONGTHEOTHANGs.FirstOrDefault(t => t.MAGIANGVIEN == maGV && t.THANGLUONG.Month == dateTimeThang.Value.Month);
            if (luong != null)
            {
                var exporter = new ExcelExport();
                exporter.ExportTienLuongTheoThang(luong, ref fileName);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin lương tháng này cho giảng viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {


            string maGV = username;
            DateTime thangLuong = dateTimeThang.Value;

            var giangVien = qltl.GIANGVIENs.FirstOrDefault(gv => gv.MAGIANGVIEN == maGV);
            if (giangVien == null)
            {
                MessageBox.Show("Không tìm thấy thông tin giảng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var luongInfo = qltl.TIENLUONGTHEOTHANGs
                .Where(t => t.MAGIANGVIEN == maGV &&
                           t.THANGLUONG.Year == thangLuong.Year &&
                           t.THANGLUONG.Month == thangLuong.Month)
                .Select(t => new {
                    t.MAGIANGVIEN,
                    t.THANGLUONG,
                    t.TONGTIETDAY,
                    t.TIENLUONG
                })
                .FirstOrDefault();

            if (luongInfo != null)
            {
                // Tính toán các thành phần lương
                float heSoLuong = (float)(giangVien.HESOLUONG ?? 0);
                float heSoChucVu = layDuLieuLuong.LayHeSoChucVu(giangVien.CHUCVU);
                float mucLuongCoBan = 2340000; // Mức lương cơ bản
                float phuCapDungLop = 0.25f;   // 25%
                float phuCapThamNien = layDuLieuLuong.LayPhuCapThamNien(giangVien.THAMNIENCONGTAC ?? 0);

                float luongCung = (heSoLuong + heSoChucVu) * mucLuongCoBan * (1 + phuCapDungLop + phuCapThamNien);
                float kinhPhiBHXH = (heSoLuong + heSoChucVu) * mucLuongCoBan * (1 + phuCapThamNien) * 0.105f;

                decimal mucTroCapChucVu = layDuLieuLuong.LayMucTroCapChucVu(giangVien.CHUCVU);
                int diemThiDua = layDuLieuLuong.LayDiemThiDuaTheoThang(maGV, thangLuong);
                decimal tyLeTroCap = (diemThiDua >= 8) ? 1 : (diemThiDua >= 6) ? 0.7m : (diemThiDua >= 4) ? 0.5m : 0.3m;
                decimal troCapThem = mucTroCapChucVu * tyLeTroCap;

                // Hiển thị thông tin lương
                txtTongTietDay.Text = luongInfo.TONGTIETDAY.ToString();
                txtTienLuong.Text = luongInfo.TIENLUONG?.ToString("#,##0") ?? "0";
                txtHeSoLuong.Text = heSoLuong.ToString("F2");
                txtHeSoChucVu.Text = heSoChucVu.ToString("F2");
                txtPhuCapDungLop.Text = (phuCapDungLop * 100).ToString("F0") + "%";
                txtPhuCapThamNien.Text = (phuCapThamNien * 100).ToString("F0") + "%";
                txtLuongCung.Text = luongCung.ToString("#,##0");
                txtKinhPhiBHXH.Text = kinhPhiBHXH.ToString("#,##0");
                txtDiemThiDua.Text = diemThiDua.ToString();
                txtTroCapThem.Text = troCapThem.ToString("#,##0");

                // Lấy thông tin tiết vượt
                var tietVuotInfo = qltl.TIENTIETVUOTs
                    .Where(tv => tv.MAGIANGVIEN == maGV &&
                                tv.MANAMHOC == $"NH{thangLuong.Year}")
                    .Select(tv => new { tv.SOTIETVUOTLYTHUYET, tv.SOTIETVUOTTHUCHANH, tv.SOTIEN })
                    .FirstOrDefault();

                if (tietVuotInfo != null)
                {
                    txtSoTietVuotLT.Text = tietVuotInfo.SOTIETVUOTLYTHUYET.ToString();
                    txtSoTietVuotTH.Text = tietVuotInfo.SOTIETVUOTTHUCHANH.ToString();
                    txtTienTietVuot.Text = tietVuotInfo.SOTIEN?.ToString("#,##0") ?? "0";
                }
                else
                {
                    txtSoTietVuotLT.Text = "0";
                    txtSoTietVuotTH.Text = "0";
                    txtTienTietVuot.Text = "0";
                }

                // Hiển thị lên DataGridView
                gridLuong.DataSource = new List<object> { luongInfo };
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin lương cho giảng viên trong tháng này!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearAllFields();
            }
        }
    }
}