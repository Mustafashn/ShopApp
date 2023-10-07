using System.Collections.Generic;
using shopapp.entity;

namespace shopapp.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductDetails(string productname);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        List<Product> GetPopularProducts();
        List<Product> GetSearchResult(string searchString);
        List<Product> GetHomePageProducts();
        Product GetByIdWithCategories(int id);
        int GetCountByCategory(string category);
        void Update(Product entity, int[] categoryIds);
    }
}