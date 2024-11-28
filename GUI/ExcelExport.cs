using BUS;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    class ExcelExport
    {
        LayDuLieuLuong get = new LayDuLieuLuong();

        public void ExportTienLuongTheoThang(TIENLUONGTHEOTHANG tienLuong, ref string fileName, bool isPrintPreview = false)
        {
            Dictionary<string, string> replacer = new Dictionary<string, string>();
            string ngay = $"Tháng {tienLuong.THANGLUONG.Month} năm {tienLuong.THANGLUONG.Year}";
            replacer.Add("%NgayThangNam", ngay);

            var giangVien = get.layGiangVienTheoMa(tienLuong);
            if (giangVien != null)
            {
                replacer.Add("%MaGiangVien", giangVien.MAGIANGVIEN);
                replacer.Add("%TENGIANGVIEN", giangVien.TENGIANGVIEN);
                replacer.Add("%HeSoLuong", giangVien.HESOLUONG?.ToString("F2") ?? "0");
                replacer.Add("%HeSoChucVu", get.LayHeSoChucVu(giangVien.CHUCVU).ToString("F2"));
                replacer.Add("%PhuCapThamNien", get.LayPhuCapThamNien(giangVien.THAMNIENCONGTAC ?? 0).ToString("P0"));
                replacer.Add("%LuongCung", get.CalculateLuongCung(giangVien).ToString("#,##0"));
                replacer.Add("%PhuCapDungLop", "25%");
                replacer.Add("%TroCapThem", get.layTroCapThem(giangVien, tienLuong).ToString("#,##0"));
                replacer.Add("%DiemThiDua", get.LayDiemThiDuaTheoThang(giangVien.MAGIANGVIEN, tienLuong.THANGLUONG).ToString());
            }
            if (tienLuong != null)
            {
                replacer.Add("%TongTietDay", tienLuong.TONGTIETDAY.ToString());
                replacer.Add("%Luong", tienLuong.TIENLUONG?.ToString("#,##0") ?? "0");
                var tietVuotInfo = get.layTienTietVuotTheoGiangVien(tienLuong, giangVien);

                if (tietVuotInfo != null)
                {
                    replacer.Add("%VuotLT", tietVuotInfo.SOTIETVUOTLYTHUYET.ToString());
                    replacer.Add("%VuotTH", tietVuotInfo.SOTIETVUOTTHUCHANH.ToString());
                    replacer.Add("%TienVuot", tietVuotInfo.SOTIEN?.ToString("#,##0") ?? "0");
                }
                else
                {
                    replacer.Add("%VuotLT", "0");
                    replacer.Add("%VuotTH", "0");
                    replacer.Add("%TienVuot", "0");
                }
            }

            MemoryStream stream = new MemoryStream(File.ReadAllBytes("Template_TienLuong.xlsx"));
            ExcelEngine engine = new ExcelEngine();
            IWorkbook workbook = engine.Excel.Workbooks.Open(stream);
            IWorksheet worksheet = workbook.Worksheets[0];
            ITemplateMarkersProcessor markProcessor = worksheet.CreateTemplateMarkersProcessor();

            foreach (var repl in replacer)
            {
                worksheet.Replace(repl.Key, repl.Value);
            }

            // Get the path to the Downloads directory
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string file = Path.Combine(downloadsPath, "TienLuong_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".xlsx");
            fileName = file;

            if (!FileCommon.IsFileOpenOrReadOnly(file))
            {
                workbook.SaveAs(file);
            }
            workbook.Close();
            engine.Dispose();

            if (!string.IsNullOrEmpty(fileName) && MessageBox.Show("File đã được lưu ở thư mục Downloads, Bạn có muốn mở file không?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(fileName);
            }
        }

        private static void Replace(IWorksheet workSheet, string findValue, string replaceValue)
        {
            // Find and replace
            if (workSheet != null && !string.IsNullOrEmpty(findValue))
            {
                // Get current cells
                IRange[] cells = workSheet.Range.Cells;
                IRange range = null;

                // Loop cells to replace
                for (int i = 0; i < cells.Count(); i++)
                {
                    // Current cell
                    range = cells[i];

                    // Find and replace values
                    if (range != null && range.DisplayText.Contains(findValue))
                    {
                        range.Text = range.Text.Replace(findValue, replaceValue);
                        break;
                    }
                }
            }
        }
    }
}
