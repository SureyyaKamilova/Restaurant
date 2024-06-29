using Restaurant.Interfaces;
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
        public string OrderNo { get; set; }
        public string OrderDescription { get; set; }

    }
}
