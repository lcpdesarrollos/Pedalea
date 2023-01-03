using Pedalea.DomainEntities.Entities;

namespace Pedalea.Web.Services.Product
{
    public interface IProductService
    {
        Task<bool> InsertProduct(ProductEntity entity);
        Task<bool> EditProduct(ProductEntity entity);
        Task<bool> DeleteProduct(int Id);
        Task<List<ProductEntity>> GetAllProducts();
    }
}
