using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class GiangVien
    {
        private QLTLDataContext qltl;

        public GiangVien()
        {
            qltl = new QLTLDataContext();
        }
        public List<GIANGVIEN> GetGiangVien()
        {
            return qltl.GIANGVIENs.ToList();
        }
    }
}
