using Restaurant.Abstract;
using Restaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Managers
{
    internal abstract class AbstractCategoryManager : ICategoryService
    {
        public void Add(Category category)
        {
            Console.WriteLine($"{category.Name} added");
        }

        public void Delete(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
