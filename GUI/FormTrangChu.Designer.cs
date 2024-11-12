
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
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.tabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TrangChuPage = new System.Windows.Forms.TabPage();
            this.DiemThiDuaViPhamPage = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialSwitch1
            // 
            this.materialSwitch1.AutoSize = true;
            this.materialSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(1148, 31);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(125, 37);
            this.materialSwitch1.TabIndex = 0;
            this.materialSwitch1.Text = "Sáng/Tối";
            this.materialSwitch1.UseVisualStyleBackColor = false;
            this.materialSwitch1.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.TrangChuPage);
            this.tabControl.Controls.Add(this.DiemThiDuaViPhamPage);
            this.tabControl.Depth = 0;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.ImageList = this.imageList1;
            this.tabControl.Location = new System.Drawing.Point(3, 64);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.TrangChuPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrangChuPage.Name = "TrangChuPage";
            this.TrangChuPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TrangChuPage.Size = new System.Drawing.Size(1768, 910);
            this.TrangChuPage.TabIndex = 0;
            this.TrangChuPage.Text = "Trang chủ";
            this.TrangChuPage.UseVisualStyleBackColor = true;
            // 
            // DiemThiDuaViPhamPage
            // 
            this.DiemThiDuaViPhamPage.ImageKey = "icons8-ratings-26.png";
            this.DiemThiDuaViPhamPage.Location = new System.Drawing.Point(4, 39);
            this.DiemThiDuaViPhamPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DiemThiDuaViPhamPage.Name = "DiemThiDuaViPhamPage";
            this.DiemThiDuaViPhamPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DiemThiDuaViPhamPage.Size = new System.Drawing.Size(1663, 731);
            this.DiemThiDuaViPhamPage.TabIndex = 1;
            this.DiemThiDuaViPhamPage.Text = "Điểm thi đua";
            this.DiemThiDuaViPhamPage.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-home-26.png");
            this.imageList1.Images.SetKeyName(1, "icons8-ratings-26.png");
            // 
            // FormTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 1019);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.materialSwitch1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tabControl;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTrangChu";
            this.Padding = new System.Windows.Forms.Padding(3, 64, 3, 2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrangChuForm";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;
        private MaterialSkin.Controls.MaterialTabControl tabControl;
        private System.Windows.Forms.TabPage TrangChuPage;
        private System.Windows.Forms.TabPage DiemThiDuaViPhamPage;
        private System.Windows.Forms.ImageList imageList1;
    }
}