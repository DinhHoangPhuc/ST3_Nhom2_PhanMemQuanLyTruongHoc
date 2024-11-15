using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class LayDuLieuLuong
    {
        QLTLDataContext qltl = new QLTLDataContext();
        public float LayHeSoChucVu(string maChucVu)
        {
            using (var context = new QLTLDataContext())
            {
                return (float)(context.CHUCVUs
                                      .Where(cv => cv.MACHUCVU == maChucVu)
                                      .Select(cv => cv.HESOCHUCVU)
                                      .FirstOrDefault() ?? 0);
            }
        }

        public float LayPhuCapThamNien(int thamNien)
        {
            if (thamNien < 5)
                return 0;
            return 0.05f + (thamNien - 5) * 0.01f;
        }

        public decimal LayMucTroCapChucVu(string maChucVu)
        {
            using (var context = new QLTLDataContext())
            {
                return (decimal)(context.CHUCVUs
                              .Where(cv => cv.MACHUCVU == maChucVu)
                              .Select(cv => cv.MUCTROCAPCHUCVU)
                              .FirstOrDefault() ?? 0);
            }
        }

        public int LayDiemThiDuaTheoThang(string maGiangVien, DateTime thangLuong)
        {
            var diemThiDua = qltl.DIEMTHIDUATHEOTHANGs
                                 .Where(d => d.MAGIANGVIEN == maGiangVien &&
                                             d.THANG.Year == thangLuong.Year &&
                                             d.THANG.Month == thangLuong.Month)
                                 .Select(d => d.DIEMTHIDUA)
                                 .FirstOrDefault();

            return diemThiDua ?? 0;
        }


        public double CalculateLuongCung(GIANGVIEN giangVien)
        {
            double heSoLuong = giangVien.HESOLUONG ?? 0;
            float heSoChucVu = LayHeSoChucVu(giangVien.CHUCVU);
            const float mucLuongCoBan = 2340000;
            const float phuCapDungLop = 0.25f;
            float phuCapThamNien = LayPhuCapThamNien(giangVien.THAMNIENCONGTAC ?? 0);

            return (heSoLuong + heSoChucVu) * mucLuongCoBan * (1 + phuCapDungLop + phuCapThamNien);
        }
        
     
        public decimal layTroCapThem(GIANGVIEN gv, TIENLUONGTHEOTHANG tl)
        {
            decimal mucTroCapChucVu = LayMucTroCapChucVu(gv.CHUCVU);
            int diemThiDua = LayDiemThiDuaTheoThang(gv.MAGIANGVIEN, tl.THANGLUONG);
            decimal tyLeTroCap = (diemThiDua >= 8) ? 1 : (diemThiDua >= 6) ? 0.7m : (diemThiDua >= 4) ? 0.5m : 0.3m;
            decimal troCapThem = mucTroCapChucVu * tyLeTroCap;
            return troCapThem;
        }
    }
}
