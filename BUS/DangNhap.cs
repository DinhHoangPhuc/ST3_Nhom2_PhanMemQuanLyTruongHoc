using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DangNhap
    {
        private QLTLDataContext qltl;

        public DangNhap()
        {
            qltl = new QLTLDataContext();
        }

        public bool Login(string taiKhoan, string matKhau)
        {
            var nguoiDungRecord = qltl.NGUOIDUNGs.Where(nd => nd.TENDANGNHAP.Equals(taiKhoan) && nd.MATKHAU.Equals(matKhau)).FirstOrDefault();

            if(nguoiDungRecord != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckHoatDongTaiKhoan(string taiKhoan)
        {
            var nguoiDungRecord = qltl.NGUOIDUNGs.Where(nd => nd.TENDANGNHAP.Equals(taiKhoan)).FirstOrDefault();

            if (nguoiDungRecord != null && nguoiDungRecord.HOATDONG == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
