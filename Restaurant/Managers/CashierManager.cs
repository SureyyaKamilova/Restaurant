using Restaurant.Interfaces;
using Restaurant.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Managers
{
    public class CashierManager : ICashierService
    {
        public void Add(Cashier cashier)
        {
            Console.WriteLine($"{cashier.FullName} added");
        }
    }
}
