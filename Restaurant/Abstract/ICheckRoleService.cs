using Restaurant.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Abstract
{
    internal interface ICheckRoleService
    {
        bool CheckAdminRole(Admin admin);
    }
}
