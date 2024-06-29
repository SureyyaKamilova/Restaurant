using Restaurant.Interfaces;
using Restaurant.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Managers
{
    public class AdminManager : IAdminService
    {
        public void Add(Admin admin)
        {
            Console.WriteLine($"{admin.FullName} added");
        }

        public void Delete(Admin admin)
        {
            Console.WriteLine($"{admin.FullName} added");
        }

        public void Update(Admin admin)
        {
            Console.WriteLine($"{admin.FullName} added");
        }
    }
}
