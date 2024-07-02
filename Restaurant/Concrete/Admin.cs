using Restaurant.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Users
{
    public class Admin:BaseEntity,IEntity
    {
        public string Role { get; set; }
    }
}
