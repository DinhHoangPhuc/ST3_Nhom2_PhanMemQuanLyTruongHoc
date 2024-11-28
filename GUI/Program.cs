using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Khởi tạo MaterialSkinManager và thiết lập theme dựa trên Settings
            var materialSkinManager = MaterialSkinManager.Instance;
            if (Properties.Settings.Default.IsDarkTheme)
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }

            Application.Run(new FormDangNhap());
            //Application.Run(new FormTrangChu());
        }
    }
}
