using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhanQuyenNguoiDung
    {
        QLTLDataContext qltl;

        public PhanQuyenNguoiDung()
        {
            qltl = new QLTLDataContext();
        }

        public List<NHOMNGUOIDUNG> GetNHOMNGUOIDUNGs()
        {
            return qltl.NHOMNGUOIDUNGs.ToList();
        }

        public List<NGUOIDUNG> GetAllNguoiDung()
        {
            return qltl.NGUOIDUNGs.ToList();
        }

        public List<NGUOIDUNG_NHOMNGUOIDUNG> GetNGUOIDUNG_NHOMNGUOIDUNGsByMANHOM(string maNhom)
        {
            return qltl.NGUOIDUNG_NHOMNGUOIDUNGs.Where(n => n.MANHOM == maNhom).ToList();
        }

        public bool AddNguoiDung_NhomNguoiDung(string maNguoiDung, string maNhom)
        {
            try
            {
                NGUOIDUNG_NHOMNGUOIDUNG nd_nnd = new NGUOIDUNG_NHOMNGUOIDUNG();
                nd_nnd.MANHOM = maNhom;
                nd_nnd.TENDANGNHAP = maNguoiDung;
                qltl.NGUOIDUNG_NHOMNGUOIDUNGs.InsertOnSubmit(nd_nnd);
                qltl.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateNguoiDung_NhomNguoiDung(string maNguoiDung, string maNhom, string ghiChu)
        {
            try
            {
                NGUOIDUNG_NHOMNGUOIDUNG nd_nnd = qltl.NGUOIDUNG_NHOMNGUOIDUNGs.FirstOrDefault(n => n.MANHOM == maNhom && n.TENDANGNHAP == maNguoiDung);
                nd_nnd.GHICHU = ghiChu;
                qltl.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteNguoiDung_NhomNguoiDung(string maNguoiDung, string maNhom)
        {
            try
            {
                NGUOIDUNG_NHOMNGUOIDUNG nd_nnd = qltl.NGUOIDUNG_NHOMNGUOIDUNGs.FirstOrDefault(n => n.MANHOM == maNhom && n.TENDANGNHAP == maNguoiDung);
                qltl.NGUOIDUNG_NHOMNGUOIDUNGs.DeleteOnSubmit(nd_nnd);
                qltl.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<MANHINH> GetAllManHinh()
        {
            return qltl.MANHINHs.ToList();
        }

        public List<PHANQUYEN> GetPHANQUYENsByMANHOM(string maNhom)
        {
            return qltl.PHANQUYENs.Where(p => p.MANHOMNGUOIDUNG == maNhom).ToList();
        }

        public bool InsertPhanQuyen(string maNhom, string maManHinh, bool coQuyen)
        {
            try
            {
                PHANQUYEN pq = new PHANQUYEN();
                pq.MANHOMNGUOIDUNG = maNhom;
                pq.MAMANHINH = maManHinh;
                pq.COQUYEN = coQuyen;
                qltl.PHANQUYENs.InsertOnSubmit(pq);
                qltl.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdatePhanQuyen(string maNhom, string maManHinh, bool coQuyen)
        {
            try
            {
                PHANQUYEN pq = qltl.PHANQUYENs.FirstOrDefault(p => p.MANHOMNGUOIDUNG == maNhom && p.MAMANHINH == maManHinh);
                pq.COQUYEN = coQuyen;
                qltl.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePhanQuyen(string maNhom, string maManHinh)
        {
            try
            {
                PHANQUYEN pq = qltl.PHANQUYENs.FirstOrDefault(p => p.MANHOMNGUOIDUNG == maNhom && p.MAMANHINH == maManHinh);
                qltl.PHANQUYENs.DeleteOnSubmit(pq);
                qltl.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
