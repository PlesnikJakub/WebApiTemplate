using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Modules
{
    public class ConfigurationProvider : Application.Providers.IConfigurationProvider
    {
        private readonly IConfiguration Configuration;

        public ConfigurationProvider(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public string GetConfiguration(string key)
        {
            return Configuration.GetValue<string>(key);
        }
    }
}
