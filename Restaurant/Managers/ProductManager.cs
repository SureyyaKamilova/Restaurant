using Restaurant.Entities;
using Restaurant.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Users;

namespace Restaurant.Managers
{
    internal class ProductManager(ICheckRoleService checkRoleService,Admin admin) : AbstractProductManager
    {
        private readonly ICheckRoleService _roleService;

        public override void Add(Product product)
        {
            if(_roleService.CheckAdminRole(admin))
                 base.Add(product);
            else
                Console.WriteLine("You do not have permission for this process");
        }
    }
}
