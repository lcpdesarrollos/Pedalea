using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pedalea.BusinessCore.ILogic;
using Pedalea.DomainEntities.Entities;

namespace Pedalea.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductLogic _productLogic { get; set; }

        public ProductController(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        [HttpPost]
        public IActionResult InsertProduct(ProductEntity entity)
        {
            return Ok(_productLogic.InsertProduct(entity));
        }

        [HttpPost]
        public IActionResult EditProduct(ProductEntity entity)
        {
            return Ok(_productLogic.EditProduct(entity));
        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteProduct(int Id)
        {
            return Ok(_productLogic.DeleteProduct(Id));
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            return Ok(_productLogic.GetAllProducts());
        }

    }
}
