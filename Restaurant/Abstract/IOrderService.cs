using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Abstract
{
    public interface IOrderService:IBaseService<Order>
    {
        void Update(Order order);
        void Delete(Order order);
    }
}
