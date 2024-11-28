using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PermissionService
    {
        private QLTLDataContext db;

        public PermissionService()
        {
            db = new QLTLDataContext();
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
