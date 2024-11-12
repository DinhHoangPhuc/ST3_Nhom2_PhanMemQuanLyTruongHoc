using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ViPham
    {
        private QLTLDataContext qltl;

        public ViPham()
        {
            qltl = new QLTLDataContext();
        }

        public List<VIPHAM> GetViPhamByMonth(string maGV, DateTime date)
        {
            return qltl.VIPHAMs.Where(item => item.MAGIANGVIEN == maGV && item.THANGVIPHAM.Value.Year == date.Year && item.THANGVIPHAM.Value.Month == date.Month).OrderBy(item => item.THANGVIPHAM.Value.Day).ToList();
        }
    }
}
