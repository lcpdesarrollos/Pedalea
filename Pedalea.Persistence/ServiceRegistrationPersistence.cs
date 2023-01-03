using Microsoft.Extensions.DependencyInjection;
using Pedalea.Persistence.Context;
using Pedalea.Persistence.IRepository;
using Pedalea.Persistence.Repository;

namespace Pedalea.Persistence
{
    public static class ServiceRegistrationPersistence
    {
        public static void DependencyInjectionPedaleaPersistence(this IServiceCollection services)
        {
            services.AddSingleton<ConnectionStrings>();
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
