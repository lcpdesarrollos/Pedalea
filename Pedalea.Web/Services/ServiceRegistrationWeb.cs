using Pedalea.Web.Services.Product;

namespace Pedalea.Web.Services
{
    public static class ServiceRegistrationWeb
    {
        public static void DependencyInjectionPedaleaWeb(this IServiceCollection services)
        {
            services.AddSingleton<IProductService, ProductService>();
        }
    }
}
