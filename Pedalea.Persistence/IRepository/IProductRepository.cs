using Pedalea.DomainEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalea.Persistence.IRepository
{
    public interface IProductRepository
    {
        bool InsertProduct(ProductEntity entity);
        bool EditProduct(ProductEntity entity);
        bool DeleteProduct(int Id);
        List<ProductEntity> GetAllProducts();
    }
}
