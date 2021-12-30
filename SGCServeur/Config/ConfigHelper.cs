using Microsoft.Extensions.Configuration;
using NSwag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SGCServeur.Config
{
    public static class ConfigHelper
    {
        public static MailConnection mailConf { get; set; }

        public static LogsConfig LogsConf { get; set; }

        public static ApiInformation apiConf { get; set; }

        public static void Initialisation(IConfiguration configuration)
        {

            //var connectionString = Configuration.GetConnectionString("DefaultConnection");
            apiConf = configuration.GetSection(nameof(ApiInformation)).Get<ApiInformation>();
            mailConf = configuration.GetSection(nameof(MailConnection)).Get<MailConnection>();
        }

        public static Action<OpenApiDocument> GetSwaggerInfo()
        {
            return null;
        }
        
    }
}
