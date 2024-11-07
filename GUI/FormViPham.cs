using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class FormViPham : Form
    {
        QLTHDataContext qlth=new QLTHDataContext();
        public FormViPham()
        {
            InitializeComponent();
        }


        private void FormViPham_Load(object sender, EventArgs e)
        {
            LoadViPham();
            LoadGiangVienComboBox();
        }


        public void LoadViPham()
        {
            
            var query = from vipham in qlth.VIPHAMs
                        select new
                        {
                            vipham.MAVIPHAM,
                            vipham.TENVIPHAM,
                            vipham.GHICHU,
                            vipham.DIEMTRU,
                            vipham.THANGVIPHAM,
                            vipham.MAGIANGVIEN
                        };
            dtgvViPham.DataSource = query.ToList();
        
            
        }


        public void LoadGiangVienComboBox()
        {
            
            var giangVienList = (from giangvien in qlth.GIANGVIENs
                                 select new
                                 {
                                     MAGIANGVIEN = giangvien.MAGIANGVIEN,
                                     DisplayText = giangvien.MAGIANGVIEN + " - " + giangvien.TENGIANGVIEN
                                 }).ToList();

            Cbb_GiangVien.DataSource = giangVienList;
            Cbb_GiangVien.DisplayMember = "DisplayText"; 
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

        public string GenerateNewViPhamCode()
        {
            using (var dataContext = new QLTHDataContext())
            {
                var lastViPham = dataContext.VIPHAMs
                    .OrderByDescending(vp => vp.MAVIPHAM) 
                    .FirstOrDefault(); 

                if (lastViPham == null)
                {
                    
                    return "VP001";
                }
                else
                {
                    string lastCode = lastViPham.MAVIPHAM.Substring(2); 
                    int newCodeNumber = int.Parse(lastCode) + 1; 

                    return "VP" + newCodeNumber.ToString("D3"); 
                }
            }
        }
        
        //Thêm vi phạm
        public void AddViPham()
        {
            using (var dataContext = new QLTHDataContext())
            {
                if (Cbb_GiangVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn giảng viên.");
                    return;
                }

                string maViPham = GenerateNewViPhamCode(); 
                string tenViPham = txt_TenViPham.Text;
                string ghiChu = txt_GhiChu.Text;
                int diemTru = (int)numeric_DiemTru.Value; 
                DateTime thangViPham = datetimpicker_NgayVP.Value;
                string maGiangVien = Cbb_GiangVien.SelectedValue.ToString();

 
                var viPham = new VIPHAM
                {
                    MAVIPHAM = maViPham,
                    TENVIPHAM = tenViPham,
                    GHICHU = ghiChu,
                    DIEMTRU = diemTru,
                    THANGVIPHAM = thangViPham,
                    MAGIANGVIEN = maGiangVien
                };

                dataContext.VIPHAMs.InsertOnSubmit(viPham);

                try
                {
                    dataContext.SubmitChanges();
                    MessageBox.Show("Thêm vi phạm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            LoadViPham();
        }

        //Sửa vi phạm
        public void EditViPham()
        {
            using (var dataContext = new QLTHDataContext())
            {
                if (Cbb_GiangVien.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn giảng viên.");
                    return;
                }

                string maViPham = txt_MaViPham.Text;
                string tenViPham = txt_TenViPham.Text;
                string ghiChu = txt_GhiChu.Text;
                int diemTru = (int)numeric_DiemTru.Value;
                DateTime thangViPham = datetimpicker_NgayVP.Value;
                string maGiangVien = Cbb_GiangVien.SelectedValue.ToString();

                var viPham = dataContext.VIPHAMs
                    .FirstOrDefault(vp => vp.MAVIPHAM == maViPham);

                if (viPham == null)
                {
                    MessageBox.Show("Không tìm thấy mã vi phạm!");
                    return;
                }

                viPham.TENVIPHAM = tenViPham;
                viPham.GHICHU = ghiChu;
                viPham.DIEMTRU = diemTru;
                viPham.THANGVIPHAM = thangViPham;
                viPham.MAGIANGVIEN = maGiangVien;

                try
                {
                    dataContext.SubmitChanges();
                    MessageBox.Show("Sửa vi phạm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            LoadViPham();

        }

        //Xóa vi phạm
        public void DeleteViPham()
        {
            using (var dataContext = new QLTHDataContext())
            {
                string maViPham = txt_MaViPham.Text;

                var viPham = dataContext.VIPHAMs
                    .FirstOrDefault(vp => vp.MAVIPHAM == maViPham);

                if (viPham == null)
                {
                    MessageBox.Show("Không tìm thấy mã vi phạm!");
                    return;
                }

                dataContext.VIPHAMs.DeleteOnSubmit(viPham);

                try
                {
                    dataContext.SubmitChanges();
                    MessageBox.Show("Xóa vi phạm thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            LoadViPham();
        }


        private void btn_Them_Click(object sender, EventArgs e)
        {
            AddViPham();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            EditViPham();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DeleteViPham();
        }
    }
}
