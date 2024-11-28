using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QL_ViPham
    {
        private QLTLDataContext qltl;

        public QL_ViPham()
        {
            qltl = new QLTLDataContext();
        }


        public List<VIPHAM> GetViPhamByMonth(string maGV, DateTime date)
        {
            return qltl.VIPHAMs.Where(item => item.MAGIANGVIEN == maGV && item.THANGVIPHAM.Value.Year == date.Year && item.THANGVIPHAM.Value.Month == date.Month).OrderBy(item => item.THANGVIPHAM.Value.Day).ToList();
        }

        public List<VIPHAM> GetViPham()
        {
            return qltl.VIPHAMs.ToList();
        }
        public List<GIANGVIEN> GetGiangVien()
        {
            return qltl.GIANGVIENs.ToList();
        }
        public string GenerateNewViPhamCode()
        {
            using (var dataContext = new QLTLDataContext())
            {
                var lastViPham = dataContext.VIPHAMs
                    .OrderByDescending(vp => vp.MAVIPHAM)
                    .FirstOrDefault();

                if (lastViPham == null)
                {

                    return "VP001";
                }
                else
                {
                    string lastCode = lastViPham.MAVIPHAM.Substring(2);
                    int newCodeNumber = int.Parse(lastCode) + 1;

                    return "VP" + newCodeNumber.ToString("D3");
                }
            }
        }
        public void AddViPham(string tenViPham, string ghiChu, int diemTru, DateTime thangViPham, string maGiangVien, Action<string> notify)
        {
            using (var dataContext = new QLTLDataContext())
            {
                if (string.IsNullOrEmpty(maGiangVien))
                {
                    notify("Vui lòng chọn giảng viên.");
                    return;
                }

                string maViPham = GenerateNewViPhamCode();

                var viPham = new VIPHAM
                {
                    MAVIPHAM = maViPham,
                    TENVIPHAM = tenViPham,
                    GHICHU = ghiChu,
                    DIEMTRU = diemTru,
                    THANGVIPHAM = thangViPham,
                    MAGIANGVIEN = maGiangVien
                };

                dataContext.VIPHAMs.InsertOnSubmit(viPham);

                try
                {
                    dataContext.SubmitChanges();
                    notify("Thêm vi phạm thành công!");
                }
                catch (Exception ex)
                {
                    notify("Lỗi: " + ex.Message);
                }
            }

        }

        public void EditViPham(string maViPham, string tenViPham, string ghiChu, int diemTru, DateTime thangViPham, string maGiangVien, Action<string> notify)
        {
            using (var dataContext = new QLTLDataContext())
            {
                if (string.IsNullOrEmpty(maGiangVien))
                {
                    notify("Vui lòng chọn giảng viên.");
                    return;
                }

                var viPham = dataContext.VIPHAMs
                    .FirstOrDefault(vp => vp.MAVIPHAM == maViPham);

                if (viPham == null)
                {
                    notify("Không tìm thấy mã vi phạm!");
                    return;
                }

                viPham.TENVIPHAM = tenViPham;
                viPham.GHICHU = ghiChu;
                viPham.DIEMTRU = diemTru;
                viPham.THANGVIPHAM = thangViPham;
                viPham.MAGIANGVIEN = maGiangVien;

                try
                {
                    dataContext.SubmitChanges();
                    notify("Sửa vi phạm thành công!");
                }
                catch (Exception ex)
                {
                    notify("Lỗi: " + ex.Message);
                }
            }
        }

        public void DeleteViPham(string maViPham, Action<string> notify)
        {
            using (var dataContext = new QLTLDataContext())
            {
                var viPham = dataContext.VIPHAMs
                    .FirstOrDefault(vp => vp.MAVIPHAM == maViPham);

                if (viPham == null)
                {
                    notify("Không tìm thấy mã vi phạm!");
                    return;
                }

                dataContext.VIPHAMs.DeleteOnSubmit(viPham);

                try
                {
                    dataContext.SubmitChanges();
                    notify("Xóa vi phạm thành công!");
                }
                catch (Exception ex)
                {
                    notify("Lỗi: " + ex.Message);
                }
            }
        }
    }
}
