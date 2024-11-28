namespace GUI
{
    partial class FormQuanLyNguoiDung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.btnLuu = new MaterialSkin.Controls.MaterialButton();
            this.txtTimTheoUsername = new MaterialSkin.Controls.MaterialTextBox();
            this.btnTimKiem = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLamMoi = new MaterialSkin.Controls.MaterialButton();
            this.btnThemMoi = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNguoiDung
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvNguoiDung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNguoiDung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguoiDung.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNguoiDung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNguoiDung.EnableHeadersVisualStyles = false;
            this.dgvNguoiDung.Location = new System.Drawing.Point(4, 73);
            this.dgvNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.RowHeadersWidth = 51;
            this.dgvNguoiDung.Size = new System.Drawing.Size(1742, 497);
            this.dgvNguoiDung.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLuu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLuu.Depth = 0;
            this.btnLuu.HighEmphasis = true;
            this.btnLuu.Icon = null;
            this.btnLuu.Location = new System.Drawing.Point(1676, 6);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLuu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLuu.Size = new System.Drawing.Size(64, 36);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLuu.UseAccentColor = false;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTimTheoUsername
            // 
            this.txtTimTheoUsername.AnimateReadOnly = false;
            this.txtTimTheoUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimTheoUsername.Depth = 0;
            this.txtTimTheoUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimTheoUsername.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimTheoUsername.LeadingIcon = null;
            this.txtTimTheoUsername.Location = new System.Drawing.Point(3, 3);
            this.txtTimTheoUsername.MaxLength = 50;
            this.txtTimTheoUsername.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTimTheoUsername.Multiline = false;
            this.txtTimTheoUsername.Name = "txtTimTheoUsername";
            this.txtTimTheoUsername.Size = new System.Drawing.Size(358, 50);
            this.txtTimTheoUsername.TabIndex = 7;
            this.txtTimTheoUsername.Text = "";
            this.txtTimTheoUsername.TrailingIcon = null;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTimKiem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTimKiem.Depth = 0;
            this.btnTimKiem.HighEmphasis = true;
            this.btnTimKiem.Icon = null;
            this.btnTimKiem.Location = new System.Drawing.Point(368, 6);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTimKiem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Size = new System.Drawing.Size(86, 36);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnTimKiem.UseAccentColor = false;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvNguoiDung, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.995365F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.5168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1750, 863);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.87156F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.12844F));
            this.tableLayoutPanel2.Controls.Add(this.txtTimTheoUsername, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTimKiem, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1744, 63);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.76942F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.23058F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel3.Controls.Add(this.btnLuu, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLamMoi, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnThemMoi, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 577);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1744, 283);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLamMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLamMoi.Depth = 0;
            this.btnLamMoi.HighEmphasis = true;
            this.btnLamMoi.Icon = null;
            this.btnLamMoi.Location = new System.Drawing.Point(1309, 6);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLamMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnLamMoi.Size = new System.Drawing.Size(83, 36);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLamMoi.UseAccentColor = false;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemMoi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThemMoi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThemMoi.Depth = 0;
            this.btnThemMoi.HighEmphasis = true;
            this.btnThemMoi.Icon = null;
            this.btnThemMoi.Location = new System.Drawing.Point(1457, 6);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnThemMoi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThemMoi.Size = new System.Drawing.Size(185, 36);
            this.btnThemMoi.TabIndex = 8;
            this.btnThemMoi.Text = "Thêm mới người dùng";
            this.btnThemMoi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThemMoi.UseAccentColor = false;
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // FormQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 863);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormQuanLyNguoiDung";
            this.Text = "FormQuanLyNguoiDung";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private MaterialSkin.Controls.MaterialButton btnLuu;
        private MaterialSkin.Controls.MaterialTextBox txtTimTheoUsername;
        private MaterialSkin.Controls.MaterialButton btnTimKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialButton btnThemMoi;
        private MaterialSkin.Controls.MaterialButton btnLamMoi;
    }
}