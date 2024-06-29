using Restaurant.Interfaces;
using Restaurant.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Managers
{
    public class WaiterManager : IWaiterService
    {
        public void Add(Waiter waiter)
        {
            Console.WriteLine($"{waiter.FullName} added" );
        }
    }
}
