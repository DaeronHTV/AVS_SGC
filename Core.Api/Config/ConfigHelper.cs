using Microsoft.Extensions.Configuration;
using NSwag;

namespace Core.Api.Config
{
    public static class ConfigHelper
    {
        public static OpenApiInfo ApiInformation { get; private set; }

        public static MailConnection MailConnection { get; private set; }

        public static void Initialisation(IConfiguration configuration)
        {
            ApiInformation = configuration.GetSection(nameof(OpenApiInfo)).Get<OpenApiInfo>();
        }
    }
}
