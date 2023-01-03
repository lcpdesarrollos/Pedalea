using Pedalea.BusinessCore.ILogic;
using Pedalea.DomainEntities.Entities;
using Pedalea.Persistence.IRepository;
using Pedalea.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalea.BusinessCore.Logic
{
    public class ProductLogic : IProductLogic
    {
        private IProductRepository _productRepository { get; set; }

        public ProductLogic(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool InsertProduct(ProductEntity entity)
        {
            bool result = _productRepository.InsertProduct(entity);
            return result;
        }

        public bool EditProduct(ProductEntity entity)
        {
            bool result = _productRepository.EditProduct(entity);
            return result;
        }

        public bool DeleteProduct(int Id)
        {
            bool result = _productRepository.DeleteProduct(Id);
            return result;
        }

        public List<ProductEntity> GetAllProducts()
        {
            return _productRepository.GetAllProducts();
        }
    }
}
