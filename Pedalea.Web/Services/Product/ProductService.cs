using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using Pedalea.DomainEntities.Entities;
using System.Net;
using System.Text;

namespace Pedalea.Web.Services.Product
{
    public class ProductService : IProductService
    {
        private HttpClient _httpClient;
        private NavigationManager _navigationManager;
        private IConfiguration _configuration;

        public ProductService(HttpClient httpClient, NavigationManager navigationManager, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _navigationManager = navigationManager;
            _configuration = configuration;

            if (_httpClient.BaseAddress == null)
            {
                var uri = configuration["BaseUrlPedaleaApi"];
                _httpClient.BaseAddress = new Uri(uri);
            }
        }

        public async Task<bool> DeleteProduct(int Id)
        {
            bool result = false;
            try
            {
                var response = await _httpClient.DeleteAsync("product/deleteproduct/" + Id);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<bool>(jsonResponse);
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public async Task<bool> EditProduct(ProductEntity entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductEntity>> GetAllProducts()
        {
            List<ProductEntity> products = new List<ProductEntity>();
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpResponseMessage response = await _httpClient.GetAsync("product/getallproducts");
                var jsonResponse = await response.Content.ReadAsStringAsync();
                products = JsonConvert.DeserializeObject<List<ProductEntity>>(jsonResponse);
            }
            catch (Exception ex)
            {
                
            }

            return products;
        }

        public async Task<bool> InsertProduct(ProductEntity entity)
        {
            bool result = false;
            try
            {
                var jsonData = JsonConvert.SerializeObject(entity);
                var request = new StringContent(jsonData, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync("product/insertproduct", request);
                var jsonResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<bool>(jsonResponse);
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }
    }
}
