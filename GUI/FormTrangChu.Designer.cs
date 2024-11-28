
namespace GUI
{
    partial class FormTrangChu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrangChu));
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TrangChuPage = new System.Windows.Forms.TabPage();
            this.DiemThiDuaViPhamPage = new System.Windows.Forms.TabPage();
            this.QuanLynguoiDungPage = new System.Windows.Forms.TabPage();
            this.QuanLyViPhamPage = new System.Windows.Forms.TabPage();
            this.QuanLyTienLuongPage = new System.Windows.Forms.TabPage();
            this.LuongPage = new System.Windows.Forms.TabPage();
            this.PhanQuyenPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDangXuat = new MaterialSkin.Controls.MaterialButton();
            this.DangXuatPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TrangChuPage);
            this.tabControl.Controls.Add(this.DiemThiDuaViPhamPage);
            this.tabControl.Controls.Add(this.QuanLynguoiDungPage);
            this.tabControl.Controls.Add(this.QuanLyViPhamPage);
            this.tabControl.Controls.Add(this.QuanLyTienLuongPage);
            this.tabControl.Controls.Add(this.LuongPage);
            this.tabControl.Controls.Add(this.PhanQuyenPage);
            this.tabControl.Controls.Add(this.DangXuatPage);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1776, 953);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // TrangChuPage
            // 
            this.TrangChuPage.ImageKey = "icons8-home-26.png";
            this.TrangChuPage.Location = new System.Drawing.Point(4, 39);
            this.TrangChuPage.Margin = new System.Windows.Forms.Padding(4);
            this.TrangChuPage.Name = "TrangChuPage";
            this.TrangChuPage.Padding = new System.Windows.Forms.Padding(4);
            this.TrangChuPage.Size = new System.Drawing.Size(1768, 910);
            this.TrangChuPage.TabIndex = 0;
            this.TrangChuPage.Text = "Trang chủ";
            this.TrangChuPage.UseVisualStyleBackColor = true;
            // 
            // DiemThiDuaViPhamPage
            // 
            this.DiemThiDuaViPhamPage.ImageKey = "icons8-ratings-26.png";
            this.DiemThiDuaViPhamPage.Location = new System.Drawing.Point(4, 39);
            this.DiemThiDuaViPhamPage.Margin = new System.Windows.Forms.Padding(4);
            this.DiemThiDuaViPhamPage.Name = "DiemThiDuaViPhamPage";
            this.DiemThiDuaViPhamPage.Padding = new System.Windows.Forms.Padding(4);
            this.DiemThiDuaViPhamPage.Size = new System.Drawing.Size(1768, 910);
            this.DiemThiDuaViPhamPage.TabIndex = 1;
            this.DiemThiDuaViPhamPage.Text = "Điểm thi đua";
            this.DiemThiDuaViPhamPage.UseVisualStyleBackColor = true;
            // 
            // QuanLynguoiDungPage
            // 
            this.QuanLynguoiDungPage.ImageKey = "icons8-user-groups-32.png";
            this.QuanLynguoiDungPage.Location = new System.Drawing.Point(4, 39);
            this.QuanLynguoiDungPage.Name = "QuanLynguoiDungPage";
            this.QuanLynguoiDungPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLynguoiDungPage.Size = new System.Drawing.Size(1768, 910);
            this.QuanLynguoiDungPage.TabIndex = 2;
            this.QuanLynguoiDungPage.Text = "Quản lý người dùng";
            this.QuanLynguoiDungPage.UseVisualStyleBackColor = true;
            // 
            // QuanLyViPhamPage
            // 
            this.QuanLyViPhamPage.ImageKey = "icons8-rules-32.png";
            this.QuanLyViPhamPage.Location = new System.Drawing.Point(4, 39);
            this.QuanLyViPhamPage.Name = "QuanLyViPhamPage";
            this.QuanLyViPhamPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLyViPhamPage.Size = new System.Drawing.Size(1768, 910);
            this.QuanLyViPhamPage.TabIndex = 3;
            this.QuanLyViPhamPage.Text = "Quản lý vi phạm";
            this.QuanLyViPhamPage.UseVisualStyleBackColor = true;
            // 
            // QuanLyTienLuongPage
            // 
            this.QuanLyTienLuongPage.ImageKey = "icons8-salary-32.png";
            this.QuanLyTienLuongPage.Location = new System.Drawing.Point(4, 39);
            this.QuanLyTienLuongPage.Name = "QuanLyTienLuongPage";
            this.QuanLyTienLuongPage.Padding = new System.Windows.Forms.Padding(3);
            this.QuanLyTienLuongPage.Size = new System.Drawing.Size(1768, 910);
            this.QuanLyTienLuongPage.TabIndex = 4;
            this.QuanLyTienLuongPage.Text = "Quản lý tiền lương";
            this.QuanLyTienLuongPage.UseVisualStyleBackColor = true;
            // 
            // LuongPage
            // 
            this.LuongPage.ImageKey = "icons8-salary-32 (1).png";
            this.LuongPage.Location = new System.Drawing.Point(4, 39);
            this.LuongPage.Name = "LuongPage";
            this.LuongPage.Padding = new System.Windows.Forms.Padding(3);
            this.LuongPage.Size = new System.Drawing.Size(1768, 910);
            this.LuongPage.TabIndex = 5;
            this.LuongPage.Text = "Tiền lương";
            this.LuongPage.UseVisualStyleBackColor = true;
            // 
            // PhanQuyenPage
            // 
            this.PhanQuyenPage.ImageKey = "icons8-roles-50.png";
            this.PhanQuyenPage.Location = new System.Drawing.Point(4, 39);
            this.PhanQuyenPage.Name = "PhanQuyenPage";
            this.PhanQuyenPage.Padding = new System.Windows.Forms.Padding(3);
            this.PhanQuyenPage.Size = new System.Drawing.Size(1768, 910);
            this.PhanQuyenPage.TabIndex = 6;
            this.PhanQuyenPage.Text = "Phân quyền người dùng";
            this.PhanQuyenPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-home-26.png");
            this.imageList1.Images.SetKeyName(1, "icons8-ratings-26.png");
            this.imageList1.Images.SetKeyName(2, "icons8-salary-32 (1).png");
            this.imageList1.Images.SetKeyName(3, "icons8-salary-32.png");
            this.imageList1.Images.SetKeyName(4, "icons8-user-groups-32.png");
            this.imageList1.Images.SetKeyName(5, "icons8-rules-32.png");
            this.imageList1.Images.SetKeyName(6, "icons8-roles-50.png");
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDangXuat.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDangXuat.Depth = 0;
            this.btnDangXuat.HighEmphasis = true;
            this.btnDangXuat.Icon = null;
            this.btnDangXuat.Location = new System.Drawing.Point(1208, 18);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDangXuat.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDangXuat.Size = new System.Drawing.Size(103, 36);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDangXuat.UseAccentColor = false;
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // DangXuatPage
            // 
            this.DangXuatPage.Location = new System.Drawing.Point(4, 39);
            this.DangXuatPage.Name = "DangXuatPage";
            this.DangXuatPage.Padding = new System.Windows.Forms.Padding(3);
            this.DangXuatPage.Size = new System.Drawing.Size(1768, 910);
            this.DangXuatPage.TabIndex = 7;
            this.DangXuatPage.Text = "Đăng xuất";
            this.DangXuatPage.UseVisualStyleBackColor = true;
            this.DangXuatPage.Click += new System.EventHandler(this.DangXuatPage_Click);
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 1019);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.tabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTrangChu";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChuForm";
            this.Load += new System.EventHandler(this.FormTrangChu_Load);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage TrangChuPage;
        private System.Windows.Forms.TabPage DiemThiDuaViPhamPage;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage QuanLynguoiDungPage;
        private System.Windows.Forms.TabPage QuanLyViPhamPage;
        private System.Windows.Forms.TabPage QuanLyTienLuongPage;
        private System.Windows.Forms.TabPage LuongPage;
        private System.Windows.Forms.TabPage PhanQuyenPage;
        private MaterialSkin.Controls.MaterialButton btnDangXuat;
        private System.Windows.Forms.TabPage DangXuatPage;
    }
}