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

namespace GUI
{
    public partial class FormTrangChu : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        public FormTrangChu()
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

        private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            // Chuyển đổi giữa Light và Dark Theme
            if (materialSkinManager.Theme == MaterialSkinManager.Themes.LIGHT)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            // Lưu trạng thái theme vào Settings
            Properties.Settings.Default.IsDarkTheme = (materialSkinManager.Theme == MaterialSkinManager.Themes.DARK);
            Properties.Settings.Default.Save();

            // Cập nhật theme cho tất cả các form đang mở
            UpdateThemeForAllForms();
        }

        private void UpdateThemeForAllForms()
        {
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is MaterialForm materialForm)
                {
                    materialSkinManager.AddFormToManage(materialForm);
                }
            }
        }
    }
}
