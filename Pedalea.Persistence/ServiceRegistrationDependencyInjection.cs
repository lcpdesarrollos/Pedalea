using Microsoft.Extensions.DependencyInjection;
using Pedalea.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalea.Persistence
{
    public static class ServiceRegistrationDependencyInjection
    {
        public static void DependencyInjectionPedaleaPersistence(this IServiceCollection services)
        {
            services.AddSingleton<ConnectionStrings>();
        }
    }
}
