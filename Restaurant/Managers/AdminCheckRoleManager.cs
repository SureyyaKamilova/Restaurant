using Restaurant.Abstract;
using Restaurant.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Managers
{
    internal class AdminCheckRoleManager : ICheckRoleService
    {
        enum RoleEnum
        {
            Admin,
            Waiter,
            Cashier
        }
        public bool CheckAdminRole(Admin admin)
        {
            if (RoleEnum.Admin.ToString() == admin.Role)
                return true;
            else
                return false;
        }
    }
}
