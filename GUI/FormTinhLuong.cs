using BUS;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace GUI
{
    public partial class FormTinhLuong : Form
    {
        private readonly TinhLuong tinhLuong;

        public FormTinhLuong()
        {
            InitializeComponent();
            tinhLuong = new TinhLuong();
            LoadDanhSachGiangVien();
            Load_LuongTheoThang();
            dateTimeThangLuong.Format = DateTimePickerFormat.Custom;
            dateTimeThangLuong.CustomFormat = "yyyy-MM";
        }
        void LoadDanhSachGiangVien()
        {
            var gvlist = tinhLuong.GetDanhSachGiangVien(); // Sử dụng đối tượng tinhLuong
            if (gvlist != null && gvlist.Count > 0)
            {
                cbxgv.DataSource = gvlist;
                cbxgv.DisplayMember = "TENGIANGVIEN";
                cbxgv.ValueMember = "MAGIANGVIEN";
            }
        }

        void Load_TienTietVuot()
        {
            // Lấy mã giảng viên từ ComboBox
            var selectedGV = (GIANGVIEN)cbxgv.SelectedItem;
            if (selectedGV != null)
            {
                var tblTietVuots = tinhLuong.GetTienTietVuotByMaGiangVien(selectedGV.MAGIANGVIEN);

                // Kiểm tra dữ liệu có hợp lệ không trước khi gán vào DataGridView
                if (tblTietVuots != null && tblTietVuots.Count > 0)
                {
                    // Gán DataSource cho DataGridView
                    dtgvTietvuot.DataSource = tblTietVuots;

                    // Thiết lập tiêu đề cho các cột
                    dtgvTietvuot.Columns["MAGIANGVIEN"].HeaderText = "Mã Giảng Viên";
                    dtgvTietvuot.Columns["SOTIETVUOTLYTHUYET"].HeaderText = "Số Tiết Vượt Lý Thuyết";
                    dtgvTietvuot.Columns["SOTIETVUOTTHUCHANH"].HeaderText = "Số Tiết Vượt Thực Hành";
                    dtgvTietvuot.Columns["SOTIEN"].HeaderText = "Số Tiền";
                    dtgvTietvuot.Columns["MANAMHOC"].HeaderText = "Năm Học";

                    // Làm mới DataGridView
                    dtgvTietvuot.Refresh();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        void Load_LuongTheoThang()
        {
            var selectedGV = (GIANGVIEN)cbxgv.SelectedItem;
            if (selectedGV != null)
            {
                var luongList = tinhLuong.GetLuongTheoThangByMaGiangVien(selectedGV.MAGIANGVIEN);
                if (luongList != null && luongList.Count > 0)
                {
                    dtgvLuong.DataSource = luongList;

                    // Kiểm tra và thiết lập DataPropertyName cho cột
                    if (dtgvLuong.Columns["MAGIANGVIEN"] != null)
                    {
                        dtgvLuong.Columns["MAGIANGVIEN"].HeaderText = "Mã Giảng Viên";
                        dtgvLuong.Columns["THANGLUONG"].HeaderText = "Tháng Lương";
                        dtgvLuong.Columns["TONGTIETDAY"].HeaderText = "Tổng Tiết Dạy";
                        dtgvLuong.Columns["TIENLUONG"].HeaderText = "Tiền Lương";
                    }
                    dtgvLuong.Refresh();
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void dateTimeThangLuong_ValueChanged(object sender, EventArgs e)
        {
            var selectedGV = (GIANGVIEN)cbxgv.SelectedItem;
            var selectDate = dateTimeThangLuong.Value;
            int selectedYear = selectDate.Year;
            if (selectedGV != null)
            {
                // Lấy điểm thi đua của giảng viên cho tháng chọn
                int diemThiDua = tinhLuong.LayDiemThiDua(selectedGV.MAGIANGVIEN, selectDate);
                txt_diemthidua.Text = diemThiDua.ToString();
                // Lấy thông tin tiết dạy lý thuyết và thực hành của giảng viên

                var maNamHoc = tinhLuong.LayMaNamHoc(selectedYear);
                var thongtinlt = tinhLuong.LayTietLyThuyet(selectedGV.MAGIANGVIEN, maNamHoc);
                var thongtinth = tinhLuong.LayTietThucHanh(selectedGV.MAGIANGVIEN, maNamHoc);
                txt_lt.Text = thongtinlt.ToString();
                txt_th.Text = thongtinth.ToString();
            }
        }

        private void cbxgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_TienTietVuot();
            Load_LuongTheoThang();
        }

        private void btn_tinhluong_Click(object sender, EventArgs e)
        {
            var selectedGV = (GIANGVIEN)cbxgv.SelectedItem;
            var selectThang = dateTimeThangLuong.Value;

            if (selectedGV != null)
            {
                var maNamHoc = tinhLuong.GetNamHoc(selectThang.Year);

                if (maNamHoc == null)
                {
                    MessageBox.Show("Năm học không hợp lệ. Vui lòng chọn năm bắt đầu đúng với dữ liệu hiện có.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Lấy số tiết lý thuyết và thực hành của giảng viên
                int soTietLyThuyet = tinhLuong.LayTietLyThuyet(selectedGV.MAGIANGVIEN, maNamHoc);
                int soTietThucHanh = tinhLuong.LayTietThucHanh(selectedGV.MAGIANGVIEN, maNamHoc);

                // Tính số tiết vượt chuẩn
                int soTietVuotLyThuyet = Math.Max(0, soTietLyThuyet - 100);
                float soTietVuotThucHanh = Math.Max(0, soTietThucHanh - 200);

                // Lấy đơn giá tiết vượt
                float donGiaTietVuotLyThuyet = tinhLuong.LayDonGiaTietVuot(selectedGV.MAGIANGVIEN);
                float donGiaTietVuotThucHanh = donGiaTietVuotLyThuyet * 0.75f;

                // Tính tiền tiết vượt
                float tienTietVuotLyThuyet = soTietVuotLyThuyet * donGiaTietVuotLyThuyet;
                float tienTietVuotThucHanh = soTietVuotThucHanh * donGiaTietVuotThucHanh;
                float tongTienTietVuot = tienTietVuotLyThuyet + tienTietVuotThucHanh;

                // Tính lương cứng
                float heSoLuong = (float)(selectedGV.HESOLUONG ?? 0);
                float heSoChucVu = tinhLuong.LayHeSoChucVu(selectedGV.CHUCVU);
                float mucLuongCoBan = 2340000; // Mức lương cơ bản
                float phuCapDungLop = 0.25f;   // 25%
                float phuCapThamNien = tinhLuong.TinhPhuCapThamNien(selectedGV.THAMNIENCONGTAC);

                float luongCung = tinhLuong.TinhLuongCung(heSoLuong, heSoChucVu, mucLuongCoBan, phuCapDungLop, phuCapThamNien);

                // Tính trợ cấp thêm
                decimal mucTroCapChucVu = tinhLuong.LayMucTroCapChucVu(selectedGV.CHUCVU);

                // Kiểm tra nếu chưa nhập điểm thi đua
                if (string.IsNullOrEmpty(txt_diemthidua.Text))
                {
                    MessageBox.Show("Vui lòng chọn tháng trước khi nhập điểm thi đua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int diemThiDua;
                if (!int.TryParse(txt_diemthidua.Text, out diemThiDua))
                {
                    MessageBox.Show("Điểm thi đua không hợp lệ. Vui lòng nhập số nguyên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal troCapThem = tinhLuong.TinhTroCapThem(mucTroCapChucVu, diemThiDua);

                // Tính tổng lương
                decimal tongLuong = tinhLuong.TinhTongLuong(luongCung, troCapThem);

                // Hiển thị kết quả
                txt_tienluong.Text = tongLuong.ToString("N0");         // Tổng lương
                txt_tientietvuot.Text = tongTienTietVuot.ToString("N0"); // Tiền tiết vượt
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            var selectedGV = (GIANGVIEN)cbxgv.SelectedItem;
            var selectThang = dateTimeThangLuong.Value;
            var maNamHoc = tinhLuong.GetNamHoc(selectThang.Year);

            if (selectedGV != null && maNamHoc != null)
            {
                try
                {
                    // Lấy các giá trị đã tính toán từ các ô nhập liệu
                    float tongLuong = float.Parse(txt_tienluong.Text);
                    int tongTietDay = int.Parse(txt_lt.Text) + int.Parse(txt_th.Text);

                    // Lấy đơn giá tiết vượt lý thuyết và thực hành
                    float donGiaTietVuotLyThuyet = tinhLuong.LayDonGiaTietVuot(selectedGV.MAGIANGVIEN);
                    float donGiaTietVuotThucHanh = donGiaTietVuotLyThuyet * 0.75f;

                    // Lưu dữ liệu
                    tinhLuong.LuuLuongVaTietVuot(selectedGV, selectThang, maNamHoc, tongLuong, tongTietDay, donGiaTietVuotLyThuyet, donGiaTietVuotThucHanh);

                    // Cập nhật lại DataGridView
                    Load_LuongTheoThang();
                    Load_TienTietVuot();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn giảng viên và năm học hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dtgvLuong.SelectedRows.Count > 0)
            {
                var selectedRow = dtgvLuong.SelectedRows[0];
                string maGiangVien = selectedRow.Cells["MAGIANGVIEN"].Value.ToString();

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này không?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        tinhLuong.XoaLuongTheoThang(maGiangVien);
                        Load_LuongTheoThang();
                        MessageBox.Show("Dữ liệu đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng lương để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_xoa2_Click(object sender, EventArgs e)
        {
            if (dtgvTietvuot.SelectedRows.Count > 0)
            {
                var selectedRow = dtgvTietvuot.SelectedRows[0];
                string maGiangVien = selectedRow.Cells["MAGIANGVIEN"].Value.ToString();

                var confirmResult = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu này không?",
                                                     "Xác nhận xóa",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    try
                    {
                        tinhLuong.XoaTietVuot(maGiangVien);
                        Load_TienTietVuot();
                        MessageBox.Show("Dữ liệu đã được xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trong bảng tiết vượt để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
