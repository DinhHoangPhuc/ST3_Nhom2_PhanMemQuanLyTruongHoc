namespace GUI
{
    partial class FormViPham
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtgvViPham = new System.Windows.Forms.DataGridView();
            this.txt_MaViPham = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txt_TenViPham = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txt_GhiChu = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.datetimpicker_NgayVP = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.numeric_DiemTru = new System.Windows.Forms.NumericUpDown();
            this.Cbb_GiangVien = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_Them = new MaterialSkin.Controls.MaterialButton();
            this.btn_Sua = new MaterialSkin.Controls.MaterialButton();
            this.btn_Xoa = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_DiemTru)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(494, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Vi Phạm";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(21, 88);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(88, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Mã Vi Phạm";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(363, 88);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Tên Vi Phạm";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(28, 165);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(57, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Ghi Chú";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(770, 164);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(67, 19);
            this.materialLabel5.TabIndex = 5;
            this.materialLabel5.Text = "Điểm Trừ";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(362, 164);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(78, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "Giảng Viên";
            // 
            // dtgvViPham
            // 
            this.dtgvViPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvViPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvViPham.Location = new System.Drawing.Point(14, 299);
            this.dtgvViPham.Name = "dtgvViPham";
            this.dtgvViPham.RowHeadersWidth = 51;
            this.dtgvViPham.RowTemplate.Height = 24;
            this.dtgvViPham.Size = new System.Drawing.Size(1086, 406);
            this.dtgvViPham.TabIndex = 8;
            this.dtgvViPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvViPham_CellClick);
            // 
            // txt_MaViPham
            // 
            this.txt_MaViPham.AllowPromptAsInput = true;
            this.txt_MaViPham.AnimateReadOnly = false;
            this.txt_MaViPham.AsciiOnly = false;
            this.txt_MaViPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_MaViPham.BeepOnError = false;
            this.txt_MaViPham.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_MaViPham.Depth = 0;
            this.txt_MaViPham.Enabled = false;
            this.txt_MaViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_MaViPham.HidePromptOnLeave = false;
            this.txt_MaViPham.HideSelection = true;
            this.txt_MaViPham.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_MaViPham.LeadingIcon = null;
            this.txt_MaViPham.Location = new System.Drawing.Point(167, 74);
            this.txt_MaViPham.Mask = "";
            this.txt_MaViPham.MaxLength = 32767;
            this.txt_MaViPham.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_MaViPham.Name = "txt_MaViPham";
            this.txt_MaViPham.PasswordChar = '\0';
            this.txt_MaViPham.PrefixSuffixText = null;
            this.txt_MaViPham.PromptChar = '_';
            this.txt_MaViPham.ReadOnly = false;
            this.txt_MaViPham.RejectInputOnFirstFailure = false;
            this.txt_MaViPham.ResetOnPrompt = true;
            this.txt_MaViPham.ResetOnSpace = true;
            this.txt_MaViPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_MaViPham.SelectedText = "";
            this.txt_MaViPham.SelectionLength = 0;
            this.txt_MaViPham.SelectionStart = 0;
            this.txt_MaViPham.ShortcutsEnabled = true;
            this.txt_MaViPham.Size = new System.Drawing.Size(177, 48);
            this.txt_MaViPham.SkipLiterals = true;
            this.txt_MaViPham.TabIndex = 9;
            this.txt_MaViPham.TabStop = false;
            this.txt_MaViPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_MaViPham.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_MaViPham.TrailingIcon = null;
            this.txt_MaViPham.UseSystemPasswordChar = false;
            this.txt_MaViPham.ValidatingType = null;
            // 
            // txt_TenViPham
            // 
            this.txt_TenViPham.AllowPromptAsInput = true;
            this.txt_TenViPham.AnimateReadOnly = false;
            this.txt_TenViPham.AsciiOnly = false;
            this.txt_TenViPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_TenViPham.BeepOnError = false;
            this.txt_TenViPham.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_TenViPham.Depth = 0;
            this.txt_TenViPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_TenViPham.HidePromptOnLeave = false;
            this.txt_TenViPham.HideSelection = true;
            this.txt_TenViPham.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_TenViPham.LeadingIcon = null;
            this.txt_TenViPham.Location = new System.Drawing.Point(509, 74);
            this.txt_TenViPham.Mask = "";
            this.txt_TenViPham.MaxLength = 32767;
            this.txt_TenViPham.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_TenViPham.Name = "txt_TenViPham";
            this.txt_TenViPham.PasswordChar = '\0';
            this.txt_TenViPham.PrefixSuffixText = null;
            this.txt_TenViPham.PromptChar = '_';
            this.txt_TenViPham.ReadOnly = false;
            this.txt_TenViPham.RejectInputOnFirstFailure = false;
            this.txt_TenViPham.ResetOnPrompt = true;
            this.txt_TenViPham.ResetOnSpace = true;
            this.txt_TenViPham.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_TenViPham.SelectedText = "";
            this.txt_TenViPham.SelectionLength = 0;
            this.txt_TenViPham.SelectionStart = 0;
            this.txt_TenViPham.ShortcutsEnabled = true;
            this.txt_TenViPham.Size = new System.Drawing.Size(177, 48);
            this.txt_TenViPham.SkipLiterals = true;
            this.txt_TenViPham.TabIndex = 10;
            this.txt_TenViPham.TabStop = false;
            this.txt_TenViPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_TenViPham.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_TenViPham.TrailingIcon = null;
            this.txt_TenViPham.UseSystemPasswordChar = false;
            this.txt_TenViPham.ValidatingType = null;
            // 
            // txt_GhiChu
            // 
            this.txt_GhiChu.AllowPromptAsInput = true;
            this.txt_GhiChu.AnimateReadOnly = false;
            this.txt_GhiChu.AsciiOnly = false;
            this.txt_GhiChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_GhiChu.BeepOnError = false;
            this.txt_GhiChu.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_GhiChu.Depth = 0;
            this.txt_GhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_GhiChu.HidePromptOnLeave = false;
            this.txt_GhiChu.HideSelection = true;
            this.txt_GhiChu.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_GhiChu.LeadingIcon = null;
            this.txt_GhiChu.Location = new System.Drawing.Point(167, 151);
            this.txt_GhiChu.Mask = "";
            this.txt_GhiChu.MaxLength = 32767;
            this.txt_GhiChu.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_GhiChu.Name = "txt_GhiChu";
            this.txt_GhiChu.PasswordChar = '\0';
            this.txt_GhiChu.PrefixSuffixText = null;
            this.txt_GhiChu.PromptChar = '_';
            this.txt_GhiChu.ReadOnly = false;
            this.txt_GhiChu.RejectInputOnFirstFailure = false;
            this.txt_GhiChu.ResetOnPrompt = true;
            this.txt_GhiChu.ResetOnSpace = true;
            this.txt_GhiChu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_GhiChu.SelectedText = "";
            this.txt_GhiChu.SelectionLength = 0;
            this.txt_GhiChu.SelectionStart = 0;
            this.txt_GhiChu.ShortcutsEnabled = true;
            this.txt_GhiChu.Size = new System.Drawing.Size(177, 48);
            this.txt_GhiChu.SkipLiterals = true;
            this.txt_GhiChu.TabIndex = 11;
            this.txt_GhiChu.TabStop = false;
            this.txt_GhiChu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_GhiChu.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_GhiChu.TrailingIcon = null;
            this.txt_GhiChu.UseSystemPasswordChar = false;
            this.txt_GhiChu.ValidatingType = null;
            // 
            // datetimpicker_NgayVP
            // 
            this.datetimpicker_NgayVP.Location = new System.Drawing.Point(858, 84);
            this.datetimpicker_NgayVP.Name = "datetimpicker_NgayVP";
            this.datetimpicker_NgayVP.Size = new System.Drawing.Size(244, 22);
            this.datetimpicker_NgayVP.TabIndex = 14;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(715, 89);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(102, 19);
            this.materialLabel7.TabIndex = 15;
            this.materialLabel7.Text = "Ngày Vi Phạm";
            // 
            // numeric_DiemTru
            // 
            this.numeric_DiemTru.Location = new System.Drawing.Point(909, 164);
            this.numeric_DiemTru.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeric_DiemTru.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_DiemTru.Name = "numeric_DiemTru";
            this.numeric_DiemTru.Size = new System.Drawing.Size(177, 22);
            this.numeric_DiemTru.TabIndex = 16;
            this.numeric_DiemTru.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Cbb_GiangVien
            // 
            this.Cbb_GiangVien.AutoResize = false;
            this.Cbb_GiangVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cbb_GiangVien.Depth = 0;
            this.Cbb_GiangVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Cbb_GiangVien.DropDownHeight = 174;
            this.Cbb_GiangVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbb_GiangVien.DropDownWidth = 121;
            this.Cbb_GiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Cbb_GiangVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cbb_GiangVien.FormattingEnabled = true;
            this.Cbb_GiangVien.IntegralHeight = false;
            this.Cbb_GiangVien.ItemHeight = 43;
            this.Cbb_GiangVien.Location = new System.Drawing.Point(470, 149);
            this.Cbb_GiangVien.MaxDropDownItems = 4;
            this.Cbb_GiangVien.MouseState = MaterialSkin.MouseState.OUT;
            this.Cbb_GiangVien.Name = "Cbb_GiangVien";
            this.Cbb_GiangVien.Size = new System.Drawing.Size(279, 49);
            this.Cbb_GiangVien.StartIndex = 0;
            this.Cbb_GiangVien.TabIndex = 19;
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Them.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Them.Depth = 0;
            this.btn_Them.HighEmphasis = true;
            this.btn_Them.Icon = null;
            this.btn_Them.Location = new System.Drawing.Point(367, 237);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Them.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Them.Size = new System.Drawing.Size(64, 36);
            this.btn_Them.TabIndex = 20;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Them.UseAccentColor = false;
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Sua.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Sua.Depth = 0;
            this.btn_Sua.HighEmphasis = true;
            this.btn_Sua.Icon = null;
            this.btn_Sua.Location = new System.Drawing.Point(469, 237);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Sua.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Sua.Size = new System.Drawing.Size(64, 36);
            this.btn_Sua.TabIndex = 21;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Sua.UseAccentColor = false;
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Xoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Xoa.Depth = 0;
            this.btn_Xoa.HighEmphasis = true;
            this.btn_Xoa.Icon = null;
            this.btn_Xoa.Location = new System.Drawing.Point(569, 237);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Xoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Xoa.Size = new System.Drawing.Size(64, 36);
            this.btn_Xoa.TabIndex = 22;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Xoa.UseAccentColor = false;
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // FormViPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 674);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.Cbb_GiangVien);
            this.Controls.Add(this.numeric_DiemTru);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.datetimpicker_NgayVP);
            this.Controls.Add(this.txt_GhiChu);
            this.Controls.Add(this.txt_TenViPham);
            this.Controls.Add(this.txt_MaViPham);
            this.Controls.Add(this.dtgvViPham);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "FormViPham";
            this.Text = "FormViPham";
            this.Load += new System.EventHandler(this.FormViPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvViPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_DiemTru)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridView dtgvViPham;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_MaViPham;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_TenViPham;
        private MaterialSkin.Controls.MaterialMaskedTextBox txt_GhiChu;
        private System.Windows.Forms.DateTimePicker datetimpicker_NgayVP;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.NumericUpDown numeric_DiemTru;
        private MaterialSkin.Controls.MaterialComboBox Cbb_GiangVien;
        private MaterialSkin.Controls.MaterialButton btn_Them;
        private MaterialSkin.Controls.MaterialButton btn_Sua;
        private MaterialSkin.Controls.MaterialButton btn_Xoa;
    }
}