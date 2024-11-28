using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserService
    {
        private QLTLDataContext db;

        public UserService()
        {
            db = new QLTLDataContext();
        }

        public string GetUserGroup(string username)
        {
            var userGroup = db.NGUOIDUNG_NHOMNGUOIDUNGs
                              .Where(u => u.TENDANGNHAP == username)
                              .Select(u => u.MANHOM)
                              .FirstOrDefault();
            return userGroup;
        }

        public List<string> GetPermissions(string userGroup)
        {
            var permissions = db.PHANQUYENs
                                .Where(p => p.MANHOMNGUOIDUNG == userGroup && p.COQUYEN == true)
                                .Select(p => p.MAMANHINH)
                                .ToList();
            return permissions;
        }
    }
}
