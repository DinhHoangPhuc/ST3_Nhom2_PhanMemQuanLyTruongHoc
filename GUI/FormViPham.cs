using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


    }
}
