using System;
using System.Collections.Generic;
using System.Linq;
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
        private Form formQuanLyNguoiDung;
        private Form frmPhanQuyen;
        private Form frmTinhLuong;
        private Form frmQuanLyViPham;

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
            //CheckUserPermissions();
        }

        private void InitializeChildForms()
        {
            frmDashboard = new FormDashBoard();
            frmDiemThiDua = new FormDiemThiDua();
            formQuanLyNguoiDung = new FormQuanLyNguoiDung();
            frmPhanQuyen = new FormPhanQuyen();
            frmQuanLyViPham = new FormViPham();
        }

        private void CheckUserPermissions()
        {
            string username = Session.Username;
            UserService userService = new UserService();
            PermissionService permissionService = new PermissionService();

            string userGroup = userService.GetUserGroup(username);
            List<string> permissions = permissionService.GetPermissions(userGroup);

            // Log the permissions for debugging
            Console.WriteLine("Permissions for user group " + userGroup + ": " + string.Join(", ", permissions));

            // Disable tabs based on permissions
            if (!permissions.Contains("FormDashBoard") && tabControl.TabPages.Contains(TrangChuPage))
            {
                tabControl.TabPages.Remove(TrangChuPage);
            }
            if (!permissions.Contains("FormDiemThiDua") && tabControl.TabPages.Contains(DiemThiDuaViPhamPage))
            {
                tabControl.TabPages.Remove(DiemThiDuaViPhamPage);
            }
            if (!permissions.Contains("FormQuanLyNguoiDung") && tabControl.TabPages.Contains(QuanLynguoiDungPage))
            {
                tabControl.TabPages.Remove(QuanLynguoiDungPage);
            }
            if (!permissions.Contains("FormPhanQuyen") && tabControl.TabPages.Contains(PhanQuyenPage))
            {
                tabControl.TabPages.Remove(PhanQuyenPage);
            }
            if (!permissions.Contains("FormTinhLuong") && tabControl.TabPages.Contains(QuanLyTienLuongPage))
            {
                tabControl.TabPages.Remove(QuanLyTienLuongPage);
            }
            if (!permissions.Contains("FormViPham") && tabControl.TabPages.Contains(QuanLyViPhamPage))
            {
                tabControl.TabPages.Remove(QuanLyViPhamPage);
            }
            if (!permissions.Contains("FormXemTienLuong") && tabControl.TabPages.Contains(LuongPage))
            {
                tabControl.TabPages.Remove(LuongPage);
            }
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
            }
            else if (tabControl.SelectedTab == DiemThiDuaViPhamPage)
            {
                AddFormDiemThiDuaToTabPage();
            }
            else if (tabControl.SelectedTab == QuanLynguoiDungPage)
            {
                AddFormQuanLyNguoiDungToTabPage();
            }
            else if (tabControl.SelectedTab == PhanQuyenPage)
            {
                AddFormPhanQuyenToTabPage();
            }
            else if (tabControl.SelectedTab == QuanLyTienLuongPage)
            {
                AddFormQuanLyTienLuongToTabPage();
            }
            else if (tabControl.SelectedTab == QuanLyViPhamPage)
            {
                AddFormQuanLyViPhamToTabPage();
            }
            else if (tabControl.SelectedTab == LuongPage)
            {
                AddFormXemTienLuongToTabPage();
            }
        }

        private void ShowChildForm<T>(ref T childForm) where T : Form, new()
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new T();
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

        private void AddFormQuanLyNguoiDungToTabPage()
        {
            formQuanLyNguoiDung.TopLevel = false;
            formQuanLyNguoiDung.FormBorderStyle = FormBorderStyle.None;
            formQuanLyNguoiDung.Dock = DockStyle.Fill;

            QuanLynguoiDungPage.Controls.Clear();

            QuanLynguoiDungPage.Controls.Add(formQuanLyNguoiDung);
            formQuanLyNguoiDung.Show();
        }

        private void AddFormPhanQuyenToTabPage()
        {
            frmPhanQuyen.TopLevel = false;
            frmPhanQuyen.FormBorderStyle = FormBorderStyle.None;
            frmPhanQuyen.Dock = DockStyle.Fill;

            PhanQuyenPage.Controls.Clear();

            PhanQuyenPage.Controls.Add(frmPhanQuyen);
            frmPhanQuyen.Show();
        }

        private void AddFormQuanLyTienLuongToTabPage()
        {
            frmTinhLuong = new FormTinhLuong();

            frmTinhLuong.TopLevel = false;
            frmTinhLuong.FormBorderStyle = FormBorderStyle.None;
            frmTinhLuong.Dock = DockStyle.Fill;

            QuanLyTienLuongPage.Controls.Clear();

            QuanLyTienLuongPage.Controls.Add(frmTinhLuong);
            frmTinhLuong.Show();
        }

        private void AddFormQuanLyViPhamToTabPage()
        {
            frmQuanLyViPham.TopLevel = false;
            frmQuanLyViPham.FormBorderStyle = FormBorderStyle.None;
            frmQuanLyViPham.Dock = DockStyle.Fill;

            QuanLyViPhamPage.Controls.Clear();

            QuanLyViPhamPage.Controls.Add(frmQuanLyViPham);
            frmQuanLyViPham.Show();
        }

        private void AddFormXemTienLuongToTabPage()
        {
            Form frmXemTienLuong = new FormXemTienLuong();
            frmXemTienLuong.TopLevel = false;
            frmXemTienLuong.FormBorderStyle = FormBorderStyle.None;
            frmXemTienLuong.Dock = DockStyle.Fill;
            LuongPage.Controls.Clear();
            LuongPage.Controls.Add(frmXemTienLuong);
            frmXemTienLuong.Show();
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            CheckUserPermissions();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void DangXuatPage_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            Session.Username = null;


            FormDangNhap loginForm = new FormDangNhap();
            loginForm.Show();
            this.Close();

        }
    }
}

