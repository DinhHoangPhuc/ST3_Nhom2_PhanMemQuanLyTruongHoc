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
        public TIENLUONGTHEOTHANG layTienLuong(String gv, int thang)
        {
            TIENLUONGTHEOTHANG luong = qltl.TIENLUONGTHEOTHANGs.FirstOrDefault(t => t.MAGIANGVIEN == gv && t.THANGLUONG.Month == thang);
            return luong;
        }
        public TIENLUONGTHEOTHANG GetLuongInfo(string maGV, DateTime thangLuong)
        {

            TIENLUONGTHEOTHANG luongInfo = qltl.TIENLUONGTHEOTHANGs
                    .Where(t => t.MAGIANGVIEN == maGV &&
                                t.THANGLUONG.Year == thangLuong.Year &&
                                t.THANGLUONG.Month == thangLuong.Month)

                    .FirstOrDefault();

            return luongInfo;

        }
        public TIENTIETVUOT getTienTietVuotInfo(string maGV, int year)
        {
            TIENTIETVUOT vuot = qltl.TIENTIETVUOTs
                    .Where(tv => tv.MAGIANGVIEN == maGV &&
                                tv.MANAMHOC == $"NH{year}")

                    .FirstOrDefault();
            return vuot;
        }

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
        public GIANGVIEN layGiangVienTheoMa(TIENLUONGTHEOTHANG tienLuong)
        {

            return qltl.GIANGVIENs.FirstOrDefault(nv => nv.MAGIANGVIEN == tienLuong.MAGIANGVIEN);
        }
        public GIANGVIEN timGV(String username)
        {
            GIANGVIEN gv = qltl.GIANGVIENs.Where(t => t.MAGIANGVIEN == username).FirstOrDefault();
            return gv;
        }
        public TIENTIETVUOT layTienTietVuotTheoGiangVien(TIENLUONGTHEOTHANG tienLuong, GIANGVIEN giangVien)
        {
            return qltl.TIENTIETVUOTs
                   .Where(tv => tv.MAGIANGVIEN == giangVien.MAGIANGVIEN &&
                               tv.MANAMHOC == $"NH{tienLuong.THANGLUONG.Year}")
                   //.Select(tv => new { tv.SOTIETVUOTLYTHUYET, tv.SOTIETVUOTTHUCHANH, tv.SOTIEN })
                   .FirstOrDefault();
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
