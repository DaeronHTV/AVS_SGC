using NSwag;

namespace SGCServeur.Config
{
    public class ApiInformation
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Version { get; set; }

        public OpenApiContact Contact { get; set; }

        public OpenApiLicense License { get; set; }
    }
}
