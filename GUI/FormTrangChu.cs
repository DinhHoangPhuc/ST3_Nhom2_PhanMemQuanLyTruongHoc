using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using MaterialSkin;
using MaterialSkin.Controls;

namespace GUI
{
    public partial class FormTrangChu : MaterialSkin.Controls.MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private Form frmDashboard;
        private Form frmDiemThiDua;

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

            InitializeChildForms();
        }

        private void InitializeChildForms()
        {
            frmDashboard = new FormDashBoard();
            frmDiemThiDua = new FormDiemThiDua();
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
                    ResetControlSizes(materialForm);
                }
            }
        }

        private void ResetControlSizes(Form form)
        {
            foreach (Control control in form.Controls)
            {
                control.Size = control.PreferredSize;
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }

            if (tabControl.SelectedTab == TrangChuPage)
            {
                AddFormDashBoardToTabPage();
                //ShowChildForm(ref frmDashboard, typeof(FormDashBoard));
            }
            else if (tabControl.SelectedTab == DiemThiDuaViPhamPage)
            {
                AddFormDiemThiDuaToTabPage();
                //ShowChildForm(ref frmDiemThiDua, typeof(FormDiemThiDua));
            }
        }

        private void ShowChildForm(ref Form childForm, Type formType)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = (Form)Activator.CreateInstance(formType);
            }

            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }

        private void AddFormDashBoardToTabPage()
        {
            frmDashboard.TopLevel = false;
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            frmDashboard.Dock = DockStyle.Fill;

            TrangChuPage.Controls.Clear();

            TrangChuPage.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void AddFormDiemThiDuaToTabPage()
        {
            frmDiemThiDua.TopLevel = false;
            frmDiemThiDua.FormBorderStyle = FormBorderStyle.None;
            frmDiemThiDua.Dock = DockStyle.Fill;

            DiemThiDuaViPhamPage.Controls.Clear();

            DiemThiDuaViPhamPage.Controls.Add(frmDiemThiDua);
            frmDiemThiDua.Show();
        }

    }
}
