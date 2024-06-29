using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
