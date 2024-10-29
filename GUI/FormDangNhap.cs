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

namespace GUI
{
    public partial class FormDangNhap : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FormDangNhap()
        {
            InitializeComponent();

            // Khởi tạo MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Mặc định là Light Theme
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700, Primary.Blue200,
                Accent.Orange400, TextShade.WHITE);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            FormTrangChu formTrangChu = new FormTrangChu();
            formTrangChu.ShowDialog();
        }
    }
}
