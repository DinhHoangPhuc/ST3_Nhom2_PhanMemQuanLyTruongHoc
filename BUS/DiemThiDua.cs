using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DiemThiDua
    {
        private QLTLDataContext qltl;

        public DiemThiDua()
        {
            qltl = new QLTLDataContext();
        }

        public List<DIEMTHIDUATHEOTHANG> GetDiemThiDuaByGiangVien(string maGV, int year)
        {
            return qltl.DIEMTHIDUATHEOTHANGs.Where(d => d.GIANGVIEN.MAGIANGVIEN == maGV && d.THANG.Year == year
            ).OrderBy(d => d.THANG.Month).ToList();
        }

        public List<double> GetListDiemThiDuaByGiangVien(string maGV, int year)
        {
            return GetDiemThiDuaByGiangVien(maGV, year)
        .Select(d => d.DIEMTHIDUA.HasValue ? (double)d.DIEMTHIDUA.Value : 0.0)
        .ToList();
        }

        public List<DIEMTHIDUATHEOTHANG> GetAllDiemThiDuaByThangAndNam(int thang, int nam)
        {
            return qltl.DIEMTHIDUATHEOTHANGs.Where(d => d.THANG.Month == thang && d.THANG.Year == nam).ToList();
        }

        public List<GIANGVIEN> GetAllGiangVien()
        {
            return qltl.GIANGVIENs.ToList();
        }


        public List<CHUCVU> GetChucVuByID(string maCHucVu)
        {
            return qltl.CHUCVUs.Where(c => c.MACHUCVU == maCHucVu).ToList();
        }

    }
}
