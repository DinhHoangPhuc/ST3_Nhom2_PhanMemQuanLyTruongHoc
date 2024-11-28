namespace GUI
{
    partial class FormThemMoiNguoiDung
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtTenDangNhap = new MaterialSkin.Controls.MaterialTextBox();
            this.txtMatKhau = new MaterialSkin.Controls.MaterialTextBox();
            this.checkBoxHoatDong = new MaterialSkin.Controls.MaterialCheckbox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnTaoNgauNhien = new MaterialSkin.Controls.MaterialButton();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.materialLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.35897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.64103F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(807, 300);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(801, 56);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Thêm mới người dùng";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.21598F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.78402F));
            this.tableLayoutPanel2.Controls.Add(this.materialLabel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialLabel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTenDangNhap, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtMatKhau, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxHoatDong, 1, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(801, 171);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(3, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(212, 55);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Tên đăng nhập";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(3, 55);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(212, 55);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Mật khẩu";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.AnimateReadOnly = false;
            this.txtTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenDangNhap.Depth = 0;
            this.txtTenDangNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenDangNhap.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenDangNhap.LeadingIcon = null;
            this.txtTenDangNhap.Location = new System.Drawing.Point(221, 3);
            this.txtTenDangNhap.MaxLength = 50;
            this.txtTenDangNhap.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTenDangNhap.Multiline = false;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(577, 50);
            this.txtTenDangNhap.TabIndex = 3;
            this.txtTenDangNhap.Text = "";
            this.txtTenDangNhap.TrailingIcon = null;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AnimateReadOnly = false;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Depth = 0;
            this.txtMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMatKhau.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatKhau.LeadingIcon = null;
            this.txtMatKhau.Location = new System.Drawing.Point(221, 58);
            this.txtMatKhau.MaxLength = 50;
            this.txtMatKhau.MouseState = MaterialSkin.MouseState.OUT;
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(577, 50);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "";
            this.txtMatKhau.TrailingIcon = null;
            // 
            // checkBoxHoatDong
            // 
            this.checkBoxHoatDong.AutoSize = true;
            this.checkBoxHoatDong.Depth = 0;
            this.checkBoxHoatDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxHoatDong.Location = new System.Drawing.Point(218, 110);
            this.checkBoxHoatDong.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxHoatDong.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxHoatDong.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxHoatDong.Name = "checkBoxHoatDong";
            this.checkBoxHoatDong.ReadOnly = false;
            this.checkBoxHoatDong.Ripple = true;
            this.checkBoxHoatDong.Size = new System.Drawing.Size(583, 61);
            this.checkBoxHoatDong.TabIndex = 2;
            this.checkBoxHoatDong.Text = "Hoạt động";
            this.checkBoxHoatDong.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.92384F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.07616F));
            this.tableLayoutPanel3.Controls.Add(this.btnTaoNgauNhien, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLuu, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 236);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(801, 61);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // btnTaoNgauNhien
            // 
            this.btnTaoNgauNhien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoNgauNhien.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTaoNgauNhien.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTaoNgauNhien.Depth = 0;
            this.btnTaoNgauNhien.HighEmphasis = true;
            this.btnTaoNgauNhien.Icon = null;
            this.btnTaoNgauNhien.Location = new System.Drawing.Point(366, 6);
            this.btnTaoNgauNhien.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTaoNgauNhien.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTaoNgauNhien.Name = "btnTaoNgauNhien";
            this.btnTaoNgauNhien.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTaoNgauNhien.Size = new System.Drawing.Size(117, 36);
            this.btnTaoNgauNhien.TabIndex = 1;
            this.btnTaoNgauNhien.Text = "Tạo tự động";
            this.btnTaoNgauNhien.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTaoNgauNhien.UseAccentColor = false;
            this.btnTaoNgauNhien.UseVisualStyleBackColor = true;
            this.btnTaoNgauNhien.Click += new System.EventHandler(this.btnTaoNgauNhien_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(491, 6);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(64, 36);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FormThemMoiNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 367);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormThemMoiNguoiDung";
            this.Text = "FormThemMoiNguoiDung";
            this.Load += new System.EventHandler(this.FormThemMoiNguoiDung_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtTenDangNhap;
        private MaterialSkin.Controls.MaterialTextBox txtMatKhau;
        private MaterialSkin.Controls.MaterialCheckbox checkBoxHoatDong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnTaoNgauNhien;
        private MaterialSkin.Controls.MaterialButton btnLuu;
    }
}