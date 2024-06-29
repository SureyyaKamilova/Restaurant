using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Interfaces
{
    public interface IService<T> where T : class,IEntity
    {
        void Add(T t);
        
    }
}
