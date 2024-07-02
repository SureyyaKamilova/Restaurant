using Restaurant.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Order:IEntity
    {
        public int Id { get; set; }
        public int HallId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public double TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
