using Restaurant.Entities;

namespace Restaurant.Abstract
{
    public interface IProductService : IBaseService<Product>

    {

        List<Product> GetAllByCategoryId(int categoryId);


    }
}
