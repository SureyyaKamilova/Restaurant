using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Interfaces
{
    public interface IOrderService:IService<Order>
    {
        void Update(Order order);
        void Delete(Order order);
    }
}
