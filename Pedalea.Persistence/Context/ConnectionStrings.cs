using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedalea.Persistence.Context
{
    public class ConnectionStrings
    {
        protected readonly IConfiguration _configuration;

        public ConnectionStrings(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string PedaleaConnectionString()
        {
            return _configuration.GetConnectionString("PedaleaConnection");
        }

    }
}
