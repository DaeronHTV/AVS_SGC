using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;
using System.ComponentModel;
using System.Threading.Tasks;

namespace SGCServeur.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [OpenApiTag("Api", Description = "Informations sur le serveur")]
    public class ApiController : ControllerBase
    {
        public ApiController()
        {
        }

        [HttpGet, Route("version")]
        [Description("Retourne la version actuelle du serveur")]
        public async Task<string> GetVersion()
        {
            return "alpha";
        }
    }
}
