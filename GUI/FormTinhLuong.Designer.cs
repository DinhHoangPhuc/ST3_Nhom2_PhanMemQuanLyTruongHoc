namespace GUI
{
    partial class FormTinhLuong
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
            this.btn_xoa2 = new MaterialSkin.Controls.MaterialButton();
            this.txt_tientietvuot = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dtgvTietvuot = new System.Windows.Forms.DataGridView();
            this.txt_tienluong = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimeThangLuong = new System.Windows.Forms.DateTimePicker();
            this.txt_diemthidua = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_luu = new MaterialSkin.Controls.MaterialButton();
            this.btn_xoa = new MaterialSkin.Controls.MaterialButton();
            this.btn_tinhluong = new MaterialSkin.Controls.MaterialButton();
            this.txt_th = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_lt = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxgv = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtgvLuong = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTietvuot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_xoa2
            // 
            this.btn_xoa2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_xoa2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_xoa2.Depth = 0;
            this.btn_xoa2.HighEmphasis = true;
            this.btn_xoa2.Icon = null;
            this.btn_xoa2.Location = new System.Drawing.Point(1082, 630);
            this.btn_xoa2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_xoa2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_xoa2.Name = "btn_xoa2";
            this.btn_xoa2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_xoa2.Size = new System.Drawing.Size(64, 36);
            this.btn_xoa2.TabIndex = 41;
            this.btn_xoa2.Text = "Xóa";
            this.btn_xoa2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_xoa2.UseAccentColor = false;
            this.btn_xoa2.UseVisualStyleBackColor = true;
            this.btn_xoa2.Click += new System.EventHandler(this.btn_xoa2_Click);
            // 
            // txt_tientietvuot
            // 
            this.txt_tientietvuot.AnimateReadOnly = false;
            this.txt_tientietvuot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_tientietvuot.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_tientietvuot.Depth = 0;
            this.txt_tientietvuot.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_tientietvuot.HideSelection = true;
            this.txt_tientietvuot.LeadingIcon = null;
            this.txt_tientietvuot.Location = new System.Drawing.Point(1083, 156);
            this.txt_tientietvuot.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tientietvuot.MaxLength = 32767;
            this.txt_tientietvuot.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_tientietvuot.Name = "txt_tientietvuot";
            this.txt_tientietvuot.PasswordChar = '\0';
            this.txt_tientietvuot.PrefixSuffixText = null;
            this.txt_tientietvuot.ReadOnly = false;
            this.txt_tientietvuot.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_tientietvuot.SelectedText = "";
            this.txt_tientietvuot.SelectionLength = 0;
            this.txt_tientietvuot.SelectionStart = 0;
            this.txt_tientietvuot.ShortcutsEnabled = true;
            this.txt_tientietvuot.Size = new System.Drawing.Size(288, 48);
            this.txt_tientietvuot.TabIndex = 40;
            this.txt_tientietvuot.TabStop = false;
            this.txt_tientietvuot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tientietvuot.TrailingIcon = null;
            this.txt_tientietvuot.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(933, 177);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(98, 19);
            this.materialLabel7.TabIndex = 39;
            this.materialLabel7.Text = "Tiền tiết vượt:";
            // 
            // dtgvTietvuot
            // 
            this.dtgvTietvuot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTietvuot.Location = new System.Drawing.Point(726, 350);
            this.dtgvTietvuot.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvTietvuot.Name = "dtgvTietvuot";
            this.dtgvTietvuot.RowHeadersWidth = 51;
            this.dtgvTietvuot.Size = new System.Drawing.Size(701, 276);
            this.dtgvTietvuot.TabIndex = 38;
            // 
            // txt_tienluong
            // 
            this.txt_tienluong.AnimateReadOnly = false;
            this.txt_tienluong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_tienluong.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_tienluong.Depth = 0;
            this.txt_tienluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_tienluong.HideSelection = true;
            this.txt_tienluong.LeadingIcon = null;
            this.txt_tienluong.Location = new System.Drawing.Point(1082, 91);
            this.txt_tienluong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tienluong.MaxLength = 32767;
            this.txt_tienluong.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_tienluong.Name = "txt_tienluong";
            this.txt_tienluong.PasswordChar = '\0';
            this.txt_tienluong.PrefixSuffixText = null;
            this.txt_tienluong.ReadOnly = false;
            this.txt_tienluong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_tienluong.SelectedText = "";
            this.txt_tienluong.SelectionLength = 0;
            this.txt_tienluong.SelectionStart = 0;
            this.txt_tienluong.ShortcutsEnabled = true;
            this.txt_tienluong.Size = new System.Drawing.Size(289, 48);
            this.txt_tienluong.TabIndex = 37;
            this.txt_tienluong.TabStop = false;
            this.txt_tienluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_tienluong.TrailingIcon = null;
            this.txt_tienluong.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(933, 103);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(81, 19);
            this.materialLabel6.TabIndex = 36;
            this.materialLabel6.Text = "Tiền lương:";
            // 
            // dateTimeThangLuong
            // 
            this.dateTimeThangLuong.Location = new System.Drawing.Point(169, 172);
            this.dateTimeThangLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeThangLuong.Name = "dateTimeThangLuong";
            this.dateTimeThangLuong.Size = new System.Drawing.Size(244, 22);
            this.dateTimeThangLuong.TabIndex = 35;
            this.dateTimeThangLuong.ValueChanged += new System.EventHandler(this.dateTimeThangLuong_ValueChanged);
            // 
            // txt_diemthidua
            // 
            this.txt_diemthidua.AnimateReadOnly = false;
            this.txt_diemthidua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_diemthidua.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_diemthidua.Depth = 0;
            this.txt_diemthidua.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_diemthidua.HideSelection = true;
            this.txt_diemthidua.LeadingIcon = null;
            this.txt_diemthidua.Location = new System.Drawing.Point(681, 225);
            this.txt_diemthidua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diemthidua.MaxLength = 32767;
            this.txt_diemthidua.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_diemthidua.Name = "txt_diemthidua";
            this.txt_diemthidua.PasswordChar = '\0';
            this.txt_diemthidua.PrefixSuffixText = null;
            this.txt_diemthidua.ReadOnly = false;
            this.txt_diemthidua.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_diemthidua.SelectedText = "";
            this.txt_diemthidua.SelectionLength = 0;
            this.txt_diemthidua.SelectionStart = 0;
            this.txt_diemthidua.ShortcutsEnabled = true;
            this.txt_diemthidua.Size = new System.Drawing.Size(191, 48);
            this.txt_diemthidua.TabIndex = 34;
            this.txt_diemthidua.TabStop = false;
            this.txt_diemthidua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_diemthidua.TrailingIcon = null;
            this.txt_diemthidua.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(486, 242);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 19);
            this.materialLabel5.TabIndex = 33;
            this.materialLabel5.Text = "Điểm thi đua:";
            // 
            // btn_luu
            // 
            this.btn_luu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_luu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_luu.Depth = 0;
            this.btn_luu.HighEmphasis = true;
            this.btn_luu.Icon = null;
            this.btn_luu.Location = new System.Drawing.Point(1082, 303);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_luu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_luu.Size = new System.Drawing.Size(64, 36);
            this.btn_luu.TabIndex = 32;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_luu.UseAccentColor = false;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_xoa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_xoa.Depth = 0;
            this.btn_xoa.HighEmphasis = true;
            this.btn_xoa.Icon = null;
            this.btn_xoa.Location = new System.Drawing.Point(327, 630);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_xoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_xoa.Size = new System.Drawing.Size(64, 36);
            this.btn_xoa.TabIndex = 31;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_xoa.UseAccentColor = false;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_tinhluong
            // 
            this.btn_tinhluong.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_tinhluong.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_tinhluong.Depth = 0;
            this.btn_tinhluong.HighEmphasis = true;
            this.btn_tinhluong.Icon = null;
            this.btn_tinhluong.Location = new System.Drawing.Point(305, 303);
            this.btn_tinhluong.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_tinhluong.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_tinhluong.Name = "btn_tinhluong";
            this.btn_tinhluong.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_tinhluong.Size = new System.Drawing.Size(108, 36);
            this.btn_tinhluong.TabIndex = 30;
            this.btn_tinhluong.Text = "Tính Lương";
            this.btn_tinhluong.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_tinhluong.UseAccentColor = false;
            this.btn_tinhluong.UseVisualStyleBackColor = true;
            this.btn_tinhluong.Click += new System.EventHandler(this.btn_tinhluong_Click);
            // 
            // txt_th
            // 
            this.txt_th.AnimateReadOnly = false;
            this.txt_th.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_th.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_th.Depth = 0;
            this.txt_th.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_th.HideSelection = true;
            this.txt_th.LeadingIcon = null;
            this.txt_th.Location = new System.Drawing.Point(681, 156);
            this.txt_th.Margin = new System.Windows.Forms.Padding(4);
            this.txt_th.MaxLength = 32767;
            this.txt_th.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_th.Name = "txt_th";
            this.txt_th.PasswordChar = '\0';
            this.txt_th.PrefixSuffixText = null;
            this.txt_th.ReadOnly = false;
            this.txt_th.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_th.SelectedText = "";
            this.txt_th.SelectionLength = 0;
            this.txt_th.SelectionStart = 0;
            this.txt_th.ShortcutsEnabled = true;
            this.txt_th.Size = new System.Drawing.Size(191, 48);
            this.txt_th.TabIndex = 29;
            this.txt_th.TabStop = false;
            this.txt_th.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_th.TrailingIcon = null;
            this.txt_th.UseSystemPasswordChar = false;
            // 
            // txt_lt
            // 
            this.txt_lt.AnimateReadOnly = false;
            this.txt_lt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_lt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_lt.Depth = 0;
            this.txt_lt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_lt.HideSelection = true;
            this.txt_lt.LeadingIcon = null;
            this.txt_lt.Location = new System.Drawing.Point(681, 90);
            this.txt_lt.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lt.MaxLength = 32767;
            this.txt_lt.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_lt.Name = "txt_lt";
            this.txt_lt.PasswordChar = '\0';
            this.txt_lt.PrefixSuffixText = null;
            this.txt_lt.ReadOnly = false;
            this.txt_lt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_lt.SelectedText = "";
            this.txt_lt.SelectionLength = 0;
            this.txt_lt.SelectionStart = 0;
            this.txt_lt.ShortcutsEnabled = true;
            this.txt_lt.Size = new System.Drawing.Size(191, 48);
            this.txt_lt.TabIndex = 28;
            this.txt_lt.TabStop = false;
            this.txt_lt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_lt.TrailingIcon = null;
            this.txt_lt.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(486, 172);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(133, 19);
            this.materialLabel4.TabIndex = 27;
            this.materialLabel4.Text = "Số tiết Thực Hành:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(486, 103);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(129, 19);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Số Tiết Lý Thuyết:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(30, 172);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "Tháng lương:";
            // 
            // cbxgv
            // 
            this.cbxgv.AutoResize = false;
            this.cbxgv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbxgv.Depth = 0;
            this.cbxgv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbxgv.DropDownHeight = 174;
            this.cbxgv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxgv.DropDownWidth = 121;
            this.cbxgv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbxgv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbxgv.FormattingEnabled = true;
            this.cbxgv.IntegralHeight = false;
            this.cbxgv.ItemHeight = 43;
            this.cbxgv.Location = new System.Drawing.Point(169, 90);
            this.cbxgv.Margin = new System.Windows.Forms.Padding(4);
            this.cbxgv.MaxDropDownItems = 4;
            this.cbxgv.MouseState = MaterialSkin.MouseState.OUT;
            this.cbxgv.Name = "cbxgv";
            this.cbxgv.Size = new System.Drawing.Size(244, 49);
            this.cbxgv.StartIndex = 0;
            this.cbxgv.TabIndex = 24;
            this.cbxgv.SelectedIndexChanged += new System.EventHandler(this.cbxgv_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(30, 103);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Giảng viên:";
            // 
            // dtgvLuong
            // 
            this.dtgvLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvLuong.Location = new System.Drawing.Point(6, 350);
            this.dtgvLuong.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvLuong.Name = "dtgvLuong";
            this.dtgvLuong.RowHeadersWidth = 51;
            this.dtgvLuong.Size = new System.Drawing.Size(712, 276);
            this.dtgvLuong.TabIndex = 22;
            // 
            // FrmTinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 676);
            this.Controls.Add(this.btn_xoa2);
            this.Controls.Add(this.txt_tientietvuot);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.dtgvTietvuot);
            this.Controls.Add(this.txt_tienluong);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.dateTimeThangLuong);
            this.Controls.Add(this.txt_diemthidua);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_tinhluong);
            this.Controls.Add(this.txt_th);
            this.Controls.Add(this.txt_lt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cbxgv);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtgvLuong);
            this.Name = "FrmTinhLuong";
            this.Text = "FrmTinhLuong";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTietvuot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_xoa2;
        private MaterialSkin.Controls.MaterialTextBox2 txt_tientietvuot;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.DataGridView dtgvTietvuot;
        private MaterialSkin.Controls.MaterialTextBox2 txt_tienluong;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dateTimeThangLuong;
        private MaterialSkin.Controls.MaterialTextBox2 txt_diemthidua;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btn_luu;
        private MaterialSkin.Controls.MaterialButton btn_xoa;
        private MaterialSkin.Controls.MaterialButton btn_tinhluong;
        private MaterialSkin.Controls.MaterialTextBox2 txt_th;
        private MaterialSkin.Controls.MaterialTextBox2 txt_lt;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbxgv;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dtgvLuong;
    }
}