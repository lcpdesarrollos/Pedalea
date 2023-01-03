using Microsoft.Extensions.DependencyInjection;
using Pedalea.BusinessCore.ILogic;
using Pedalea.BusinessCore.Logic;

namespace Pedalea.BusinessCore
{
    public static class ServiceRegistrationBusinessCore
    {
        public static void DependencyInjectionPedaleaBusinessCore(this IServiceCollection services)
        {
            services.AddTransient<IProductLogic, ProductLogic>();
        }
    }
}
